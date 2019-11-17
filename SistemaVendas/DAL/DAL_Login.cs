using System;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_Login
    {
        private DAL_Conexao conexao;
        public DAL_Login(DAL_Conexao con)
        {
            this.conexao = con;
        }

        public bool existe;
        SqlDataReader dr;

        //METODO Login
        public bool Login(string usuario, string senha)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM Colaborador where nome = @nome and senha = HASHBYTES('md2', @senha);";
            cmd.Parameters.AddWithValue("@nome", usuario);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                conexao.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    existe = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
            
            conexao.Desconectar();
            return existe;
        }
    }
}
