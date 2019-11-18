using DAL;
using Modelo;
using SistemaVendas;
using System;
using System.Data;

namespace BLL
{
    public class BLL_Endereco
    {
        private DAO_Conexao conexao;

        public BLL_Endereco(DAO_Conexao con)
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


            DAO_Endereco DALobj = new DAO_Endereco(conexao);
            DALobj.Incluir(modelo);
        }

      

        //METODO CARRREGA MODELO
        public Model_Endereco CarregaModeloEndereco(string cep)
        {
            DAO_Endereco DALobj = new DAO_Endereco(conexao);
            return DALobj.CarregaModeloEndereco(cep);
        }


        //METODO LOCALIZAR
        public DataTable Localizar(String valor)
        {
            DAO_Endereco DALobj = new DAO_Endereco(conexao);
            return DALobj.Localizar(valor);
        }
    }
}
