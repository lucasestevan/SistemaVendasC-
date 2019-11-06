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
            conexao.Conectar();

            cmd.CommandText = "SELECT cep from Endereco where cep = @cep";
            cmd.Parameters.AddWithValue("@cep", modelo.Cep);
            SqlDataReader read = cmd.ExecuteReader();
            //SE EXISTIR ELE ENTRA NO IF e altera o endeco ja existente
            if (read.Read())
            {
                conexao.Desconectar();
                try
                {
                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.Connection = conexao.ObjetoConexao;
                    cmd2.CommandText = "UPDATE Endereco set cep = @cep, rua = @rua, bairro = @bairro, cidade = @cidade, uf = @uf where cep = @cep";
                    cmd2.Parameters.AddWithValue("@cep", modelo.Cep);
                    cmd2.Parameters.AddWithValue("@rua", modelo.Rua);
                    cmd2.Parameters.AddWithValue("@bairro", modelo.Bairro);
                    cmd2.Parameters.AddWithValue("@cidade", modelo.Cidade);
                    cmd2.Parameters.AddWithValue("@uf", modelo.Uf);
                    conexao.Conectar();
                    cmd2.ExecuteNonQuery();
                    conexao.Desconectar();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            //SENÃO NÃO EXISTIR ELE ADD
            else
            {
                conexao.Desconectar();
                try
                {
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.Connection = conexao.ObjetoConexao;
                    cmd1.CommandText = "insert into Endereco (cep, rua, bairro, cidade, uf)" +
                        "VALUES (@cep, @rua, @bairro, @cidade, @uf)";
                    cmd1.Parameters.AddWithValue("@cep", modelo.Cep);
                    cmd1.Parameters.AddWithValue("@rua", modelo.Rua);
                    cmd1.Parameters.AddWithValue("@bairro", modelo.Bairro);
                    cmd1.Parameters.AddWithValue("@cidade", modelo.Cidade);
                    cmd1.Parameters.AddWithValue("@uf", modelo.Uf);
                    conexao.Conectar();
                    cmd1.ExecuteNonQuery();
                    conexao.Desconectar();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            conexao.Desconectar();
        }

        //METODO CARREGA MODELO
        public Model_Endereco CarregaModeloEndereco(string cep)
        {
            Model_Endereco modelo = new Model_Endereco();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from Endereco where cep = @cep";
            cmd.Parameters.AddWithValue("@cep", cep);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            //SE EXITIR ALGUMA LINHA EXECUTAR
            if (registro.HasRows)
            {
                registro.Read();
                modelo.Cep = Convert.ToString(registro["cep"]);
                modelo.Rua = Convert.ToString(registro["rua"]);
                modelo.Bairro = Convert.ToString(registro["bairro"]);
                modelo.Cidade = Convert.ToString(registro["cidade"]);
                modelo.Uf = Convert.ToString(registro["uf"]);
            }
            conexao.Desconectar();
            return modelo;
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
