using DAL;
using Modelo;
using System;
using System.Data;

namespace BLL
{
    public class BLL_Compra
    {
        private DAO_Conexao conexao;

        public BLL_Compra(DAO_Conexao con)
        {
            this.conexao = con;
        }

        //METODO INCLUIR
        public void Incluir(Model_Compra modelo)
        {
            //VERIFICAR SE O CAMPO NÃO É VAZIO
            if (modelo.Total <= 0)
            {
                throw new Exception("o Valor da compra deve ser informado");
            }

            if (modelo.IdTipoPagamento <= 0)
            {
                throw new Exception("O tipo de pagamento é obrigatorio!");
            }

            if (modelo.IdFornecedor <= 0)
            {
                throw new Exception("O Fornecedor é obrigatorio");
            }

            if (modelo.NParcelas <= 0)
            {
                throw new Exception("O Número de parcelas dever ser maior que zero");
            }

            DAO_Compra DALobj = new DAO_Compra(conexao);
            DALobj.Incluir(modelo);
        }

        //METODO ALTERAR
        public void Alterar(Model_Compra modelo)
        {
            //VERIFICAR SE O CAMPO NÃO É VAZIO
            if (modelo.IdCompra <= 0)
            {
                throw new Exception("o código da compra deve ser informado");
            }

            if (modelo.Total <= 0)
            {
                throw new Exception("o Valor da compra deve ser informado");
            }

            if (modelo.IdTipoPagamento <= 0)
            {
                throw new Exception("O tipo de pagamento é obrigatorio!");
            }

            if (modelo.IdFornecedor <= 0)
            {
                throw new Exception("O Fornecedor é obrigatorio");
            }

            if (modelo.NParcelas <= 0)
            {
                throw new Exception("O Número de parcelas dever ser maior que zero");
            }

            DAO_Compra DALobj = new DAO_Compra(conexao);
            DALobj.Alterar(modelo);
        }

        //METODO PAGAR CONTA
        public void PagarConta(Model_Compra modelo)
        {
            DAO_Compra DALobj = new DAO_Compra(conexao);
            DALobj.PagarConta(modelo);
        }

        //METODO ESTORNAR CONTA
        public void EstornarConta(int idVenda)
        {
            DAO_Compra DALobj = new DAO_Compra(conexao);
            DALobj.EstornarConta(idVenda);
        }

        //METODO EXCLUIR
        public void Excluir(int idCompra)
        {
            DAO_Compra DALobj = new DAO_Compra(conexao);
            DALobj.Excluir(idCompra);
        }


        //METODO CARRREGA MODELO COMPRA
        public Model_Compra CarregaModeloCompra(int idCompra)
        {
            DAO_Compra DALobj = new DAO_Compra(conexao);
            return DALobj.CarregaModeloCompra(idCompra);
        }


        //METODO LOCALIZAR GERAL
        public DataTable LocalizarGeral()
        {
            DAO_Compra DALobj = new DAO_Compra(conexao);
            return DALobj.LocalizarGeral();
        }

        //METODO LOCALIZAR PELO IDCOMPRA
        public DataTable localizarIdCompra(string idCompra)
        {
            DAO_Compra DALobj = new DAO_Compra(conexao);
            return DALobj.LocalizaridCompra(idCompra);
        }

        //METODO LOCALIZAR NOME
        public DataTable LocalizarNome(String nome)
        {
            DAO_Compra DALobj = new DAO_Compra(conexao);
            return DALobj.LocalizarNome(nome);
        }

        //METODO LOCALIZAR DATA
        public DataTable LocalizarData(DateTime inicial, DateTime final)
        {
            DAO_Compra DALobj = new DAO_Compra(conexao);
            return DALobj.LocalizarData(inicial, final);
        }
    }
}
