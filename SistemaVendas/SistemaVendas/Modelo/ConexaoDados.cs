using System.Data.SqlClient;

namespace SistemaVendas.Modelo
{
    public class ConexaoDados
    {
        //CRIAR CONEXAO COM BD SERVER
        public static SqlConnection con = new SqlConnection("Data Source = DESKTOP-628SFJB;Initial Catalog = SistemaVenda; Integrated Security = True");

        //METODO ABRIR CONEXAO
        public static void abrir()
        {
            if ((int)con.State == 0)
            {
                con.Open();
            }
        }

        //METODO FECHAR CONEXAO
        public static void fechar()
        {
            if ((int)con.State == 1)
            {
                con.Close();
            }
        }
    }
}
