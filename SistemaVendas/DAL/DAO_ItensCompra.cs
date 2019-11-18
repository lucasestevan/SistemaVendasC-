using Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAO_ItensCompra
    {
        private DAO_Conexao conexao;
        public DAO_ItensCompra(DAO_Conexao con)
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
            cmd.Parameters.AddWithValue("@id_itensCompra", modelo.IdItensCompra);
            cmd.Parameters.AddWithValue("@quantidade", modelo.Quantidade);
            cmd.Parameters.AddWithValue("@valor", modelo.Valor);
            cmd.Parameters.AddWithValue("@id_compra", modelo.IdCompraItensCompra);
            cmd.Parameters.AddWithValue("@id_produto", modelo.IdProdutoItensCompra);
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
                "valor = @valor where id_itensCompra = @id_itensCompra and id_compra = @id_compra and id_produto = @id_produto";
            cmd.Parameters.AddWithValue("@id_itensCompra", modelo.IdItensCompra);
            cmd.Parameters.AddWithValue("@quantidade", modelo.Quantidade);
            cmd.Parameters.AddWithValue("@valor", modelo.Valor);
            cmd.Parameters.AddWithValue("@id_compra", modelo.IdCompraItensCompra);
            cmd.Parameters.AddWithValue("@id_produto", modelo.IdProdutoItensCompra);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        //METODO CARREGA MODELO
        public Model_ItensCompra CarregaModeloItensCompra(int idItensCompra)
        {
            Model_ItensCompra modelo = new Model_ItensCompra();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from ItensCompra where id_itensCompra = @id_itensCompra";
            cmd.Parameters.AddWithValue("@id_itensCompra", idItensCompra);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            //SE EXITIR ALGUMA LINHA EXECUTAR
            if (registro.HasRows)
            {
                registro.Read();
                modelo.IdItensCompra = Convert.ToInt32(registro["id_itensCompra"]);
                modelo.Quantidade = Convert.ToDouble(registro["quantidade"]);
                modelo.Valor = Convert.ToDouble(registro["valor"]);
                modelo.IdCompraItensCompra = Convert.ToInt32(registro["id_compra"]);
                modelo.IdProdutoItensCompra = Convert.ToInt32(registro["id_produto"]);
            }
            conexao.Desconectar();
            return modelo;
        }


        //METODO EXCLUIR
        public void Excluir(Model_ItensCompra modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from ItensCompra where id_itensCompra = @id_itensCompra and id_compra = @id_compra and id_produto = @id_produto";
            cmd.Parameters.AddWithValue("@id_itensCompra", modelo.IdItensCompra);
            cmd.Parameters.AddWithValue("@id_compra", modelo.IdCompraItensCompra);
            cmd.Parameters.AddWithValue("@id_produto", modelo.IdProdutoItensCompra);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        //METODO EXCLUIR todos 
        public void ExcluirTodosItens(int idCompra)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from ItensCompra where id_compra = @id_compra";
            cmd.Parameters.AddWithValue("@id_compra", idCompra);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }


        //METODO LOCALIZAR
        public DataTable Localizar(int idCompra)
        {
            DataTable dt = new DataTable(); 
            SqlDataAdapter da = default(SqlDataAdapter);
            da = new SqlDataAdapter("Select i.id_itensCompra, p.nome , i.quantidade, i.valor, i.id_compra, " +
                "i.id_produto from ItensCompra as i INNER JOIN Produto as p on p.id_produto = i.id_produto where i.id_compra = " + idCompra.ToString(), conexao.StringConexao);
            da.Fill(dt);
            return dt;
        }
    }
}
