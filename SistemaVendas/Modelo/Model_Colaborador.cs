using System;


namespace Modelo
{
    public class Model_Colaborador
    {
        public Model_Colaborador()
        {
            this.idColaborador = 0;
            this.nome = "";
            this.cpf = "";
            this.senha = "";
            this.telefone = "";
            this.celular = "";
            this.descricao = "";
        }

        public Model_Colaborador(int idColaborador, String nome, String cpf, String senha, String telefone, String celular, String descricao)
        {
            this.idColaborador = idColaborador;
            this.nome = nome;
            this.cpf = cpf;
            this.senha = senha;
            this.telefone = telefone;
            this.celular = celular;
            this.descricao = descricao;
        }

        private int _idColaborador;

        public int idColaborador
        {
            get
            {
                return this._idColaborador;
            }
            set
            {
                this._idColaborador = value;
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

        private String _descricao;

        public String descricao
        {
            get
            {
                return this._descricao;
            }
            set
            {
                this._descricao = value;
            }
        }
    }
}
