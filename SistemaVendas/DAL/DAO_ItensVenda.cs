using Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAO_ItensVenda
    {

        private DAO_Conexao conexao;
        public DAO_ItensVenda(DAO_Conexao con)
        {
            this.conexao = con;
        }

        //METODO INCLUIR
        public void Incluir(Model_ItensVenda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into ItensVenda (id_itensVenda, quantidade, valor, id_venda, id_produto)" +
                "values (@id_itensVenda, @quantidade, @valor, @id_venda, @id_produto)";
            cmd.Parameters.AddWithValue("@id_itensVenda", modelo.IdItensVenda);
            cmd.Parameters.AddWithValue("@quantidade", modelo.Quantidade);
            cmd.Parameters.AddWithValue("@valor", modelo.Valor);
            cmd.Parameters.AddWithValue("@id_venda", modelo.IdVendaItensVendas);
            cmd.Parameters.AddWithValue("@id_produto", modelo.IdProdutoItensVenda);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        //METODO ALTERAR
        public void Alterar(Model_ItensVenda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE ItensVenda set quantidade = @quantidade, " +
                "valor = @valor where id_itensVenda = @id_itensVenda and id_venda = @id_venda and id_produto = @id_produto";
            cmd.Parameters.AddWithValue("@id_itensVenda", modelo.IdItensVenda);
            cmd.Parameters.AddWithValue("@quantidade", modelo.Quantidade);
            cmd.Parameters.AddWithValue("@valor", modelo.Valor);
            cmd.Parameters.AddWithValue("@id_venda", modelo.IdVendaItensVendas);
            cmd.Parameters.AddWithValue("@id_produto", modelo.IdProdutoItensVenda);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        //METODO CARREGA MODELO
        public Model_ItensVenda CarregaModeloItensVenda(int idItensVenda, int idVenda, int idProduto)
        {
            Model_ItensVenda modelo = new Model_ItensVenda();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from ItensVenda where id_itensVenda = @id_itensVenda and id_Venda = @id_Venda and id_produto = @id_produto";
            cmd.Parameters.AddWithValue("@id_itensVenda", idItensVenda);
            cmd.Parameters.AddWithValue("@id_Venda", idVenda);
            cmd.Parameters.AddWithValue("@id_produto", idProduto);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            //SE EXITIR ALGUMA LINHA EXECUTAR
            if (registro.HasRows)
            {
                registro.Read();
                modelo.IdItensVenda = idItensVenda;
                modelo.Quantidade = Convert.ToDouble(registro["quantidade"]);
                modelo.Valor = Convert.ToDouble(registro["valor"]);
                modelo.IdVendaItensVendas = idVenda;
                modelo.IdProdutoItensVenda = idProduto;
            }
            conexao.Desconectar();
            return modelo;
        }


        //METODO EXCLUIR
        public void Excluir(Model_ItensVenda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from ItensVenda where id_itensVenda = @id_itensVenda and id_venda = @id_venda and id_produto = @id_produto";
            cmd.Parameters.AddWithValue("@id_itensCompra", modelo.IdItensVenda);
            cmd.Parameters.AddWithValue("@id_venda", modelo.IdVendaItensVendas);
            cmd.Parameters.AddWithValue("@id_produto", modelo.IdProdutoItensVenda);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        //METODO EXCLUIR todos 
        public void ExcluirTodosItens(int idVenda)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from ItensVenda where id_venda = @id_venda";
            cmd.Parameters.AddWithValue("@id_venda", idVenda);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }


        //METODO LOCALIZAR
        public DataTable Localizar(int idVenda)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = default(SqlDataAdapter);
            da = new SqlDataAdapter("Select i.id_itensVenda, p.nome , i.quantidade, i.valor, i.id_venda, " +
                "i.id_produto from ItensVenda as i INNER JOIN Produto as p on p.id_produto = i.id_produto where i.id_venda = " + idVenda.ToString(), conexao.StringConexao);
            da.Fill(dt);
            return dt;
        }
    }
}
