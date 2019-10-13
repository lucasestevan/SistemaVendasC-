using System;

namespace Modelo
{
    public class Model_Fornecedor
    {
        private int idFornecedor;
        private string nome;
        private string cpfCNPJ;
        private string telefone;
        private string email;

        public int IdFornecedor { get => idFornecedor; set => idFornecedor = value; }
        public string Nome { get => nome; set => nome = value; }
        public string CpfCNPJ { get => cpfCNPJ; set => cpfCNPJ = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
    }
}
