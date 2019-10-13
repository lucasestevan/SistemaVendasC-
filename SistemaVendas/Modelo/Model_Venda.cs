using System;

namespace Modelo
{
    public class Model_Venda
    {
        private int idVenda;
        private DateTime dataVenda;
        private int nFiscal;
        private double total;
        private double nParcelas;
        private string vendaStatus;
        private int idCliente;
        private int idTipoPagamento;
        private int avista;

        public int IdVenda { get => idVenda; set => idVenda = value; }
        public DateTime DataVenda { get => dataVenda; set => dataVenda = value; }
        public int NFiscal { get => nFiscal; set => nFiscal = value; }
        public double Total { get => total; set => total = value; }
        public double NParcelas { get => nParcelas; set => nParcelas = value; }
        public string VendaStatus { get => vendaStatus; set => vendaStatus = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int IdTipoPagamento { get => idTipoPagamento; set => idTipoPagamento = value; }
        public int Avista { get => avista; set => avista = value; }
    }
}
