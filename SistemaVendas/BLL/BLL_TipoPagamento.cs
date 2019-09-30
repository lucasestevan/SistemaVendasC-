using DAL;
using Modelo;
using System;
using System.Data;

namespace BLL
{
    public class BLL_TipoPagamento
    {
        private DAL_Conexao conexao;

        public BLL_TipoPagamento(DAL_Conexao con)
        {
            this.conexao = con;
        }

        //METODO INCLUIR
        public void Incluir(Model_TipoPagamento modelo)
        {
            //VERIFICAR SE O CAMPO NÃO É VAZIO
            if (modelo.nome.Trim().Length == 0)
            {
                throw new Exception("O nome do Tipo de pagamento é obrigatorio");
            }

            DAL_TipoPagamento DALobj = new DAL_TipoPagamento(conexao);
            DALobj.Incluir(modelo);
        }

        //METODO ALTERAR
        public void Alterar(Model_TipoPagamento modelo)
        {
            //VERIFICAR SE O CAMPO NÃO É VAZIO
            if (modelo.idTipoPagamento <= 0)
            {
                throw new Exception("O codigo do tipo de pagamento é obrigatorio");
            }
            if (modelo.nome.Trim().Length == 0)
            {
                throw new Exception("O nome do tipo de pagamento é obrigatorio");
            }

            DAL_TipoPagamento DALobj = new DAL_TipoPagamento(conexao);
            DALobj.Alterar(modelo);
        }

        //METODO EXCLUIR
        public void Excluir(int idTipoPagamento)
        {
            DAL_TipoPagamento DALobj = new DAL_TipoPagamento(conexao);
            DALobj.Excluir(idTipoPagamento);
        }

        //METODO LOCALIZAR
        public DataTable Localizar(String valor)
        {
            DAL_TipoPagamento DALobj = new DAL_TipoPagamento(conexao);
            return DALobj.Localizar(valor);
        }
    }
}
