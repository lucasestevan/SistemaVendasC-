using System;


namespace Modelo
{
    public class Model_Colaborador
    {
        private int idColaborador;
        private string nome;
        private string cpf;
        private string senha;
        private string telefone;
        private string celular;
        private string descricao;

        public int IdColaborador { get => idColaborador; set => idColaborador = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Descricao { get => descricao; set => descricao = value; }
    }
}
