﻿using DAL;
using Modelo;
using System;
using System.Data;

namespace BLL
{
    public class BLL_ItensCompra
    {
        private DAO_Conexao conexao;

        public BLL_ItensCompra(DAO_Conexao con)
        {
            this.conexao = con;
        }

        //METODO INCLUIR
        public void Incluir(Model_ItensCompra modelo)
        {
            //VERIFICAR SE O CAMPO NÃO É VAZIO
            if (modelo.IdCompraItensCompra <= 0)
            {
                throw new Exception("O Código da Compra é obrigatorio");
            }

            if (modelo.IdItensCompra <= 0)
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

            if (modelo.IdProdutoItensCompra <= 0)
            {
                throw new Exception("O Código do produto é obrigatorio");
            }

            DAO_ItensCompra DALobj = new DAO_ItensCompra(conexao);
            DALobj.Incluir(modelo);
        }

        //METODO ALTERAR
        public void Alterar(Model_ItensCompra modelo)
        {
            //VERIFICAR SE O CAMPO NÃO É VAZIO
            if (modelo.IdCompraItensCompra <= 0)
            {
                throw new Exception("O Código da Compra é obrigatorio");
            }

            if (modelo.IdItensCompra <= 0)
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

            if (modelo.IdProdutoItensCompra <= 0)
            {
                throw new Exception("O Código do produto é obrigatorio");
            }

            DAO_ItensCompra DALobj = new DAO_ItensCompra(conexao);
            DALobj.Alterar(modelo);
        }

        //METODO EXCLUIR
        public void Excluir(Model_ItensCompra modelo)
        {
            //VERIFICAR SE O CAMPO NÃO É VAZIO
            if (modelo.IdCompraItensCompra <= 0)
            {
                throw new Exception("O Código da Compra é obrigatorio");
            }

            if (modelo.IdItensCompra <= 0)
            {
                throw new Exception("o Código do item da compra é obrigatorio");
            }

            if (modelo.IdProdutoItensCompra <= 0)
            {
                throw new Exception("O Código do produto é obrigatorio");
            }

            DAO_ItensCompra DALobj = new DAO_ItensCompra(conexao);
            DALobj.Excluir(modelo);
        }

        //METODO EXCLUIR tudo
        public void ExcluirTodosItens(int idCompra)
        {
            DAO_ItensCompra DALobj = new DAO_ItensCompra(conexao);
            DALobj.ExcluirTodosItens(idCompra);
        }


        //METODO CARRREGA MODELO COMPRA
        public Model_ItensCompra CarregaModeloItensCompra(int idCompra)
        {
            DAO_ItensCompra DALobj = new DAO_ItensCompra(conexao);
            return DALobj.CarregaModeloItensCompra(idCompra);
        }

        //METODO LOCALIZAR
        public DataTable Localizar(int idCompra)
        {
            DAO_ItensCompra DALobj = new DAO_ItensCompra(conexao);
            return DALobj.Localizar(idCompra);
        }
    }
}
