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
                modelo.idEndereco = Convert.ToInt32(registro["id_endereco"]);
                modelo.cep = Convert.ToString(registro["cep"]);
                modelo.rua = Convert.ToString(registro["rua"]);
                modelo.bairro = Convert.ToString(registro["bairro"]);
                modelo.cidade = Convert.ToString(registro["cidade"]);
                modelo.uf = Convert.ToString(registro["uf"]);
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
