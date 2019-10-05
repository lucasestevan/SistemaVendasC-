using DAL;
using Modelo;
using SistemaVendas;
using System;
using System.Data;

namespace BLL
{
    public class BLL_Endereco
    {
        private DAL_Conexao conexao;

        public BLL_Endereco(DAL_Conexao con)
        {
            this.conexao = con;
        }

        //METODO INCLUIR
        public void Incluir(Model_Endereco modelo)
        {
            //VERIFICAR SE O CAMPO NÃO É VAZIO
                       
            if (modelo.rua.Trim().Length == 0)
            {
                throw new Exception("O campo Rua é obrigatorio!");
            }

            if (modelo.bairro.Trim().Length == 0)
            {
                throw new Exception("O Campo Bairro é obrigatorio!");
            }

            //valida cep

            if (Validacao.ValidaCep(modelo.cep) == false)
            {
                throw new Exception("O Cep é invalido!");
            }



            DAL_Endereco DALobj = new DAL_Endereco(conexao);
            DALobj.Incluir(modelo);
        }

        //METODO ALTERAR
        public void Alterar(Model_Endereco modelo)
        {
            //VERIFICAR SE O CAMPO NÃO É VAZIO
           
            if (modelo.rua.Trim().Length == 0)
            {
                throw new Exception("O campo Rua é obrigatorio!");
            }

            if (modelo.bairro.Trim().Length == 0)
            {
                throw new Exception("O Campo Bairro é obrigatorio!");
            }

            DAL_Endereco DALobj = new DAL_Endereco(conexao);
            DALobj.Alterar(modelo);
        }

        //METODO EXCLUIR
        public void Excluir(int idEndereco)
        {
            DAL_Endereco DALobj = new DAL_Endereco(conexao);
            DALobj.Excluir(idEndereco);
        }

        //METODO CARRREGA MODELO
        public Model_Endereco CarregaModeloEndereco(int idEndereco)
        {
            DAL_Endereco DALobj = new DAL_Endereco(conexao);
            return DALobj.CarregaModeloEndereco(idEndereco);
        }


        //METODO LOCALIZAR
        public DataTable Localizar(String valor)
        {
            DAL_Endereco DALobj = new DAL_Endereco(conexao);
            return DALobj.Localizar(valor);
        }
    }
}
