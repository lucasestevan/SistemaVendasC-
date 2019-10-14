using System;

namespace Modelo
{
    public class Model_ItensVenda
    {
        private int idItensVenda;
        private Double quantidade;
        private Double valor;
        private int idVendaItensVendas;
        private int idProdutoItensVenda;

        public int IdItensVenda { get => idItensVenda; set => idItensVenda = value; }
        public double Quantidade { get => quantidade; set => quantidade = value; }
        public double Valor { get => valor; set => valor = value; }
        public int IdVendaItensVendas { get => idVendaItensVendas; set => idVendaItensVendas = value; }
        public int IdProdutoItensVenda { get => idProdutoItensVenda; set => idProdutoItensVenda = value; }
    }
}
