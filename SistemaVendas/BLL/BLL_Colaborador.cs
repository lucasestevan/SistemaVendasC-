using DAL;
using Modelo;
using System;
using System.Data;

namespace BLL
{
    public class BLL_Colaborador
    {
        private DAL_Conexao conexao;

        public BLL_Colaborador(DAL_Conexao con)
        {
            this.conexao = con;
        }

        //METODO INCLUIR
        public void Incluir(Model_Colaborador modelo)
        {
            //VERIFICAR SE O CAMPO NÃO É VAZIO
            if (modelo.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do Colaborador é obrigatorio");
            }

            if (modelo.Senha.Trim().Length == 0)
            {
                throw new Exception("o Campo senha é obrigatorio");
            }

            if (modelo.Cpf.Trim().Length == 0)
            {
                throw new Exception("O CPF do Colaborador é obrigatorio");
            }


            DAL_Colaborador DALobj = new DAL_Colaborador(conexao);
            DALobj.Incluir(modelo);
        }

        //METODO ALTERAR
        public void Alterar(Model_Colaborador modelo)
        {
            //VERIFICAR SE O CAMPO NÃO É VAZIO
            if (modelo.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do Colaborador é obrigatorio");
            }

            if (modelo.Cpf.Trim().Length == 0)
            {
                throw new Exception("O CPF do Colaborador é obrigatorio");
            }

            DAL_Colaborador DALobj = new DAL_Colaborador(conexao);
            DALobj.Alterar(modelo);
        }

        //METODO EXCLUIR
        public void Excluir(int idColaborador)
        {
            DAL_Colaborador DALobj = new DAL_Colaborador(conexao);
            DALobj.Excluir(idColaborador);
        }

        //METODO CARRREGA MODELO
        public Model_Colaborador CarregaModeloColaborador(int idColaborador)
        {
            DAL_Colaborador DALobj = new DAL_Colaborador(conexao);
            return DALobj.CarregaModeloColaborador(idColaborador);
        }


        //METODO APAGAR SENHA
        public void ApagarSenha(Model_Colaborador modelo)
        {
            //VERIFICAR SE O CAMPO NÃO É VAZIO
            if (modelo.IdColaborador <= 0)
            {
                throw new Exception("Selecione o Colaborador");
            }

            DAL_Colaborador DALobj = new DAL_Colaborador(conexao);
            DALobj.ApagarSenha(modelo);
        }


        //METODO LOCALIZAR
        public DataTable Localizar(String valor)
        {
            DAL_Colaborador DALobj = new DAL_Colaborador(conexao);
            return DALobj.Localizar(valor);
        }
    }
}
