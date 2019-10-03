using Modelo;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_ItensCompra
    {
        private DAL_Conexao conexao;
        public DAL_ItensCompra(DAL_Conexao con)
        {
            this.conexao = con;
        }

        //METODO INCLUIR
        public void Incluir(Model_ItensCompra modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into ItensCompra (id_itensCompra, quantidade, valor, id_compra, id_produto)" +
                "values (@id_itensCompra, @quantidade, @valor, @id_compra, @id_produto)";
            cmd.Parameters.AddWithValue("@id_itensCompra", modelo.idItensCompra);
            cmd.Parameters.AddWithValue("@quantidade", modelo.Quantidade);
            cmd.Parameters.AddWithValue("@valor", modelo.Valor);
            cmd.Parameters.AddWithValue("@id_compra", modelo.idCompraItensCompra);
            cmd.Parameters.AddWithValue("@id_produto", modelo.idProdutoItensCompra);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        //METODO ALTERAR
        public void Alterar(Model_ItensCompra modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE ItensCompra set quantidade = @quantidade, " +
                "valor = @valor, where id_itensCompra = @id_itensCompra and id_compra = @id_compra and id_produto = @id_produto";
            cmd.Parameters.AddWithValue("@id_itensCompra", modelo.idItensCompra);
            cmd.Parameters.AddWithValue("@quantidade", modelo.Quantidade);
            cmd.Parameters.AddWithValue("@valor", modelo.Valor);
            cmd.Parameters.AddWithValue("@id_compra", modelo.idCompraItensCompra);
            cmd.Parameters.AddWithValue("@id_produto", modelo.idProdutoItensCompra);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        //METODO EXCLUIR
        public void Excluir(Model_ItensCompra modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from ItensCompra where id_itensCompra = @id_itensCompra and id_compra = @id_compra and id_produto = @id_produto";
            cmd.Parameters.AddWithValue("@id_itensCompra", modelo.idItensCompra);
            cmd.Parameters.AddWithValue("@id_compra", modelo.idCompraItensCompra);
            cmd.Parameters.AddWithValue("@id_produto", modelo.idProdutoItensCompra);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        //METODO LOCALIZAR
        public DataTable Localizar(int idCompra)
        {
            DataTable dt = new DataTable(); 
            SqlDataAdapter da = default(SqlDataAdapter);
            da = new SqlDataAdapter("select * from ItensCompra where id_compra = " + idCompra.ToString(), conexao.StringConexao);
            da.Fill(dt);
            return dt;
        }
    }
}
