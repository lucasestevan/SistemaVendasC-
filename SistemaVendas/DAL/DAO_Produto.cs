using Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAO_Produto
    {
        private DAO_Conexao conexao;
        public DAO_Produto(DAO_Conexao con)
        {
            this.conexao = con;
        }

        //METODO INCLUIR
        public void Incluir(Model_Produto modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into Produto (nome, preco, quantidade, descricao, id_categoria, id_fornecedor, codigo_pro)" +
                " values (@nome, @preco, @quantidade, @descricao, @id_categoria, @id_fornecedor, @codigo_pro); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@preco", modelo.Preco);
            cmd.Parameters.AddWithValue("@quantidade", modelo.Quantidade);
            cmd.Parameters.AddWithValue("@descricao", modelo.Descricao);
            cmd.Parameters.AddWithValue("@id_categoria", modelo.IdCategoria);
            cmd.Parameters.AddWithValue("@id_fornecedor", modelo.IdFornecedor);
            cmd.Parameters.AddWithValue("@codigo_pro", modelo.Codigo_pro);
            conexao.Conectar();
            modelo.IdProduto = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        //METODO ALTERAR
        public void Alterar(Model_Produto modelo, Boolean teste)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE Produto set nome = @nome, preco = @preco, quantidade = @quantidade, descricao = @descricao, " +
                "id_categoria = @id_categoria, id_fornecedor = @id_fornecedor, codigo_pro = @codigo_pro WHERE id_produto = @id_produto";
            cmd.Parameters.AddWithValue("@id_produto", modelo.IdProduto);
            cmd.Parameters.AddWithValue("@nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@preco", modelo.Preco);
            cmd.Parameters.AddWithValue("@quantidade", modelo.Quantidade);
            cmd.Parameters.AddWithValue("@descricao", modelo.Descricao);
            cmd.Parameters.AddWithValue("@id_categoria", modelo.IdCategoria);
            cmd.Parameters.AddWithValue("@id_fornecedor", modelo.IdFornecedor);
            cmd.Parameters.AddWithValue("@codigo_pro", modelo.Codigo_pro);
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
                modelo.Codigo_pro = Convert.ToString(registro["codigo_pro"]);

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
            da = new SqlDataAdapter("Select pro.id_produto, pro.codigo_pro, pro.nome, pro.preco, pro.quantidade, pro.descricao, cat.nome," +
                " forn.nome from Produto as pro INNER JOIN Categoria as cat on pro.id_categoria = cat.id_categoria " +
                "INNER JOIN Fornecedor as forn on pro.id_fornecedor = forn.id_fornecedor where pro.nome like '%" + valor + "%' order by pro.nome", conexao.StringConexao);
            da.Fill(dt);
            return dt;
        }

        //METODO LOCALIZAR por codigo
        public DataTable LocalizarPorCod(String cod)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = default(SqlDataAdapter);
            da = new SqlDataAdapter("Select pro.codigo_pro, pro.nome, pro.preco, pro.quantidade, pro.descricao, cat.nome," +
               " forn.nome from Produto as pro INNER JOIN Categoria as cat on pro.id_categoria = cat.id_categoria " +
               "INNER JOIN Fornecedor as forn on pro.id_fornecedor = forn.id_fornecedor where pro.nome like '%" + cod + "%' order by pro.codigo_pro", conexao.StringConexao);
            da.Fill(dt);
            return dt;
        }

        //METODO LOCALIZAR estoque baixo
        public DataTable LocalizarEstoqueBaixo()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = default(SqlDataAdapter);
            da = new SqlDataAdapter("select nome, quantidade from Produto where quantidade <= 10 order by nome", conexao.StringConexao);
            da.Fill(dt);
            return dt;
        }


        //METODO CARREGA MODELO
        public Model_Produto CarregaModeloProdutoCodigo(string codigo)
        {
            Model_Produto modelo = new Model_Produto();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select id_produto, codigo_pro, nome, preco from Produto where codigo_pro = @codigo_pro";
            cmd.Parameters.AddWithValue("@codigo_pro", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            //SE EXITIR ALGUMA LINHA EXECUTAR
            if (registro.HasRows)
            {
                registro.Read();
                modelo.IdProduto = Convert.ToInt32(registro["id_produto"]);
                modelo.Nome = Convert.ToString(registro["nome"]);
                modelo.Preco = Convert.ToDouble(registro["preco"]);
                modelo.Codigo_pro = Convert.ToString(registro["codigo_pro"]);

            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
