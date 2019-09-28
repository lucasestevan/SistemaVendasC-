using DAL;
using Modelo;
using System;
using System.Data;

namespace BLL
{
    public class BLL_Produto
    {
        private DAL_Conexao conexao;

        public BLL_Produto(DAL_Conexao con)
        {
            this.conexao = con;
        }

        //METODO INCLUIR
        public void Incluir(Model_Produto modelo)
        {
            //VERIFICAR SE O CAMPO NÃO É VAZIO
            if (modelo.nome.Trim().Length == 0)
            {
                throw new Exception("O nome da produto é obrigatorio");
            }

            if (modelo.preco <= 0)
            {
                throw new Exception("O Preço é obrigatorio");
            }

            if (modelo.quantidade <= 0)
            {
                throw new Exception("A quantidade deve ser 0 ou maior!");
            }

            if (modelo.idCategoria <= 0)
            {
                throw new Exception("A Categoria é obrigatoria");
            }

            if (modelo.idFornecedor <= 0)
            {
                throw new Exception("O Fornecedor é obrigatorio");
            }

            DAL_Produto DALobj = new DAL_Produto(conexao);
            DALobj.Incluir(modelo);
        }

        //METODO ALTERAR
        public void Alterar(Model_Produto modelo)
        {
            //VERIFICAR SE O CAMPO NÃO É VAZIO
            if (modelo.nome.Trim().Length == 0)
            {
                throw new Exception("O nome da produto é obrigatorio");
            }

            if (modelo.preco <= 0)
            {
                throw new Exception("O Preço é obrigatorio");
            }

            if (modelo.quantidade <= 0)
            {
                throw new Exception("A quantidade deve ser 0 ou maior!");
            }

            if (modelo.idCategoria <= 0)
            {
                throw new Exception("A Categoria é obrigatoria");
            }

            if (modelo.idFornecedor <= 0)
            {
                throw new Exception("O Fornecedor é obrigatorio");
            }

            DAL_Produto DALobj = new DAL_Produto(conexao);
            DALobj.Alterar(modelo);
        }

        //METODO EXCLUIR
        public void Excluir(int idProduto)
        {
            DAL_Produto DALobj = new DAL_Produto(conexao);
            DALobj.Excluir(idProduto);
        }

        //METODO LOCALIZAR
        public DataTable Localizar(String valor)
        {
            DAL_Produto DALobj = new DAL_Produto(conexao);
            return DALobj.Localizar(valor);
        }
    }
}
