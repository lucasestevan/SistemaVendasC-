﻿using DAL;
using Modelo;
using System;
using System.Data;

namespace BLL
{
    public class BLL_Venda
    {
        private DAO_Conexao conexao;

        public BLL_Venda(DAO_Conexao con)
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

            DAO_Venda DALobj = new DAO_Venda(conexao);
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

            DAO_Venda DALobj = new DAO_Venda(conexao);
            DALobj.Alterar(modelo);
        }

        //METODO CANCELAR VENDA
        public void CancelarVenda(int idVenda)
        {
            DAO_Venda DALobj = new DAO_Venda(conexao);
            DALobj.CancelarVenda(idVenda);
        }

        //METODO EXCLUIR
        public void Excluir(int idVenda)
        {
            DAO_Venda DALobj = new DAO_Venda(conexao);
            DALobj.Excluir(idVenda);
        }


        //METODO CARRREGA MODELO COMPRA
        public Model_Venda CarregaModeloVenda(int idVenda)
        {
            DAO_Venda DALobj = new DAO_Venda(conexao);
            return DALobj.CarregaModeloVenda(idVenda);
        }

        //METODO LOCALIZAR fgeral
        public DataTable LocalizarGeral()
        {
            DAO_Venda DALobj = new DAO_Venda(conexao);
            return DALobj.LocalizarGeral();
        }

        //METODO LOCALIZAR IDvenda
        public DataTable LocalizaridVenda(String idVenda)
        {
            DAO_Venda DALobj = new DAO_Venda(conexao);
            return DALobj.LocalizaridVenda(idVenda);
        }

        //METODO LOCALIZAR POR NOME DE cliente
        public DataTable LocalizarNome(String nome)
        {
            DAO_Venda DALobj = new DAO_Venda(conexao);
            return DALobj.LocalizarNome(nome);
        }

        //METODO LOCALIZAR por data
        public DataTable LocalizarData(DateTime inicial, DateTime final)
        {
            DAO_Venda DALobj = new DAO_Venda(conexao);
            return DALobj.LocalizarData(inicial, final);
        }

        //METODO LOCALIZAR POR parcelas em aberto
        public DataTable LocalizarParcelsAberto()
        {
            DAO_Venda DALobj = new DAO_Venda(conexao);
            return DALobj.LocalizarParcelsAberto();
        }

        //METODO LOCALIZAR parcelas nao pagas
        public int ParcelasNaoPagas(int idVenda)
        {
            DAO_Venda DALobj = new DAO_Venda(conexao);
            return DALobj.ParcelasNaoPagas(idVenda);
        }

        //METODO PAGAR Venda
        public void PagarParcelaVenda(Model_Venda modelo)
        {
            DAO_Venda DALobj = new DAO_Venda(conexao);
            DALobj.PagarParcelaVenda(modelo);
        }
    }
}
