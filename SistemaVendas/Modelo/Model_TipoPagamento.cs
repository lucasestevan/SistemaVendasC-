using System;

namespace Modelo
{
    public class Model_TipoPagamento
    {

        private int idTipoPagamento;
        private string nome;

        public int IdTipoPagamento { get => idTipoPagamento; set => idTipoPagamento = value; }
        public string Nome { get => nome; set => nome = value; }
    }
}
