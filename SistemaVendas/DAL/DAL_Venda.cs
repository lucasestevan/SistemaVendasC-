using Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_Venda
    {
        private DAL_Conexao conexao;
        public DAL_Venda(DAL_Conexao con)
        {
            this.conexao = con;
        }

        //METODO INCLUIR
        public void Incluir(Model_Venda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into Venda (dataVenda, nfiscal, total, nparcelas, VendaStatus, id_cliente, id_tipoPagamento, avista)" +
                "values (@dataVenda, @nfiscal, @total, @nparcelas, @VendaStatus, @id_cliente, @id_tipoPagamento, @avista); select @@IDENTITY;";
            cmd.Parameters.Add("@dataVenda", System.Data.SqlDbType.DateTime); //data
            cmd.Parameters["@dataVenda"].Value = modelo.DataVenda; //data
            cmd.Parameters.AddWithValue("@nfiscal", modelo.NFiscal);
            cmd.Parameters.AddWithValue("@total", modelo.Total);
            cmd.Parameters.AddWithValue("@nparcelas", modelo.NParcelas);
            cmd.Parameters.AddWithValue("@VendaStatus", modelo.VendaStatus);
            cmd.Parameters.AddWithValue("@id_cliente", modelo.IdCliente);
            cmd.Parameters.AddWithValue("@id_tipoPagamento", modelo.IdTipoPagamento);
            cmd.Parameters.AddWithValue("@avista", modelo.Avista);
            conexao.Conectar();
            modelo.IdVenda = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        //METODO ALTERAR
        public void Alterar(Model_Venda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE Venda set dataVenda = @dataVenda, nfiscal = @nfiscal, total = @total, nparcelas = @nparcelas, VendaStatus = @VendaStatus," +
                "id_cliente = @id_cliente, id_tipoPagamento = @id_tipoPagamento, avista = @avista where id_venda = @id_venda";
            cmd.Parameters.AddWithValue("@id_venda", modelo.IdVenda);
            cmd.Parameters.Add("@dataVenda", System.Data.SqlDbType.DateTime); //data
            cmd.Parameters["@dataVenda"].Value = modelo.DataVenda; //data
            cmd.Parameters.AddWithValue("@nfiscal", modelo.NFiscal);
            cmd.Parameters.AddWithValue("@total", modelo.Total);
            cmd.Parameters.AddWithValue("@nparcelas", modelo.NParcelas);
            cmd.Parameters.AddWithValue("@VendaStatus", modelo.VendaStatus);
            cmd.Parameters.AddWithValue("@id_cliente", modelo.IdCliente);
            cmd.Parameters.AddWithValue("@id_tipoPagamento", modelo.IdTipoPagamento);
            cmd.Parameters.AddWithValue("@avista", modelo.Avista);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        //METODO CANCELAR VENDA
        public Boolean CancelarVenda(int idVenda)
        {
            Boolean retorno = true;
            //ATUALIZAR TABELA DE VENDA
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            conexao.Conectar();

            try
            {
                cmd.CommandText = "UPDATE Venda set VendaStatus = 'CANCELADO' where id_venda = @id_venda";
                cmd.Parameters.AddWithValue("@id_venda", idVenda);
                cmd.ExecuteNonQuery();

                //INCLEMENTEAR O ESTOQUE COM OS ITENS DA VENDA CANCELADA

                //LOCALIZAR OS ITENS DA VENDA
                DataTable dt = new DataTable();
                SqlDataAdapter da = default(SqlDataAdapter);
                da = new SqlDataAdapter("Select id_itensVenda, quantidade, id_produto from ItensVenda where id_venda = " + idVenda.ToString(), conexao.StringConexao);
                da.Fill(dt);

                //alterar a quantisdade do estoque
                Model_Produto produto;
                DAL_Conexao cxPL = new DAL_Conexao(DadoConexao.StringDeConexao);
                DAL_Produto dalProduto = new DAL_Produto(cxPL);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    produto = dalProduto.CarregaModeloProduto(Convert.ToInt32(dt.Rows[i]["id_produto"]));
                    produto.Quantidade = produto.Quantidade + Convert.ToDouble(dt.Rows[i]["quantidade"]);
                    dalProduto.Alterar(produto, true);
                }
                conexao.Desconectar();
            }
            catch (Exception)
            {
                retorno = false;
                conexao.Desconectar();
            }
            return retorno;
        }

        //METODO EXCLUIR
        public void Excluir(int idVenda)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from Venda where id_venda = @id_venda";
            cmd.Parameters.AddWithValue("@id_venda", idVenda);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        //METODO CARREGA MODELO
        public Model_Venda CarregaModeloVenda(int idVenda)
        {
            Model_Venda modelo = new Model_Venda();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from Venda where id_venda = @id_venda";
            cmd.Parameters.AddWithValue("@id_venda", idVenda);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            //SE EXITIR ALGUMA LINHA EXECUTAR
            if (registro.HasRows)
            {
                registro.Read();
                modelo.IdVenda = Convert.ToInt32(registro["id_venda"]);
                modelo.DataVenda = Convert.ToDateTime(registro["dataVenda"]);
                modelo.NFiscal = Convert.ToInt32(registro["nFiscal"]);
                modelo.Total = Convert.ToDouble(registro["total"]);
                modelo.NParcelas = Convert.ToInt32(registro["nparcelas"]);
                modelo.VendaStatus = Convert.ToString(registro["vendaStatus"]);
                modelo.IdCliente = Convert.ToInt32(registro["id_cliente"]);
                modelo.IdTipoPagamento = Convert.ToInt32(registro["id_tipoPagamento"]);
                modelo.Avista = Convert.ToInt32(registro["avista"]);
            }
            conexao.Desconectar();
            return modelo;
        }

        //METODO LOCALIZAR fgeral
        public DataTable LocalizarGeral()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = default(SqlDataAdapter);
            da = new SqlDataAdapter("select v.id_venda,  v.dataVenda, c.nome, v.nparcelas, v.total," +
                " v.vendaStatus, v.id_cliente, v.id_tipoPagamento, v.avista," +
                " v.nfiscal from Venda as v inner join Cliente as c on v.id_cliente = c.id_cliente ", conexao.StringConexao);
            da.Fill(dt);
            return dt;
        }

        //METODO LOCALIZAR IDvenda
        public DataTable LocalizaridVenda(int idVenda)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = default(SqlDataAdapter);
            da = new SqlDataAdapter("select v.id_venda,  v.dataVenda, c.nome, v.nparcelas, v.total," +
                " v.vendaStatus, v.id_cliente, v.id_tipoPagamento, v.avista," +
                " v.nfiscal from Venda as v inner join Cliente as c on v.id_cliente = c.id_cliente where v.id_venda =" + idVenda.ToString(), conexao.StringConexao);
            da.Fill(dt);
            return dt;
        }

        //METODO LOCALIZAR POR NOME DE cliente
        public DataTable LocalizarNome(String nome)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = default(SqlDataAdapter);
            da = new SqlDataAdapter("select v.id_venda,  v.dataVenda, c.nome, v.nparcelas, v.total," +
                " v.vendaStatus, v.id_cliente, v.id_tipoPagamento, v.avista," +
                "  v.nfiscal from Venda as v inner join Cliente as c on v.id_cliente = c.id_cliente where c.nome like '%" + nome + "%' order by c.nome", conexao.StringConexao);
            da.Fill(dt);
            return dt;
        }

        //METODO LOCALIZAR por data
        public DataTable LocalizarData(DateTime inicial, DateTime final)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select v.id_venda,  v.dataVenda, c.nome, v.nparcelas, v.total," +
                " v.vendaStatus, v.id_cliente, v.id_tipoPagamento, v.avista," +
                " v.nfiscal from Venda as v inner join Cliente as c on v.id_cliente = c.id_cliente" +
                " where v.dataVenda BETWEEN @inicial and @final order by v.dataVenda";

            cmd.Parameters.Add("@inicial", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@inicial"].Value = inicial;

            cmd.Parameters.Add("@final", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@final"].Value = final;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        //METODO LOCALIZAR POR parcelas em aberto
        public DataTable LocalizarParcelsAberto()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = default(SqlDataAdapter);
            da = new SqlDataAdapter("select distinct v.id_venda,  v.dataVenda, c.nome, v.nparcelas, v.total," +
                " v.vendaStatus, v.id_cliente, v.id_tipoPagamento, v.avista," +
                "  v.nfiscal from Venda as v inner join Cliente as c on v.id_cliente = c.id_cliente " +
                " inner join ParcelasVenda as p on v.id_venda = p.id_venda where p.dataPagto is NULL", conexao.StringConexao);
            da.Fill(dt);
            return dt;
        }

        //METODO LOCALIZAR parcelas nao pagas
        public int ParcelasNaoPagas(int idVenda)
        {
            int qtde = 0;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select count(id_venda) from ParcelasVenda where id_venda = @id_venda and dataàgto is NULL";
            cmd.Parameters.AddWithValue("@id_venda", idVenda);
            conexao.Conectar();
            qtde = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
            return qtde;
        }

        //METODO PAGAR Venda
        public void PagarParcelaVenda(Model_Venda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE Venda set vendaStatus = @vendaStatus where id_venda = @id_venda";
            cmd.Parameters.AddWithValue("@id_venda", modelo.IdVenda);
            cmd.Parameters.AddWithValue("@vendaStatus", modelo.VendaStatus);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
    }
}
