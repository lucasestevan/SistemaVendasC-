using DAL;
using Modelo;
using System;
using System.Data;

namespace BLL
{
    public class BLL_Cliente
    {
        private DAL_Conexao conexao;

        public BLL_Cliente(DAL_Conexao con)
        {
            this.conexao = con;
        }

        //METODO INCLUIR
        public void Incluir(Model_Cliente modelo)
        {
            //VERIFICAR SE O CAMPO NÃO É VAZIO
            if (modelo.nome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é obrigatorio");
            }

            if (modelo.cpf.Trim().Length == 0)
            {
                throw new Exception("O CPF do cliente é obrigatorio");
            }
            if (modelo.idEndereco <= 0)
            {
                throw new Exception("O Endereco é obrigatorio");
            }

            DAL_Cliente DALobj = new DAL_Cliente(conexao);
            DALobj.Incluir(modelo);
        }

        //METODO ALTERAR
        public void Alterar(Model_Cliente modelo)
        {
            //VERIFICAR SE O CAMPO NÃO É VAZIO
            if (modelo.nome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é obrigatorio");
            }

            if (modelo.cpf.Trim().Length == 0)
            {
                throw new Exception("O CPF do cliente é obrigatorio");
            }

            DAL_Cliente DALobj = new DAL_Cliente(conexao);
            DALobj.Alterar(modelo);
        }

        //METODO EXCLUIR
        public void Excluir(int idProduto)
        {
            DAL_Cliente DALobj = new DAL_Cliente(conexao);
            DALobj.Excluir(idProduto);
        }

        //METODO LOCALIZAR
        public DataTable Localizar(String valor)
        {
            DAL_Cliente DALobj = new DAL_Cliente(conexao);
            return DALobj.Localizar(valor);
        }
    }
}
