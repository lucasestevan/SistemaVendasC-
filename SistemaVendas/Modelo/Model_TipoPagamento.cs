using System;

namespace Modelo
{
    public class Model_TipoPagamento
    {
        public Model_TipoPagamento()
        {
            this.idTipoPagamento = 0;
            this.nome = "";
        }

        public Model_TipoPagamento(int idTipoPagamento, String nome)
        {
            this.idTipoPagamento = idTipoPagamento;
            this.nome = nome;
        }

        private int _idTipoPagamento;

        public int idTipoPagamento
        {
            get
            {
                return this._idTipoPagamento;
            }
            set
            {
                this._idTipoPagamento = value;
            }
        }

        private string _nome;

        public string nome
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
    }
}
