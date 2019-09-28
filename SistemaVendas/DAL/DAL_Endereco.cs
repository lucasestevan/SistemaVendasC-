using Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_Endereco
    {
        private DAL_Conexao conexao;
        public DAL_Endereco(DAL_Conexao con)
        {
            this.conexao = con;
        }

        //METODO INCLUIR
        public void Incluir(Model_Endereco modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into Endereco (cep, rua, bairro, cidade, uf)" +
                "values (@cep, @rua, @bairro, @cidade, @uf); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@cep", modelo.cep);
            cmd.Parameters.AddWithValue("@rua", modelo.rua);
            cmd.Parameters.AddWithValue("@bairro", modelo.bairro);
            cmd.Parameters.AddWithValue("@cidade", modelo.cidade);
            cmd.Parameters.AddWithValue("@uf", modelo.uf);
            conexao.Conectar();
            modelo.idEndereco = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        //METODO ALTERAR
        public void Alterar(Model_Endereco modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE Endereco set cep = @cep, rua = @rua, bairro = @bairro, cidade = @cidade, uf = @uf where id_endereco = @id_endereco";
            cmd.Parameters.AddWithValue("@id_endereco", modelo.idEndereco);
            cmd.Parameters.AddWithValue("@cep", modelo.cep);
            cmd.Parameters.AddWithValue("@rua", modelo.rua);
            cmd.Parameters.AddWithValue("@bairro", modelo.bairro);
            cmd.Parameters.AddWithValue("@cidade", modelo.cidade);
            cmd.Parameters.AddWithValue("@uf", modelo.uf);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        //METODO EXCLUIR
        public void Excluir(int idEndereco)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from Endereco where id_endereco = @id_endereco";
            cmd.Parameters.AddWithValue("@id_endereco", idEndereco);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        //METODO LOCALIZAR
        public DataTable Localizar(String valor)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = default(SqlDataAdapter);
            da = new SqlDataAdapter("SELECT * FROM Endereco where rua like '%" + valor + "%' order by rua", conexao.StringConexao);
            da.Fill(dt);
            return dt;
        }
    }
}
