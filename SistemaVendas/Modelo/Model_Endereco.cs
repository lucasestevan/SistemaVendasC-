using System;

namespace Modelo
{
    public class Model_Endereco
    {
        private string cep;
        private string rua;
        private string bairro;
        private string cidade;
        private string uf;

        public string Cep { get => cep; set => cep = value; }
        public string Rua { get => rua; set => rua = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Uf { get => uf; set => uf = value; }
    }
}

