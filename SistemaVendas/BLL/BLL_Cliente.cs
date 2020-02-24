using DAL;
using Modelo;
using System;
using System.Data;

namespace BLL
{
    public class BLL_Cliente
    {
        private DAO_Conexao conexao;

        public BLL_Cliente(DAO_Conexao con)
        {
            this.conexao = con;
        }

        //METODO INCLUIR
        public void Incluir(Model_Cliente modelo)
        {
            //VERIFICAR SE O CAMPO NÃO É VAZIO
            if (modelo.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é obrigatorio");
            }

            if (modelo.Cpf.Trim().Length == 0)
            {
                throw new Exception("O CPF do cliente é obrigatorio");
            }


            DAO_Cliente DALobj = new DAO_Cliente(conexao);
            DALobj.Incluir(modelo);
        }

        //METODO ALTERAR
        public void Alterar(Model_Cliente modelo)
        {
            //VERIFICAR SE O CAMPO NÃO É VAZIO
            if (modelo.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é obrigatorio");
            }

            if (modelo.Cpf.Trim().Length == 0)
            {
                throw new Exception("O CPF do cliente é obrigatorio");
            }

            DAO_Cliente DALobj = new DAO_Cliente(conexao);
            DALobj.Alterar(modelo);
        }

        //METODO EXCLUIR
        public void Excluir(int idProduto)
        {
            DAO_Cliente DALobj = new DAO_Cliente(conexao);
            DALobj.Excluir(idProduto);
        }

        //METODO CARRREGA MODELO COMPRA
        public Model_Cliente CarregaModeloCliente(int idCliente)
        {
            DAO_Cliente DALobj = new DAO_Cliente(conexao);
            return DALobj.CarregaModeloCliente(idCliente);
        }


        //METODO LOCALIZAR
        public DataTable Localizar(String valor)
        {
            DAO_Cliente DALobj = new DAO_Cliente(conexao);
            return DALobj.Localizar(valor);
        }

        public bool IsCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            cpf = cpf.Trim().Replace(",", "").Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;

            for (int j = 0; j < 10; j++)
                if (j.ToString().PadLeft(11, char.Parse(j.ToString())) == cpf)
                    return false;

            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            int resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
        }
    }
}
