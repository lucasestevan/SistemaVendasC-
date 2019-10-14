using System;

namespace Modelo
{
    public class Model_ParcelasVenda
    {
        private int idParcelasVenda;
        private double valor;
        private DateTime dataPagto;
        private DateTime dataVencimento;
        private int idVenda;

        public int IdParcelasVenda { get => idParcelasVenda; set => idParcelasVenda = value; }
        public double Valor { get => valor; set => valor = value; }
        public DateTime DataPagto { get => dataPagto; set => dataPagto = value; }
        public DateTime DataVencimento { get => dataVencimento; set => dataVencimento = value; }
        public int IdVenda { get => idVenda; set => idVenda = value; }
    }
}
