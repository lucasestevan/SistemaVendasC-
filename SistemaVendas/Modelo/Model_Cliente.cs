using System;

namespace Modelo
{
    public class Model_Cliente
    {

        private int idCliente;
        private string nome;
        private string cpf;
        private string telefone;
        private string celular;
        private string email;
        private string observacao;
        private int idEndereco;
        private string numeroEnde;

        public int IdCliente { get => this.idCliente; set => this.idCliente = value; }
        public string Nome { get => this.nome; set => this.nome = value; }
        public string Cpf { get => this.cpf; set => this.cpf = value; }
        public string Telefone { get => this.telefone; set => this.telefone = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Email { get => this.email; set => this.email = value; }
        public string Observacao { get => this.observacao; set => this.observacao = value; }
        public int IdEndereco { get => this.idEndereco; set => this.idEndereco = value; }
        public string NumeroEnde { get => this.numeroEnde; set => this.numeroEnde = value; }
    }
}
