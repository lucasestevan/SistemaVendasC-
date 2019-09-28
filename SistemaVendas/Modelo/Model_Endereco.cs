using System;

namespace Modelo
{
    public class Model_Endereco
    {

        public Model_Endereco()
        {
            this.idEndereco = 0;
            this.cep = "";
            this.rua = "";
            this.bairro = "";
            this.cidade = "";
            this.uf = "";
        }

        public Model_Endereco(int idEndereco, String cep, String rua, String bairro, String cidade, String uf)
        {
            this.idEndereco = idEndereco;
            this.cep = cep;
            this.rua = rua;
            this.bairro = bairro;
            this.cidade = cidade;
            this.uf = uf;
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

        private String _cep;

        public String cep
        {
            get
            {
                return this._cep;
            }
            set
            {
                this._cep = value;
            }
        }

        private String _rua;

        public String rua
        {
            get
            {
                return this._rua;
            }
            set
            {
                this._rua = value;
            }
        }

        private String _bairro;

        public String bairro
        {
            get
            {
                return this._bairro;
            }
            set
            {
                this._bairro = value;
            }
        }

        private String _cidade;

        public String cidade
        {
            get
            {
                return this._cidade;
            }
            set
            {
                this._cidade = value;
            }
        }
        private String _uf;

        public String uf
        {
            get
            {
                return this._uf;
            }
            set
            {
                this._uf = value;
            }
        }
    }
}

