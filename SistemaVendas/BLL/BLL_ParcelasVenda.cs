﻿using DAL;
using Modelo;
using System;
using System.Data;

namespace BLL
{
    public class BLL_ParcelasVenda
    {
        private DAO_Conexao conexao;

        public BLL_ParcelasVenda(DAO_Conexao con)
        {
            this.conexao = con;
        }

        //METODO INCLUIR
        public void Incluir(Model_ParcelasVenda modelo)
        {
            //VERIFICAR SE O CAMPO NÃO É VAZIO
            if (modelo.IdParcelasVenda <= 0)
            {
                throw new Exception("O Código da parcela é obrigatorio");
            }

            if (modelo.IdVenda <= 0)
            {
                throw new Exception("O Código da Venda é obrigatorio");
            }

            if (modelo.Valor <= 0)
            {
                throw new Exception("O valor da parcela deve ser maior que zero");
            }

            DateTime data = DateTime.Now;
            if (modelo.DataVencimento.Year < data.Year)
            {
                throw new Exception("Ano de vencimento inferior ao ano atual");
            }

            DAO_ParcelasVenda DALobj = new DAO_ParcelasVenda(conexao);
            DALobj.Incluir(modelo);
        }

        //METODO ALTERAR
        public void Alterar(Model_ParcelasVenda modelo)
        {
            //VERIFICAR SE O CAMPO NÃO É VAZIO
            if (modelo.IdParcelasVenda <= 0)
            {
                throw new Exception("O Código da parcela é obrigatorio");
            }

            if (modelo.Valor <= 0)
            {
                throw new Exception("O valor da parcela deve ser maior que zero");
            }

            DateTime data = DateTime.Now;
            if (modelo.DataVencimento.Year < data.Year)
            {
                throw new Exception("Ano de vencimento inferior ao ano atual");
            }

            DAO_ParcelasVenda DALobj = new DAO_ParcelasVenda(conexao);
            DALobj.Alterar(modelo);
        }

        //METODO EXCLUIR
        public void Excluir(Model_ParcelasVenda modelo)
        {
            if (modelo.IdParcelasVenda <= 0)
            {
                throw new Exception("O Código da parcela é obrigatorio");
            }

            if (modelo.IdVenda <= 0)
            {
                throw new Exception("O Código da Venda é obrigatorio");
            }

            DAO_ParcelasVenda DALobj = new DAO_ParcelasVenda(conexao);
        }

        //METODO EXCLUIR todas as parcelas
        public void ExcluirTodasParcelas(int idVenda)
        {
            if (idVenda <= 0)
            {
                throw new Exception("O Código da venda é obrigatorio");
            }

            DAO_ParcelasVenda DALobj = new DAO_ParcelasVenda(conexao);
            DALobj.ExcluirTodasParcelas(idVenda);
        }

        //METODO CARRREGA MODELO COMPRA
        public Model_ParcelasVenda CarregaModeloCliente(int idParcelas, int idVenda)
        {
            DAO_ParcelasVenda DALobj = new DAO_ParcelasVenda(conexao);
            return DALobj.CarregaModeloParcelasVenda(idParcelas, idVenda);
        }

        //METODO LOCALIZAR
        public DataTable Localizar(int idVenda)
        {
            if (idVenda <= 0)
            {
                throw new Exception("O Código da parcela é obrigatorio");
            }

            DAO_ParcelasVenda DALobj = new DAO_ParcelasVenda(conexao);
            return DALobj.Localizar(idVenda);
        }

        //METODO LOCALIZAR vencimento
        public DataTable LocalizarPertoVencimento(DateTime inicial, DateTime final)
        {
            DAO_ParcelasVenda DALobj = new DAO_ParcelasVenda(conexao);
            return DALobj.LocalizarPertoVencimento(inicial, final);
        }

        //RECEBIMENTO VENDA
        public void RecebimentoParcela(int idVenda, int idParcelaVenda, DateTime dtPagto)
        {
            if (dtPagto != null)
            {
                DAO_ParcelasVenda DALobj = new DAO_ParcelasVenda(conexao);
                DALobj.RecebimentoParcela(idVenda, idParcelaVenda, dtPagto);
            }
            else
            {
                throw new Exception("Data do recebimento é obrigatorio");
            }
        }
    }
}
