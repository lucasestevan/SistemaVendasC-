using DAL;
using Modelo;
using System;
using System.Data;

namespace BLL
{
    public class BLL_Produto
    {
        private DAO_Conexao conexao;

        public BLL_Produto(DAO_Conexao con)
        {
            this.conexao = con;
        }

        //METODO INCLUIR
        public void Incluir(Model_Produto modelo)
        {
            //VERIFICAR SE O CAMPO NÃO É VAZIO
            if (modelo.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome da produto é obrigatorio");
            }

            if (modelo.Preco <= 0)
            {
                throw new Exception("O Preço é obrigatorio");
            }

            if (modelo.Quantidade <= 0)
            {
                throw new Exception("A quantidade deve ser 0 ou maior!");
            }

            if (modelo.IdCategoria <= 0)
            {
                throw new Exception("A Categoria é obrigatoria");
            }

            if (modelo.IdFornecedor <= 0)
            {
                throw new Exception("O Fornecedor é obrigatorio");
            }

            if (modelo.Codigo_pro.Trim().Length == 0)
            {
                throw new Exception("O codigo do produto é obrigatorio");
            }

            DAO_Produto DALobj = new DAO_Produto(conexao);
            DALobj.Incluir(modelo);
        }

        //METODO ALTERAR
        public void Alterar(Model_Produto modelo)
        {
            //VERIFICAR SE O CAMPO NÃO É VAZIO
            if (modelo.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome da produto é obrigatorio");
            }

            if (modelo.Preco <= 0)
            {
                throw new Exception("O Preço é obrigatorio");
            }

            if (modelo.Quantidade <= 0)
            {
                throw new Exception("A quantidade deve ser 0 ou maior!");
            }

            if (modelo.IdCategoria <= 0)
            {
                throw new Exception("A Categoria é obrigatoria");
            }

            if (modelo.IdFornecedor <= 0)
            {
                throw new Exception("O Fornecedor é obrigatorio");
            }

            if (modelo.Codigo_pro.Trim().Length == 0)
            {
                throw new Exception("O codigo do produto é obrigatorio");
            }

            DAO_Produto DALobj = new DAO_Produto(conexao);
            DALobj.Alterar(modelo, true);
        }

        //METODO EXCLUIR
        public void Excluir(int idProduto)
        {
            DAO_Produto DALobj = new DAO_Produto(conexao);
            DALobj.Excluir(idProduto);
        }

        //METODO CARRREGA MODELO 
        public Model_Produto CarregaModeloProduto(int idProduto)
        {
            DAO_Produto DALobj = new DAO_Produto(conexao);
            return DALobj.CarregaModeloProduto(idProduto);
        }

        //METODO localiza por fornecedor
        public DataTable LocalizarPorFornecedor(int idFornecedor)
        {
            DAO_Produto DALobj = new DAO_Produto(conexao);
            return DALobj.LocalizarPorFornecedor(idFornecedor);
        }

        //METODO LOCALIZAR nome
        public DataTable LocalizarPorNome(String nome)
        {
            DAO_Produto DALobj = new DAO_Produto(conexao);
            return DALobj.LocalizarPorNome(nome);
        }

        //METODO LOCALIZAR fornecedor
        public DataTable LocalizarPorFornecedor(String fornecedor)
        {
            DAO_Produto DALobj = new DAO_Produto(conexao);
            return DALobj.LocalizarPorFornecedor(fornecedor);
        }

        //METODO LOCALIZAR categoria
        public DataTable LocalizarPorCategoria(String categora)
        {
            DAO_Produto DALobj = new DAO_Produto(conexao);
            return DALobj.LocalizarPorCategoria(categora);
        }

        //METODO CARRREGA MODELO 
        public Model_Produto CarregaModeloProdutoCodigo(string cod)
        {
            DAO_Produto DALobj = new DAO_Produto(conexao);
            return DALobj.CarregaModeloProdutoCodigo(cod);
        }

        //METODO LOCALIZAR
        public DataTable Localizar(String valor)
        {
            DAO_Produto DALobj = new DAO_Produto(conexao);
            return DALobj.Localizar(valor);
        }

        //METODO LOCALIZAR estoque baixo
        public DataTable LocalizarEstoqueBaixo()
        {
            DAO_Produto DALobj = new DAO_Produto(conexao);
            return DALobj.LocalizarEstoqueBaixo();
        }
    }
}
