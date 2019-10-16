using DAL;
using Modelo;
using System;
using System.Data;

namespace BLL
{
    public class BLL_Venda
    {
        private DAL_Conexao conexao;

        public BLL_Venda(DAL_Conexao con)
        {
            this.conexao = con;
        }

        //METODO INCLUIR
        public void Incluir(Model_Venda modelo)
        {
            //VERIFICAR SE O CAMPO NÃO É VAZIO
            if (modelo.Total < 0)
            {
                throw new Exception("O Total da venda dever ser maior que zero");
            }

            if (modelo.IdTipoPagamento <= 0)
            {
                throw new Exception("O tipo de pagamento é obrigatorio!");
            }

            //if (modelo.idCliente <= 0)
            // {
            //    throw new Exception("O Cliente é obrigatorio");
            // }

            if (modelo.NParcelas < 0)
            {
                throw new Exception("O Número de parcelas dever ser maior que zero");
            }

            DAL_Venda DALobj = new DAL_Venda(conexao);
            DALobj.Incluir(modelo);
        }

        //METODO ALTERAR
        public void Alterar(Model_Venda modelo)
        {
            //VERIFICAR SE O CAMPO NÃO É VAZIO
            if (modelo.IdVenda <= 0)
            {
                throw new Exception("o código da Venda deve ser informado");
            }

            if (modelo.Total < 0)
            {
                throw new Exception("O Total da venda dever ser maior que zero");
            }

            if (modelo.IdTipoPagamento <= 0)
            {
                throw new Exception("O tipo de pagamento é obrigatorio!");
            }

            //if (modelo.idCliente <= 0)
            // {
            //    throw new Exception("O Cliente é obrigatorio");
            // }

            if (modelo.NParcelas < 0)
            {
                throw new Exception("O Número de parcelas dever ser maior que zero");
            }

            DAL_Venda DALobj = new DAL_Venda(conexao);
            DALobj.Alterar(modelo);
        }

        //METODO CANCELAR VENDA
        public void CancelarVenda(int idVenda)
        {
            DAL_Venda DALobj = new DAL_Venda(conexao);
            DALobj.CancelarVenda(idVenda);
        }

        //METODO EXCLUIR
        public void Excluir(int idVenda)
        {
            DAL_Venda DALobj = new DAL_Venda(conexao);
            DALobj.Excluir(idVenda);
        }


        //METODO CARRREGA MODELO COMPRA
        public Model_Venda CarregaModeloVenda(int idVenda)
        {
            DAL_Venda DALobj = new DAL_Venda(conexao);
            return DALobj.CarregaModeloVenda(idVenda);
        }

        //METODO LOCALIZAR fgeral
        public DataTable LocalizarGeral()
        {
            DAL_Venda DALobj = new DAL_Venda(conexao);
            return DALobj.LocalizarGeral();
        }

        //METODO LOCALIZAR IDvenda
        public DataTable LocalizaridVenda(int idVenda)
        {
            DAL_Venda DALobj = new DAL_Venda(conexao);
            return DALobj.LocalizaridVenda(idVenda);
        }

        //METODO LOCALIZAR POR NOME DE cliente
        public DataTable LocalizarNome(String nome)
        {
            DAL_Venda DALobj = new DAL_Venda(conexao);
            return DALobj.LocalizarNome(nome);
        }

        //METODO LOCALIZAR por data
        public DataTable LocalizarData(DateTime inicial, DateTime final)
        {
            DAL_Venda DALobj = new DAL_Venda(conexao);
            return DALobj.LocalizarData(inicial, final);
        }

        //METODO LOCALIZAR POR parcelas em aberto
        public DataTable LocalizarParcelsAberto()
        {
            DAL_Venda DALobj = new DAL_Venda(conexao);
            return DALobj.LocalizarParcelsAberto();
        }

        //METODO LOCALIZAR parcelas nao pagas
        public int ParcelasNaoPagas(int idVenda)
        {
            DAL_Venda DALobj = new DAL_Venda(conexao);
            return DALobj.ParcelasNaoPagas(idVenda);
        }
     }
}
