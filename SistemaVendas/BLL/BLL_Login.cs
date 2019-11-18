using DAL;
using Modelo;

namespace BLL
{
    public class BLL_Login
    {
        public bool Existe;

        private DAO_Conexao conexao;

        public BLL_Login(DAO_Conexao con)
        {
            this.conexao = con;
        }

        //METODO LOCALIZAR
        public bool Login(string usuario, string senha)
        {
            DAO_Login DALobj = new DAO_Login(conexao);
            Existe = DALobj.Login(usuario, senha);
            return Existe;
        }
    }
}
