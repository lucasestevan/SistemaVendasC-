using DAL;
using Modelo;
using System;
using System.Data;

namespace BLL
{
    public class BLL_TipoPagamento
    {
        private DAO_Conexao conexao;

        public BLL_TipoPagamento(DAO_Conexao con)
        {
            this.conexao = con;
        }

        //METODO INCLUIR
        public void Incluir(Model_TipoPagamento modelo)
        {
            //VERIFICAR SE O CAMPO NÃO É VAZIO
            if (modelo.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do Tipo de pagamento é obrigatorio");
            }

            DAO_TipoPagamento DALobj = new DAO_TipoPagamento(conexao);
            DALobj.Incluir(modelo);
        }

        //METODO ALTERAR
        public void Alterar(Model_TipoPagamento modelo)
        {
            //VERIFICAR SE O CAMPO NÃO É VAZIO
            if (modelo.IdTipoPagamento <= 0)
            {
                throw new Exception("O codigo do tipo de pagamento é obrigatorio");
            }
            if (modelo.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do tipo de pagamento é obrigatorio");
            }

            DAO_TipoPagamento DALobj = new DAO_TipoPagamento(conexao);
            DALobj.Alterar(modelo);
        }

        //METODO EXCLUIR
        public void Excluir(int idTipoPagamento)
        {
            DAO_TipoPagamento DALobj = new DAO_TipoPagamento(conexao);
            DALobj.Excluir(idTipoPagamento);
        }

        //METODO CARRREGA MODELO 
        public Model_TipoPagamento CarregaModeloTipoPagto(int idTipoPagto)
        {
            DAO_TipoPagamento DALobj = new DAO_TipoPagamento(conexao);
            return DALobj.CarregaModeloTipoPag(idTipoPagto);
        }

        //METODO LOCALIZAR
        public DataTable Localizar(String valor)
        {
            DAO_TipoPagamento DALobj = new DAO_TipoPagamento(conexao);
            return DALobj.Localizar(valor);
        }
    }
}
