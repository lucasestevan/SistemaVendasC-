using System;

namespace DAL
{
    public class DadoConexao
    {
        public static String StringDeConexao
        {
            get
            {
                //return "Data Source = DESKTOP-628SFJB;Initial Catalog = SistemaVenda; Integrated Security = True";
                return @"Data Source = DESKTOP-H923SLO\SQLEXPRESS;Initial Catalog = SistemaVenda; Integrated Security = True";

            }
        }
    }
}
