using System;

namespace Modelo
{
    public class Model_ItensCompra
    {

        private int idItensCompra;
        private Double quantidade;
        private Double valor;
        private int idCompraItensCompra;
        private int idProdutoItensCompra;

        public int IdItensCompra { get => idItensCompra; set => idItensCompra = value; }
        public double Quantidade { get => quantidade; set => quantidade = value; }
        public double Valor { get => valor; set => valor = value; }
        public int IdCompraItensCompra { get => idCompraItensCompra; set => idCompraItensCompra = value; }
        public int IdProdutoItensCompra { get => idProdutoItensCompra; set => idProdutoItensCompra = value; }
    }
}


