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
            cmd.Parameters.AddWithValue("@cep", modelo.Cep);
            cmd.Parameters.AddWithValue("@rua", modelo.Rua);
            cmd.Parameters.AddWithValue("@bairro", modelo.Bairro);
            cmd.Parameters.AddWithValue("@cidade", modelo.Cidade);
            cmd.Parameters.AddWithValue("@uf", modelo.Uf);
            conexao.Conectar();
            modelo.IdEndereco = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        //METODO ALTERAR
        public void Alterar(Model_Endereco modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE Endereco set cep = @cep, rua = @rua, bairro = @bairro, cidade = @cidade, uf = @uf where id_endereco = @id_endereco";
            cmd.Parameters.AddWithValue("@id_endereco", modelo.IdEndereco);
            cmd.Parameters.AddWithValue("@cep", modelo.Cep);
            cmd.Parameters.AddWithValue("@rua", modelo.Rua);
            cmd.Parameters.AddWithValue("@bairro", modelo.Bairro);
            cmd.Parameters.AddWithValue("@cidade", modelo.Cidade);
            cmd.Parameters.AddWithValue("@uf", modelo.Uf);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        //METODO CARREGA MODELO
        public Model_Endereco CarregaModeloEndereco(int idEndereco)
        {
            Model_Endereco modelo = new Model_Endereco();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from Endereco where id_endereco = @id_endereco";
            cmd.Parameters.AddWithValue("@id_endereco", idEndereco);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            //SE EXITIR ALGUMA LINHA EXECUTAR
            if (registro.HasRows)
            {
                registro.Read();
                modelo.IdEndereco = Convert.ToInt32(registro["id_endereco"]);
                modelo.Cep = Convert.ToString(registro["cep"]);
                modelo.Rua = Convert.ToString(registro["rua"]);
                modelo.Bairro = Convert.ToString(registro["bairro"]);
                modelo.Cidade = Convert.ToString(registro["cidade"]);
                modelo.Uf = Convert.ToString(registro["uf"]);
            }
            conexao.Desconectar();
            return modelo;
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
