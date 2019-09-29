using System;

namespace Modelo
{
    public class Model_Login
    {
        public Model_Login()
        {
            this.nome = "";
            this.senha = "";
        }

        public Model_Login(String nome, String senha)
        {
            this.nome = nome;
            this.senha = senha;
        }

        private String _nome;

        public String nome
        {
            get
            {
                return this._nome;
            }
            set
            {
                this._nome = value;
            }
        }

        private String _senha;

        public String senha
        {
            get
            {
                return this._senha;
            }
            set
            {
                this._senha = value;
            }
        }
    }
}
