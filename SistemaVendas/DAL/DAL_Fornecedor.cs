using Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_Fornecedor
    {
        private DAL_Conexao conexao;
        public DAL_Fornecedor(DAL_Conexao con)
        {
            this.conexao = con;
        }

        //METODO INCLUIR
        public void Incluir(Model_Fornecedor modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into Fornecedor (nome, cpfCNPJ, telefone, email)"+
                "values (@nome, @cpfCNPJ, @telefone, @email); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", modelo.nome);
            cmd.Parameters.AddWithValue("@cpfCNPJ", modelo.cpfCNPJ);
            cmd.Parameters.AddWithValue("@telefone", modelo.telefone);
            cmd.Parameters.AddWithValue("@email", modelo.email);
            conexao.Conectar();
            modelo.idFornecedor = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        //METODO ALTERAR
        public void Alterar(Model_Fornecedor modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE Fornecedor set nome = @nome, cpfCNPJ = @cpfCNPJ, telefone = @telefone, email = @email where id_fornecedor = @id_fornecedor";
            cmd.Parameters.AddWithValue("@id_fornecedor", modelo.idFornecedor);
            cmd.Parameters.AddWithValue("@nome", modelo.nome);
            cmd.Parameters.AddWithValue("@cpfCNPJ", modelo.cpfCNPJ);
            cmd.Parameters.AddWithValue("@telefone", modelo.telefone);
            cmd.Parameters.AddWithValue("@email", modelo.email);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        //METODO EXCLUIR
        public void Excluir(int idFornecedor)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from Fornecedor where id_fornecedor = @id_fornecedor";
            cmd.Parameters.AddWithValue("@id_fornecedor", idFornecedor);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        //METODO LOCALIZAR
        public DataTable Localizar(String valor)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = default(SqlDataAdapter);
            da = new SqlDataAdapter("SELECT * FROM Fornecedor where nome like '%" + valor + "%' order by nome", conexao.StringConexao);
            da.Fill(dt);
            return dt;
        }
    }
}
