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
            cmd.Parameters.AddWithValue("@nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@preco", modelo.Preco);
            cmd.Parameters.AddWithValue("@quantidade", modelo.Quantidade);
            cmd.Parameters.AddWithValue("@descricao", modelo.Descricao);
            cmd.Parameters.AddWithValue("@id_categoria", modelo.IdCategoria);
            cmd.Parameters.AddWithValue("@id_fornecedor", modelo.IdFornecedor);
            conexao.Conectar();
            modelo.IdProduto = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        //METODO ALTERAR
        public void Alterar(Model_Produto modelo, Boolean teste)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE Produto set nome = @nome, preco = @preco, quantidade = @quantidade, descricao = @descricao, id_categoria = @id_categoria, id_fornecedor = @id_fornecedor WHERE id_produto = @id_produto";
            cmd.Parameters.AddWithValue("@id_produto", modelo.IdProduto);
            cmd.Parameters.AddWithValue("@nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@preco", modelo.Preco);
            cmd.Parameters.AddWithValue("@quantidade", modelo.Quantidade);
            cmd.Parameters.AddWithValue("@descricao", modelo.Descricao);
            cmd.Parameters.AddWithValue("@id_categoria", modelo.IdCategoria);
            cmd.Parameters.AddWithValue("@id_fornecedor", modelo.IdFornecedor);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        //METODO CARREGA MODELO
        public Model_Produto CarregaModeloProduto(int idProduto)
        {
            Model_Produto modelo = new Model_Produto();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from Produto where id_produto = @id_produto";
            cmd.Parameters.AddWithValue("@id_produto", idProduto);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            //SE EXITIR ALGUMA LINHA EXECUTAR
            if (registro.HasRows)
            {
                registro.Read();
                modelo.IdProduto = Convert.ToInt32(registro["id_produto"]);
                modelo.Nome = Convert.ToString(registro["nome"]);
                modelo.Preco = Convert.ToDouble(registro["preco"]);
                modelo.Quantidade = Convert.ToDouble(registro["quantidade"]);
                modelo.Descricao = Convert.ToString(registro["descricao"]);
                modelo.IdCategoria = Convert.ToInt32(registro["id_categoria"]);
                modelo.IdFornecedor = Convert.ToInt32(registro["id_fornecedor"]);
            }
            conexao.Desconectar();
            return modelo;
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
            da = new SqlDataAdapter("Select pro.id_produto, pro.nome, pro.preco, pro.quantidade, pro.descricao," +
            "cat.nome as categoria, forn.nome as fornecedor from Produto as pro INNER JOIN Categoria as cat on pro.id_categoria = cat.id_categoria INNER JOIN Fornecedor as forn on pro.id_fornecedor = forn.id_fornecedor where pro.nome like '%" + valor + "%' order by nome", conexao.StringConexao);
            da.Fill(dt);
            return dt;
        }
    }
}
