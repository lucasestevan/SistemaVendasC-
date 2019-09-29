using Modelo;
using System;
using System.Data;
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

        //METODO Login
        public DataTable Login(String nome, string senha)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = default(SqlDataAdapter);
            da = new SqlDataAdapter("SELECT * FROM Colaborador where nome like '%" + nome + "%' and senha like '%" + senha + "%'", conexao.StringConexao);
            da.Fill(dt);
            return dt;
        }
    }
}
