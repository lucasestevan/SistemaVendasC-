using DAL;
using Modelo;

namespace BLL
{
    public class BLL_Login
    {
        public bool Existe;

        private DAL_Conexao conexao;

        public BLL_Login(DAL_Conexao con)
        {
            this.conexao = con;
        }

        //METODO LOCALIZAR
        public bool Login(string usuario, string senha)
        {
            DAL_Login DALobj = new DAL_Login(conexao);
            Existe = DALobj.Login(usuario, senha);
            return Existe;
        }
    }
}
