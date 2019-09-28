using System;

namespace Modelo
{
    public class Model_Cliente
    {
        public Model_Cliente()
        {
            this.idCliente = 0;
            this.nome = "";
            this.cpf = "";
            this.telefone = "";
            this.celular = "";
            this.email = "";
            this.observacao = "";
            this.idEndereco = 0;
            this.numeroEnde = "";
        }

        public Model_Cliente(int idCliente, String nome, String cpf, String telefone, String celular, String email, String observacao, int idEndereco, String numeroEnde)
        {
            this.idCliente = idCliente;
            this.nome = nome;
            this.cpf = cpf;
            this.telefone = telefone;
            this.celular = celular;
            this.email = email;
            this.observacao = observacao;
            this.idEndereco = idEndereco;
            this.numeroEnde = numeroEnde;
        }

        private int _idCliente;

        public int idCliente
        {
            get
            {
                return this._idCliente;
            }
            set
            {
                this._idCliente = value;
            }
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

        private String _cpf;

        public String cpf
        {
            get
            {
                return this._cpf;
            }
            set
            {
                this._cpf = value;
            }
        }

        private String _telefone;

        public String telefone
        {
            get
            {
                return this._telefone;
            }
            set
            {
                this._telefone = value;
            }
        }

        private String _celular;

        public String celular
        {
            get
            {
                return this._celular;
            }
            set
            {
                this._celular = value;
            }
        }

        private String _email;

        public String email
        {
            get
            {
                return this._email;
            }
            set
            {
                this._email = value;
            }
        }

        private String _observacao;

        public String observacao
        {
            get
            {
                return this._observacao;
            }
            set
            {
                this._observacao = value;
            }
        }

        private int _idEndereco;

        public int idEndereco
        {
            get
            {
                return this._idEndereco;
            }
            set
            {
                this._idEndereco = value;
            }
        }

        private String _numeroEnde;

        public String numeroEnde
        {
            get
            {
                return this._numeroEnde;
            }
            set
            {
                this._numeroEnde = value;
            }
        }
    }
}
