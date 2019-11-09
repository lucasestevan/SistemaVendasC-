using System;

namespace Modelo
{
    public class Model_Produto
    {

        private int idProduto;
        private string nome;
        private string descricao;
        private double preco;
        private double quantidade;
        private int idCategoria;
        private int idFornecedor;
        private string codigo_pro;
            

        public int IdProduto { get => idProduto; set => idProduto = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public double Preco { get => preco; set => preco = value; }
        public double Quantidade { get => quantidade; set => quantidade = value; }
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public int IdFornecedor { get => idFornecedor; set => idFornecedor = value; }
        public string Codigo_pro { get => codigo_pro; set => codigo_pro = value; }
    }
}
