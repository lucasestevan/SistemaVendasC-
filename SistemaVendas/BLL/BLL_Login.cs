using DAL;
using System;
using System.Data;

namespace BLL
{
    public class BLL_Login
    {
        private DAL_Conexao conexao;

        public BLL_Login(DAL_Conexao con)
        {
            this.conexao = con;
        }

        //METODO LOCALIZAR
        public DataTable Login(String valor, string senha)
        {
            DAL_Login DALobj = new DAL_Login(conexao);
            return DALobj.Login(valor, senha);
        }
    }
}
