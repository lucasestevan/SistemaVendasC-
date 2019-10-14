using DAL;
using Modelo;
using System;
using System.Data;

namespace BLL
{
    public class BLL_ItensVendas
    {
        private DAL_Conexao conexao;

        public BLL_ItensVendas(DAL_Conexao con)
        {
            this.conexao = con;
        }

        //METODO INCLUIR
        public void Incluir(Model_ItensVenda modelo)
        {
            //VERIFICAR SE O CAMPO NÃO É VAZIO
            if (modelo.IdVendaItensVendas <= 0)
            {
                throw new Exception("O Código da Venda é obrigatorio");
            }

            if (modelo.IdItensVenda <= 0)
            {
                throw new Exception("o Código do item da venda é obrigatorio");
            }

            if (modelo.Quantidade <= 0)
            {
                throw new Exception("A quantidade deve ser maior que zero");
            }

            if (modelo.Valor <= 0)
            {
                throw new Exception("O Valor do Item deve ser maior que zero");
            }

            if (modelo.IdProdutoItensVenda <= 0)
            {
                throw new Exception("O Código do produto é obrigatorio");
            }

            DAL_ItensVenda DALobj = new DAL_ItensVenda(conexao);
            DALobj.Incluir(modelo);
        }

        //METODO ALTERAR
        public void Alterar(Model_ItensVenda modelo)
        {
            //VERIFICAR SE O CAMPO NÃO É VAZIO
            if (modelo.IdVendaItensVendas <= 0)
            {
                throw new Exception("O Código da venda é obrigatorio");
            }

            if (modelo.IdItensVenda <= 0)
            {
                throw new Exception("o Código do item da venda é obrigatorio");
            }

            if (modelo.Quantidade <= 0)
            {
                throw new Exception("A quantidade deve ser maior que zero");
            }

            if (modelo.Valor <= 0)
            {
                throw new Exception("O Valor do Item deve ser maior que zero");
            }

            if (modelo.IdProdutoItensVenda <= 0)
            {
                throw new Exception("O Código do produto é obrigatorio");
            }

            DAL_ItensVenda DALobj = new DAL_ItensVenda(conexao);
            DALobj.Alterar(modelo);
        }

        //METODO EXCLUIR
        public void Excluir(Model_ItensVenda modelo)
        {
            //VERIFICAR SE O CAMPO NÃO É VAZIO
            if (modelo.IdVendaItensVendas <= 0)
            {
                throw new Exception("O Código da venda é obrigatorio");
            }

            if (modelo.IdItensVenda <= 0)
            {
                throw new Exception("o Código do item da venda é obrigatorio");
            }

            if (modelo.IdProdutoItensVenda <= 0)
            {
                throw new Exception("O Código do produto é obrigatorio");
            }

            DAL_ItensVenda DALobj = new DAL_ItensVenda(conexao);
            DALobj.Excluir(modelo);
        }

        //METODO EXCLUIR tudo
        public void ExcluirTodosItens(int idVenda)
        {
            DAL_ItensVenda DALobj = new DAL_ItensVenda(conexao);
            DALobj.ExcluirTodosItens(idVenda);
        }


        //METODO CARRREGA MODELO COMPRA
        public Model_ItensVenda CarregaModeloItensCompra(int idVenda, int idItenVenda, int idProduto)
        {
            DAL_ItensVenda DALobj = new DAL_ItensVenda(conexao);
            return DALobj.CarregaModeloItensVenda(idVenda, idItenVenda, idProduto);
        }

        //METODO LOCALIZAR
        public DataTable Localizar(int idVenda)
        {
            DAL_ItensVenda DALobj = new DAL_ItensVenda(conexao);
            return DALobj.Localizar(idVenda);
        }
    }
}
