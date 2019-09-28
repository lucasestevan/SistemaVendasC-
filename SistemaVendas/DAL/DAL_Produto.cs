using Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_Produto
    {
        private DAL_Conexao conexao;
        public DAL_Produto(DAL_Conexao con)
        {
            this.conexao = con;
        }

        //METODO INCLUIR
        public void Incluir(Model_Produto modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into Produto (nome, preco, quantidade, descricao, id_categoria, id_fornecedor)" +
                " values (@nome, @preco, @quantidade, @descricao, @id_categoria, @id_fornecedor); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", modelo.nome);
            cmd.Parameters.AddWithValue("@preco", modelo.preco);
            cmd.Parameters.AddWithValue("@quantidade", modelo.quantidade);
            cmd.Parameters.AddWithValue("@descricao", modelo.descricao);
            cmd.Parameters.AddWithValue("@id_categoria", modelo.idCategoria);
            cmd.Parameters.AddWithValue("@id_fornecedor", modelo.idFornecedor);
            conexao.Conectar();
            modelo.idProduto = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        //METODO ALTERAR
        public void Alterar(Model_Produto modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE Produto set nome = @nome, preco = @preco, quantidade = @quantidade, descricao = @descricao, id_categoria = @id_categoria, id_fornecedor = @id_fornecedor" +
                   "WHERE id_produto = @id_produto";
            cmd.Parameters.AddWithValue("@id_produto", modelo.idProduto);
            cmd.Parameters.AddWithValue("@nome", modelo.nome);
            cmd.Parameters.AddWithValue("@preco", modelo.preco);
            cmd.Parameters.AddWithValue("@quantidade", modelo.quantidade);
            cmd.Parameters.AddWithValue("@descricao", modelo.descricao);
            cmd.Parameters.AddWithValue("@id_categoria", modelo.idCategoria);
            cmd.Parameters.AddWithValue("@id_fornecedor", modelo.idFornecedor);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        //METODO EXCLUIR
        public void Excluir(int idProduto)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from Produto where id_produto = @id_produto";
            cmd.Parameters.AddWithValue("@id_produto", idProduto);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        //METODO LOCALIZAR
        public DataTable Localizar(String valor)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = default(SqlDataAdapter);
            da = new SqlDataAdapter("SELECT * FROM Produto where nome like '%" + valor + "%' order by nome", conexao.StringConexao);
            da.Fill(dt);
            return dt;
        }
    }
}
