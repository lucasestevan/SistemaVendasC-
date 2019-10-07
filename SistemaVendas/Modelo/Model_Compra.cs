using System;

namespace Modelo
{
    public class Model_Compra
    {
        public Model_Compra()
        {
            this.idCompra = 0;
            this.dataCompra = DateTime.Now;
            this.nFiscal = 0;
            this.total = 0;
            this.nParcelas = 0; 
            this.CompraStatus = "Aberta";
            this.idFornecedor = 0;
            this.idTipoPagamento = 0;
        }

        public Model_Compra(int idCompra, DateTime dataCompra, int nFiscal, double total, int nParcelas, String CompraStatus, int idFornecedor, int idTipoPagament)
        {
            this.idCompra = idCompra;
            this.dataCompra = dataCompra;
            this.nFiscal = nFiscal;
            this.total = total;
            this.nParcelas = nParcelas;
            this.CompraStatus = CompraStatus;
            this.idFornecedor = idFornecedor;
            this.idTipoPagamento = idTipoPagamento;
        }

        private int _idCompra;

        public int idCompra
        {
            get
            {
                return this._idCompra;
            }
            set
            {
                this._idCompra = value;
            }
        }

        private DateTime _dataCompra;

        public DateTime dataCompra
        {
            get
            {
                return this._dataCompra;
            }
            set
            {
                this._dataCompra = value;
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

        private string _CompraStatus;

        public string CompraStatus
        {
            get
            {
                return this._CompraStatus;
            }
            set
            {
                this._CompraStatus = value;
            }
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

    }
}
