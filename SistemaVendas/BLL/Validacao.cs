using System.Text.RegularExpressions;

namespace SistemaVendas
{
    public class Validacao
    {
        public static bool ValidaEmail(string email)
        {
            string strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}" +
                "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\" +
                ".)+))([a-zA-Z]{2,4}|[0,9]{1,3})(\\]?)$";
            Regex re = new Regex(strRegex); 
            return re.IsMatch(email);
        }

        public static bool ValidaCep(string cep)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(cep, ("[0-9]{5}-[0-9]{3}"));
        }
    }
}
