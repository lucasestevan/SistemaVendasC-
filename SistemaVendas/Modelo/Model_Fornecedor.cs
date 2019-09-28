using System;

namespace Modelo
{
    public class Model_Fornecedor
    {
        public Model_Fornecedor()
        {
            this.idFornecedor = 0;
            this.nome = "";
            this.cpfCNPJ = "";
            this.telefone = "";
            this.email = "";

        }

        public Model_Fornecedor(int idFornecedor, String nome, String cpfCNPJ, String telefone, String email)
        {
            this.idFornecedor = idFornecedor;
            this.nome = nome;
            this.cpfCNPJ = cpfCNPJ;
            this.telefone = telefone;
            this.email = email;
        }

        private int _idFornecedor;

        public int idFornecedor
        {
            get
            {
                return this._idFornecedor;
            }
            set
            {
                this._idFornecedor = value;
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

        private String _cpfCNPJ;

        public String cpfCNPJ
        {
            get
            {
                return this._cpfCNPJ;
            }
            set
            {
                this._cpfCNPJ = value;
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
    }
}
