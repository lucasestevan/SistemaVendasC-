using System;

namespace Modelo
{
    public class Model_ItensCompra
    {
        public Model_ItensCompra()
        {
            this.idItensCompra = 0;
            this.Quantidade = 0;
            this.Valor = 0;
            this.idCompraItensCompra = 0;
            this.idProdutoItensCompra = 0;
        }

        public Model_ItensCompra(int idItensCompra, Double Quantidade, Double Valor, int idCompraItensCompra, int idProdutoItensCompra)
        {
            this.idItensCompra = idItensCompra;
            this.Quantidade = Quantidade;
            this.Valor = Valor;
            this.idCompraItensCompra = idCompraItensCompra;
            this.idProdutoItensCompra = idProdutoItensCompra;
        }

        private int _idItensCompra;

        public int idItensCompra
        {
            get
            {
                return this._idItensCompra;
            }
            set
            {
                this._idItensCompra = value;
            }
        }

        private Double _Quantidade;

        public Double Quantidade
        {
            get
            {
                return this._Quantidade;
            }
            set
            {
                this._Quantidade = value;
            }
        }

        private Double _Valor;

        public Double Valor
        {
            get
            {
                return this._Valor;
            }
            set
            {
                this._Valor = value;
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

        private int _idCompraItensCompra;

        public int idCompraItensCompra
        {
            get
            {
                return this._idCompraItensCompra;
            }
            set
            {
                this._idCompraItensCompra = value;
            }
        }

        private int _idProdutoItensCompra;

        public int idProdutoItensCompra
        {
            get
            {
                return this._idProdutoItensCompra;
            }
            set
            {
                this._idProdutoItensCompra = value;
            }
        }
    }
}
