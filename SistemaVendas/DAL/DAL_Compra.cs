using Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_Compra
    {
        private DAL_Conexao conexao;
        public DAL_Compra(DAL_Conexao con)
        {
            this.conexao = con;
        }

        //METODO INCLUIR
        public void Incluir(Model_Compra modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into Compra (dataCompra, nfiscal, total, nparcelas, compraStatus, id_fornecedor, id_tipoPagamento)" +
                "values (@dataCompra, @nfiscal, @total, @nparcelas, @compraStatus, @id_fornecedor, @id_tipoPagamento); select @@IDENTITY;";
            cmd.Parameters.Add("@dataCompra", System.Data.SqlDbType.DateTime); //data
            cmd.Parameters["@dataCompra"].Value = modelo.dataCompra; //data
            cmd.Parameters.AddWithValue("@nfiscal", modelo.nFiscal);
            cmd.Parameters.AddWithValue("@total", modelo.total);
            cmd.Parameters.AddWithValue("@nparcelas", modelo.nParcelas);
            cmd.Parameters.AddWithValue("@compraStatus", modelo.CompraStatus);
            cmd.Parameters.AddWithValue("@id_fornecedor", modelo.idFornecedor);
            cmd.Parameters.AddWithValue("@id_tipoPagamento", modelo.idTipoPagamento);
            conexao.Conectar();
            modelo.idCompra = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        //METODO ALTERAR
        public void Alterar(Model_Compra modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE Cliente set dataCompra = @dataCompra, nfiscal = @nfiscal, total = @total, nparcelas = @nparcelas, compraStatus = @compraStatus," +
                "id_fornecedor = @id_fornecedor, id_tipoPagamento = @id_tipoPagamento where id_compra = @id_compra";
            cmd.Parameters.AddWithValue("@id_compra", modelo.idCompra);
            cmd.Parameters.Add("@dataCompra", System.Data.SqlDbType.DateTime); //data
            cmd.Parameters["@dataCompra"].Value = modelo.dataCompra; //data
            cmd.Parameters.AddWithValue("@nfiscal", modelo.nFiscal);
            cmd.Parameters.AddWithValue("@total", modelo.total);
            cmd.Parameters.AddWithValue("@nparcelas", modelo.nParcelas);
            cmd.Parameters.AddWithValue("@compraStatus", modelo.CompraStatus);
            cmd.Parameters.AddWithValue("@id_fornecedor", modelo.idFornecedor);
            cmd.Parameters.AddWithValue("@id_tipoPagamento", modelo.idTipoPagamento);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        //METODO EXCLUIR
        public void Excluir(int idCompra)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from Compra where id_compra = @id_compra";
            cmd.Parameters.AddWithValue("@id_compra", idCompra);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        //METODO LOCALIZAR fgeral
        public DataTable LocalizarGeral()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = default(SqlDataAdapter);
            da = new SqlDataAdapter("select c.id_compra, c.dataCompra, c.nfiscal, c.nparcelas, c.total," +
                " c.compraStatus, c.id_fornecedor, c.id_tipoPagamento," +
                " f.nome from Compra as C inner join Fornecedor as f on c.id_fornecedor = f.id_fornecedor ", conexao.StringConexao);
              //  " where f.id_fornecedor = " + codigo.ToString(), conexao.StringConexao);
            da.Fill(dt);
            return dt;
        }

        //METODO LOCALIZAR POR NOME DE FORCECEDOR
        public DataTable LocalizarNome(String nome)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = default(SqlDataAdapter);
            da = new SqlDataAdapter("select c.id_compra, c.dataCompra, c.nfiscal, c.nparcelas, c.total," +
                "  c.compraStatus, c.id_fornecedor, c.id_tipoPagamento," +
                " f.nome from Compra as C inner join Fornecedor as f on c.id_fornecedor = f.id_fornecedor where f.nome like '%" + nome + "%' order by f.nome", conexao.StringConexao);
            da.Fill(dt);
            return dt;
        }

        //METODO LOCALIZAR por data
        public DataTable LocalizarData(DateTime inicial, DateTime final)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select c.id_compra, c.dataCompra, c.nfiscal, c.nparcelas, c.total," +
                "  c.compraStatus, c.id_fornecedor, c.id_tipoPagamento," +
                " f.nome from Compra as C inner join Fornecedor as f on c.id_fornecedor = f.id_fornecedor " +
                " where c.dataCompra BETWEEN @inicial and @final order by c.dataCompra";

            cmd.Parameters.Add("@inicial", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@inicial"].Value = inicial;

            cmd.Parameters.Add("@final", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@final"].Value = final;

            //conexao.Conectar();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            //conexao.Desconectar();
            return dt;
        }
    }
}
