﻿using DAL;
using Modelo;
using System;
using System.Data;

namespace BLL
{
    public class BLL_Categoria
    {
        private DAO_Conexao conexao;

        public BLL_Categoria(DAO_Conexao con)
        {
            this.conexao = con;
        }

        //METODO INCLUIR
        public void Incluir(Model_Categoria modelo)
        {
            //VERIFICAR SE O CAMPO NÃO É VAZIO
            if (modelo.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome da categora é obrigatorio");
            }

            DAO_Categoria DALobj = new DAO_Categoria(conexao);
            DALobj.Incluir(modelo);
        }

        //METODO ALTERAR
        public void Alterar(Model_Categoria modelo)
        {
            //VERIFICAR SE O CAMPO NÃO É VAZIO
            if (modelo.Id_categoria <= 0)
            {
                throw new Exception("O codigo da categora é obrigatorio");
            }
            if (modelo.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome da categora é obrigatorio");
            }

            DAO_Categoria DALobj = new DAO_Categoria(conexao);
            DALobj.Alterar(modelo);
        }

        //METODO EXCLUIR
        public void Excluir(int idCategoria)
        {
            DAO_Categoria DALobj = new DAO_Categoria(conexao);
            DALobj.Excluir(idCategoria);
        }

        //METODO CARRREGA MODELO COMPRA
        public Model_Categoria CarregaModeloCategoria(int idCategoria)
        {
            DAO_Categoria DALobj = new DAO_Categoria(conexao);
            return DALobj.CarregaModeloCategoria(idCategoria);
        }

        //METODO LOCALIZAR
        public DataTable Localizar(String valor)
        {
            DAO_Categoria DALobj = new DAO_Categoria(conexao);
            return DALobj.Localizar(valor);
        }

        //METODO VERIFICA SE EXISTE
        public int VerificaSeExiste(String valor)
        {
            DAO_Categoria DALobj = new DAO_Categoria(conexao);
            return DALobj.VerificaSeExiste(valor);
        }
    }
}
