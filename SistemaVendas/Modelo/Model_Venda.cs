using System;

namespace Modelo
{
    public class Model_Venda
    {
        public Model_Venda()
        {
            this.idVenda = 0;
            this.dataVenda = DateTime.Now;
            this.nFiscal = 0;
            this.total = 0;
            this.nParcelas = 0;
            this.vendaStatus = "ABERTO";
            this.idCliente = 0;
            this.idTipoPagamento = 0;
            this.avista = 0;
        }

        public Model_Venda(int idVenda, DateTime dataVenda, int nFiscal, double total, int nParcelas, String vendaStatus, int idCliente, int idTipoPagament, int avista)
        {
            this.idVenda = idVenda;
            this.dataVenda = dataVenda;
            this.nFiscal = nFiscal;
            this.total = total;
            this.nParcelas = nParcelas;
            this.vendaStatus = vendaStatus;
            this.idCliente = idCliente;
            this.idTipoPagamento = idTipoPagamento;
            this.avista = avista;
        }

        private int _idVenda;

        public int idVenda
        {
            get
            {
                return this._idVenda;
            }
            set
            {
                this._idVenda = value;
            }
        }

        private DateTime _dataVenda;

        public DateTime dataVenda
        {
            get
            {
                return this._dataVenda;
            }
            set
            {
                this._dataVenda = value;
            }
        }

        private int _nFiscal;

        public int nFiscal
        {
            get
            {
                return this._nFiscal;
            }
            set
            {
                this._nFiscal = value;
            }
        }

        private Double _total;

        public Double total
        {
            get
            {
                return this._total;
            }
            set
            {
                this._total = value;
            }
        }

        private int _nParcelas;

        public int nParcelas
        {
            get
            {
                return this._nParcelas;
            }
            set
            {
                this._nParcelas = value;
            }
        }

        private string _vendaStatus;

        public string vendaStatus
        {
            get
            {
                return this._vendaStatus;
            }
            set
            {
                this._vendaStatus = value;
            }
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

        private int _avista;

        public int avista
        {
            get
            {
                return this._avista;
            }
            set
            {
                this._avista = value;
            }
        }
    }
}
