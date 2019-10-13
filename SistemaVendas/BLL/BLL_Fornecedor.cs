using DAL;
using Modelo;
using System;
using System.Data;

namespace BLL
{
    public class BLL_Fornecedor
    {
        private DAL_Conexao conexao;

        public BLL_Fornecedor(DAL_Conexao con)
        {
            this.conexao = con;
        }

        //METODO INCLUIR
        public void Incluir(Model_Fornecedor modelo)
        {
            //VERIFICAR SE O CAMPO NÃO É VAZIO
            if (modelo.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do Fornecedor é obrigatorio");
            }

            if (modelo.CpfCNPJ.Trim().Length == 0)
            {
                throw new Exception("O CPF ou CNPJ é obrigatorio");
            }
            
            DAL_Fornecedor DALobj = new DAL_Fornecedor(conexao);
            DALobj.Incluir(modelo);
        }

        //METODO ALTERAR
        public void Alterar(Model_Fornecedor modelo)
        {
            //VERIFICAR SE O CAMPO NÃO É VAZIO
            if (modelo.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do Fornecedor é obrigatorio");
            }

            if (modelo.CpfCNPJ.Trim().Length == 0)
            {
                throw new Exception("O CPF ou CNPJ é obrigatorio");
            }

            DAL_Fornecedor DALobj = new DAL_Fornecedor(conexao);
            DALobj.Alterar(modelo);
        }

        //METODO EXCLUIR
        public void Excluir(int idFornecedor)
        {
            DAL_Fornecedor DALobj = new DAL_Fornecedor(conexao);
            DALobj.Excluir(idFornecedor);
        }

        //METODO CARRREGA MODELO 
        public Model_Fornecedor CarregaModeloFornecedor(int idFornecedor)
        {
            DAL_Fornecedor DALobj = new DAL_Fornecedor(conexao);
            return DALobj.CarregaModeloFornecedor(idFornecedor);
        }

        //METODO LOCALIZAR
        public DataTable Localizar(String valor)
        {
            DAL_Fornecedor DALobj = new DAL_Fornecedor(conexao);
            return DALobj.Localizar(valor);
        }
    }
}
