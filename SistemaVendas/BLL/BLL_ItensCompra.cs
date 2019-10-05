using DAL;
using Modelo;
using System;
using System.Data;

namespace BLL
{
    public class BLL_ItensCompra
    {
        private DAL_Conexao conexao;

        public BLL_ItensCompra(DAL_Conexao con)
        {
            this.conexao = con;
        }

        //METODO INCLUIR
        public void Incluir(Model_ItensCompra modelo)
        {
            //VERIFICAR SE O CAMPO NÃO É VAZIO
            if (modelo.idCompraItensCompra <= 0)
            {
                throw new Exception("O Código da Compra é obrigatorio");
            }

            if (modelo.idItensCompra <= 0)
            {
                throw new Exception("o Código do item da compra é obrigatorio");
            }

            if (modelo.Quantidade <= 0)
            {
                throw new Exception("A quantidade deve ser maior que zero");
            }

            if (modelo.Valor <= 0)
            {
                throw new Exception("O Valor do Item deve ser maior que zero");
            }

            if (modelo.idProdutoItensCompra <= 0)
            {
                throw new Exception("O Código do produto é obrigatorio");
            }

            DAL_ItensCompra DALobj = new DAL_ItensCompra(conexao);
            DALobj.Incluir(modelo);
        }

        //METODO ALTERAR
        public void Alterar(Model_ItensCompra modelo)
        {
            //VERIFICAR SE O CAMPO NÃO É VAZIO
            if (modelo.idCompraItensCompra <= 0)
            {
                throw new Exception("O Código da Compra é obrigatorio");
            }

            if (modelo.idItensCompra <= 0)
            {
                throw new Exception("o Código do item da compra é obrigatorio");
            }

            if (modelo.Quantidade <= 0)
            {
                throw new Exception("A quantidade deve ser maior que zero");
            }

            if (modelo.Valor <= 0)
            {
                throw new Exception("O Valor do Item deve ser maior que zero");
            }

            if (modelo.idProdutoItensCompra <= 0)
            {
                throw new Exception("O Código do produto é obrigatorio");
            }

            DAL_ItensCompra DALobj = new DAL_ItensCompra(conexao);
            DALobj.Alterar(modelo);
        }

        //METODO EXCLUIR
        public void Excluir(Model_ItensCompra modelo)
        {
            //VERIFICAR SE O CAMPO NÃO É VAZIO
            if (modelo.idCompraItensCompra <= 0)
            {
                throw new Exception("O Código da Compra é obrigatorio");
            }

            if (modelo.idItensCompra <= 0)
            {
                throw new Exception("o Código do item da compra é obrigatorio");
            }

            if (modelo.idProdutoItensCompra <= 0)
            {
                throw new Exception("O Código do produto é obrigatorio");
            }

            DAL_ItensCompra DALobj = new DAL_ItensCompra(conexao);
            DALobj.Excluir(modelo);
        }

        //METODO EXCLUIR tudo
        public void ExcluirTodosItens(int idCompra)
        {
            DAL_ItensCompra DALobj = new DAL_ItensCompra(conexao);
            DALobj.ExcluirTodosItens(idCompra);
        }


        //METODO CARRREGA MODELO COMPRA
        public Model_ItensCompra CarregaModeloItensCompra(int idCompra)
        {
            DAL_ItensCompra DALobj = new DAL_ItensCompra(conexao);
            return DALobj.CarregaModeloItensCompra(idCompra);
        }

        //METODO LOCALIZAR
        public DataTable Localizar(int idCompra)
        {
            DAL_ItensCompra DALobj = new DAL_ItensCompra(conexao);
            return DALobj.Localizar(idCompra);
        }
    }
}
