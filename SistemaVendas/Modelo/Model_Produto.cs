using System;

namespace Modelo
{
    public class Model_Produto
    {
        public Model_Produto()
        {
            this.idProduto = 0;
            this.nome = "";
            this.descricao = "";
            this.preco = 0;
            this.quantidade = 0;
            this.idCategoria = 0;
            this.idFornecedor = 0;

        }

        public Model_Produto(int idProduto, String nome, String descricao, Double preco, Double quantidade, int idCategoria, int idFornecedor)
        {
            this.idProduto = idProduto;
            this.nome = nome;
            this.descricao = descricao;
            this.preco = preco;
            this.quantidade = quantidade;
            this.idCategoria = idCategoria;
            this.idFornecedor = idFornecedor;
        }

        private int _idProduto;

        public int idProduto
        {
            get
            {
                return this._idProduto;
            }
            set
            {
                this._idProduto = value;
            }
        }

        private String _nome;

        public String nome
        {
            get
            {
                return this._nome;
            }
            set
            {
                this._nome = value;
            }
        }

        private String _descricao;

        public String descricao
        {
            get
            {
                return this._descricao;
            }
            set
            {
                this._descricao = value;
            }
        }

        private Double _preco;

        public Double preco
        {
            get
            {
                return this._preco;
            }
            set
            {
                this._preco = value;
            }
        }

        private Double _quantidade;

        public Double quantidade
        {
            get
            {
                return this._quantidade;
            }
            set
            {
                this._quantidade = value;
            }
        }

        private int _idCategoria;
        public int idCategoria
        {
            get
            {
                return this._idProduto;
            }
            set
            {
                this._idProduto = value;
            }
        }

        private int _idForcedor;
        public int idFornecedor
        {
            get
            {
                return this._idForcedor;
            }
            set
            {
                this._idForcedor = value;
            }
        }
    }
}
