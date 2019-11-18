using DAL;
using Modelo;
using System;
using System.Data;

namespace BLL
{
    public class BLL_Colaborador
    {
        private DAO_Conexao conexao;

        public BLL_Colaborador(DAO_Conexao con)
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


            DAO_Colaborador DALobj = new DAO_Colaborador(conexao);
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

            DAO_Colaborador DALobj = new DAO_Colaborador(conexao);
            DALobj.Alterar(modelo);
        }

        //METODO EXCLUIR
        public void Excluir(int idColaborador)
        {
            DAO_Colaborador DALobj = new DAO_Colaborador(conexao);
            DALobj.Excluir(idColaborador);
        }

        //METODO CARRREGA MODELO
        public Model_Colaborador CarregaModeloColaborador(int idColaborador)
        {
            DAO_Colaborador DALobj = new DAO_Colaborador(conexao);
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

            DAO_Colaborador DALobj = new DAO_Colaborador(conexao);
            DALobj.ApagarSenha(modelo);
        }


        //METODO LOCALIZAR
        public DataTable Localizar(String valor)
        {
            DAO_Colaborador DALobj = new DAO_Colaborador(conexao);
            return DALobj.Localizar(valor);
        }
    }
}
