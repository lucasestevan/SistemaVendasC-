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
                       
            if (modelo.Rua.Trim().Length == 0)
            {
                throw new Exception("O campo Rua é obrigatorio!");
            }

            if (modelo.Bairro.Trim().Length == 0)
            {
                throw new Exception("O Campo Bairro é obrigatorio!");
            }

            //valida cep

            if (Validacao.ValidaCep(modelo.Cep) == false)
            {
                throw new Exception("O Cep é invalido!");
            }



            DAL_Endereco DALobj = new DAL_Endereco(conexao);
            DALobj.Incluir(modelo);
        }

      

        //METODO CARRREGA MODELO
        public Model_Endereco CarregaModeloEndereco(string cep)
        {
            DAL_Endereco DALobj = new DAL_Endereco(conexao);
            return DALobj.CarregaModeloEndereco(cep);
        }


        //METODO LOCALIZAR
        public DataTable Localizar(String valor)
        {
            DAL_Endereco DALobj = new DAL_Endereco(conexao);
            return DALobj.Localizar(valor);
        }
    }
}
