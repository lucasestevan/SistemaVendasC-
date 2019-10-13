using System;

namespace Modelo
{
    public class Model_Compra
    {
        private int idCompra;
        private DateTime dataCompra;
        private int nFiscal;
        private double total;
        private int nParcelas;
        private string compraStatus;
        private int idFornecedor;
        private int idTipoPagamento;

        public int IdCompra { get => idCompra; set => idCompra = value; }
        public DateTime DataCompra { get => dataCompra; set => dataCompra = value; }
        public int NFiscal { get => nFiscal; set => nFiscal = value; }
        public double Total { get => total; set => total = value; }
        public int NParcelas { get => nParcelas; set => nParcelas = value; }
        public string CompraStatus { get => compraStatus; set => compraStatus = value; }
        public int IdFornecedor { get => idFornecedor; set => idFornecedor = value; }
        public int IdTipoPagamento { get => idTipoPagamento; set => idTipoPagamento = value; }
    }
}
