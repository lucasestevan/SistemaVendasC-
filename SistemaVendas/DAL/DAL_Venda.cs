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
            cmd.Parameters["@dataVenda"].Value = modelo.dataVenda; //data
            cmd.Parameters.AddWithValue("@nfiscal", modelo.nFiscal);
            cmd.Parameters.AddWithValue("@total", modelo.total);
            cmd.Parameters.AddWithValue("@nparcelas", modelo.nParcelas);
            cmd.Parameters.AddWithValue("@VendaStatus", modelo.vendaStatus);
            cmd.Parameters.AddWithValue("@id_cliente", modelo.idCliente);
            cmd.Parameters.AddWithValue("@id_tipoPagamento", modelo.idTipoPagamento);
            cmd.Parameters.AddWithValue("@avista", modelo.avista);
            conexao.Conectar();
            modelo.idVenda = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        //METODO ALTERAR
        public void Alterar(Model_Venda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE Venda set dataVenda = @dataVenda, nfiscal = @nfiscal, total = @total, nparcelas = @nparcelas, VendaStatus = @VendaStatus," +
                "id_cliente = @id_cliente, id_tipoPagamento = @id_tipoPagamento, avista = @avista where id_venda = @id_venda";
            cmd.Parameters.AddWithValue("@id_venda", modelo.idVenda);
            cmd.Parameters.Add("@dataVenda", System.Data.SqlDbType.DateTime); //data
            cmd.Parameters["@dataVenda"].Value = modelo.dataVenda; //data
            cmd.Parameters.AddWithValue("@nfiscal", modelo.nFiscal);
            cmd.Parameters.AddWithValue("@total", modelo.total);
            cmd.Parameters.AddWithValue("@nparcelas", modelo.nParcelas);
            cmd.Parameters.AddWithValue("@VendaStatus", modelo.vendaStatus);
            cmd.Parameters.AddWithValue("@id_cliente", modelo.idCliente);
            cmd.Parameters.AddWithValue("@id_tipoPagamento", modelo.idTipoPagamento);
            cmd.Parameters.AddWithValue("@avista", modelo.avista);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        //METODO CANCELAR VENDA
        public void CancelarVenda(int idVenda)
        {
            //ATUALIZAR TABELA DE VENDA
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE Venda set VendaStatus = 'CANCELADO' where id_venda = @id_venda";
            cmd.Parameters.AddWithValue("@id_venda", idVenda);
            cmd.ExecuteNonQuery();

            //INCLEMENTEAR O ESTOQUE COM OS ITENS DA VENDA CANCELADA

            //LOCALIZAR OS ITENS DA VENDA
            DataTable dt = new DataTable();
            SqlDataAdapter da = default(SqlDataAdapter);
            da = new SqlDataAdapter("Select id_itensVenda, quantidade, id_produto from ItensVenda where id_venda = " + idVenda.ToString(), conexao.StringConexao);
            da.Fill(dt);

            Model_Produto produto;
            DAL_Produto dalProduto = new DAL_Produto(conexao);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                produto = dalProduto.CarregaModeloProduto(Convert.ToInt32(dt.Rows[i]["id_produto"]));
                produto.quantidade = produto.quantidade + Convert.ToDouble(dt.Rows[i]["quantidade"]);
                dalProduto.Alterar(produto);

            }
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
                modelo.idVenda = Convert.ToInt32(registro["id_venda"]);
                modelo.dataVenda = Convert.ToDateTime(registro["dataVenda"]);
                modelo.nFiscal = Convert.ToInt32(registro["nFiscal"]);
                modelo.total = Convert.ToDouble(registro["total"]);
                modelo.nParcelas = Convert.ToInt32(registro["nparcelas"]);
                modelo.vendaStatus = Convert.ToString(registro["vendaStatus"]);
                modelo.idCliente = Convert.ToInt32(registro["id_cliente"]);
                modelo.idTipoPagamento = Convert.ToInt32(registro["id_tipoPagamento"]);
                modelo.avista = Convert.ToInt32(registro["avista"]);
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
                " v.nfiscal, from Venda as v inner join Cliente as c on v.id_cliente = c.id_cliente ", conexao.StringConexao);
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
                " v.nfiscal, from Venda as v inner join Cliente as c on v.id_cliente = c.id_cliente where v.id_venda =" + idVenda.ToString(), conexao.StringConexao);
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
                "  v.nfiscal from Venda as v inner join Cliente as c on v.id_cliente = c.id_cliente where c.nome like '%" + nome + "%' order by f.nome", conexao.StringConexao);
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
                " v.nfiscal, from Venda as v inner join Cliente as c on v.id_cliente = c.id_cliente" +
                " where v.dataVenda BETWEEN @inicial and @final order by c.dataVenda";

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
    }
}
