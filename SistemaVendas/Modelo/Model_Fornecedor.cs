using System;

namespace Modelo
{
    public class Model_Fornecedor
    {
        private int idFornecedor;
        private string nome;
        private string cpfCNPJ;
        private string telefone;
        private string celular;
        private string observacao;
        private string email;
        private string cep;
        private string numeroEnde;

        public int IdFornecedor { get => idFornecedor; set => idFornecedor = value; }
        public string Nome { get => nome; set => nome = value; }
        public string CpfCNPJ { get => cpfCNPJ; set => cpfCNPJ = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Observacao { get => observacao; set => observacao = value; }
        public string Email { get => email; set => email = value; }
        public string Cep { get => cep; set => cep = value; }
        public string NumeroEnde { get => numeroEnde; set => numeroEnde = value; }
    }
}
