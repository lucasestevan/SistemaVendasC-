using DAL;
using Modelo;
using System;
using System.Data;

namespace BLL
{
    public class BLL_Categoria
    {
        private DAL_Conexao conexao;

        public BLL_Categoria(DAL_Conexao con)
        {
            this.conexao = con;
        }

        //METODO INCLUIR
        public void Incluir(Model_Categoria modelo)
        {
            //VERIFICAR SE O CAMPO NÃO É VAZIO
            if (modelo.NomeCategoria.Trim().Length == 0)
            {
                throw new Exception("O nome da categora é obrigatorio");
            }

            DAL_Categoria DALobj = new DAL_Categoria(conexao);
            DALobj.Incluir(modelo);
        }

        //METODO ALTERAR
        public void Alterar(Model_Categoria modelo)
        {
            //VERIFICAR SE O CAMPO NÃO É VAZIO
            if (modelo.IdCategoria <= 0)
            {
                throw new Exception("O codigo da categora é obrigatorio");
            }
            if (modelo.NomeCategoria.Trim().Length == 0)
            {
                throw new Exception("O nome da categora é obrigatorio");
            }

            DAL_Categoria DALobj = new DAL_Categoria(conexao);
            DALobj.Alterar(modelo);
        }

        //METODO EXCLUIR
        public void Excluir(int idCategoria)
        {
            DAL_Categoria DALobj = new DAL_Categoria(conexao);
            DALobj.Excluir(idCategoria);
        }

        //METODO CARRREGA MODELO COMPRA
        public Model_Categoria CarregaModeloCategoria(int idCategoria)
        {
            DAL_Categoria DALobj = new DAL_Categoria(conexao);
            return DALobj.CarregaModeloCategoria(idCategoria);
        }

        //METODO LOCALIZAR
        public DataTable Localizar(String valor)
        {
            DAL_Categoria DALobj = new DAL_Categoria(conexao);
            return DALobj.Localizar(valor);
        }

        //METODO VERIFICA SE EXISTE
        public int VerificaSeExiste(String valor)
        {
            DAL_Categoria DALobj = new DAL_Categoria(conexao);
            return DALobj.VerificaSeExiste(valor);
        }
    }
}
