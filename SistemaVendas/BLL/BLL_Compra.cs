using DAL;
using Modelo;
using System;
using System.Data;

namespace BLL
{
    public class BLL_Compra
    {
        private DAL_Conexao conexao;

        public BLL_Compra(DAL_Conexao con)
        {
            this.conexao = con;
        }

        //METODO INCLUIR
        public void Incluir(Model_Compra modelo)
        {
            //VERIFICAR SE O CAMPO NÃO É VAZIO
            if (modelo.total <= 0)
            {
                throw new Exception("o Valor da compra deve ser informado");
            }

            if (modelo.idTipoPagamento <= 0)
            {
                throw new Exception("O tipo de pagamento é obrigatorio!");
            }

            if (modelo.idFornecedor <= 0)
            {
                throw new Exception("O Fornecedor é obrigatorio");
            }

            if (modelo.nParcelas <= 0)
            {
                throw new Exception("O Número de parcelas dever ser maior que zero");
            }

            DAL_Compra DALobj = new DAL_Compra(conexao);
            DALobj.Incluir(modelo);
        }

        //METODO ALTERAR
        public void Alterar(Model_Compra modelo)
        {
            //VERIFICAR SE O CAMPO NÃO É VAZIO
            if (modelo.idCompra <= 0)
            {
                throw new Exception("o código da compra deve ser informado");
            }

            if (modelo.total <= 0)
            {
                throw new Exception("o Valor da compra deve ser informado");
            }

            if (modelo.idTipoPagamento <= 0)
            {
                throw new Exception("O tipo de pagamento é obrigatorio!");
            }

            if (modelo.idFornecedor <= 0)
            {
                throw new Exception("O Fornecedor é obrigatorio");
            }

            if (modelo.nParcelas <= 0)
            {
                throw new Exception("O Número de parcelas dever ser maior que zero");
            }

            DAL_Compra DALobj = new DAL_Compra(conexao);
            DALobj.Alterar(modelo);
        }

        //METODO PAGAR CONTA
        public void PagarConta(Model_Compra modelo)
        {
            DAL_Compra DALobj = new DAL_Compra(conexao);
            DALobj.PagarConta(modelo);
        }

        //METODO ESTORNAR CONTA
        public void EstornarConta(Model_Compra modelo)
        {
            DAL_Compra DALobj = new DAL_Compra(conexao);
            DALobj.EstornarConta(modelo);
        }

        //METODO EXCLUIR
        public void Excluir(int idCompra)
        {
            DAL_Compra DALobj = new DAL_Compra(conexao);
            DALobj.Excluir(idCompra);
        }


        //METODO CARRREGA MODELO COMPRA
        public Model_Compra CarregaModeloCompra(int idCompra)
        {
            DAL_Compra DALobj = new DAL_Compra(conexao);
            return DALobj.CarregaModeloCompra(idCompra);
        }


        //METODO LOCALIZAR GERAL
        public DataTable LocalizarGeral()
        {
            DAL_Compra DALobj = new DAL_Compra(conexao);
            return DALobj.LocalizarGeral();
        }

        //METODO LOCALIZAR PELO IDCOMPRA
        public DataTable localizarIdCompra(int idCompra)
        {
            DAL_Compra DALobj = new DAL_Compra(conexao);
            return DALobj.LocalizaridCompra(idCompra);
        }

        //METODO LOCALIZAR NOME
        public DataTable LocalizarNome(String nome)
        {
            DAL_Compra DALobj = new DAL_Compra(conexao);
            return DALobj.LocalizarNome(nome);
        }

        //METODO LOCALIZAR DATA
        public DataTable LocalizarData(DateTime inicial, DateTime final)
        {
            DAL_Compra DALobj = new DAL_Compra(conexao);
            return DALobj.LocalizarData(inicial, final);
        }
    }
}
