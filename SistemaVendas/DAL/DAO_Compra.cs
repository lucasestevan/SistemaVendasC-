﻿using Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAO_Compra
    {
        private DAO_Conexao conexao;
        public DAO_Compra(DAO_Conexao con)
        {
            this.conexao = con;
        }

        //METODO INCLUIR
        public void Incluir(Model_Compra modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into Compra (dataCompra, nfiscal, total, nparcelas, compraStatus, id_fornecedor, id_tipoPagamento)" +
                "values (@dataCompra, @nfiscal, @total, @nparcelas, @compraStatus, @id_fornecedor, @id_tipoPagamento); select @@IDENTITY;";
            cmd.Parameters.Add("@dataCompra", System.Data.SqlDbType.DateTime); //data
            cmd.Parameters["@dataCompra"].Value = modelo.DataCompra; //data
            cmd.Parameters.AddWithValue("@nfiscal", modelo.NFiscal);
            cmd.Parameters.AddWithValue("@total", modelo.Total);
            cmd.Parameters.AddWithValue("@nparcelas", modelo.NParcelas);
            cmd.Parameters.AddWithValue("@compraStatus", modelo.CompraStatus);
            cmd.Parameters.AddWithValue("@id_fornecedor", modelo.IdFornecedor);
            cmd.Parameters.AddWithValue("@id_tipoPagamento", modelo.IdTipoPagamento);
            conexao.Conectar();
            modelo.IdCompra = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        //METODO ALTERAR
        public void Alterar(Model_Compra modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE Compra set dataCompra = @dataCompra, nfiscal = @nfiscal, total = @total, nparcelas = @nparcelas, compraStatus = @compraStatus," +
                "id_fornecedor = @id_fornecedor, id_tipoPagamento = @id_tipoPagamento where id_compra = @id_compra";
            cmd.Parameters.AddWithValue("@id_compra", modelo.IdCompra);
            cmd.Parameters.Add("@dataCompra", System.Data.SqlDbType.DateTime); //data
            cmd.Parameters["@dataCompra"].Value = modelo.DataCompra; //data
            cmd.Parameters.AddWithValue("@nfiscal", modelo.NFiscal);
            cmd.Parameters.AddWithValue("@total", modelo.Total);
            cmd.Parameters.AddWithValue("@nparcelas", modelo.NParcelas);
            cmd.Parameters.AddWithValue("@compraStatus", modelo.CompraStatus);
            cmd.Parameters.AddWithValue("@id_fornecedor", modelo.IdFornecedor);
            cmd.Parameters.AddWithValue("@id_tipoPagamento", modelo.IdTipoPagamento);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        //METODO PAGAR CONTA
        public void PagarConta(Model_Compra modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE Compra set compraStatus = @compraStatus where id_compra = @id_compra";
            cmd.Parameters.AddWithValue("@id_compra", modelo.IdCompra);
            cmd.Parameters.AddWithValue("@compraStatus", modelo.CompraStatus);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        //METODO CANCELAR COMPRA
        public Boolean EstornarConta(int idCompra)
        {
            Boolean retorno = true;
            //ATUALIZAR TABELA DE VENDA
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            conexao.Conectar();

            try
            {
                cmd.CommandText = "UPDATE Compra set CompraStatus = 'CANCELADO' where id_compra = @id_compra";
                cmd.Parameters.AddWithValue("@id_compra", idCompra);
                cmd.ExecuteNonQuery();

                //INCLEMENTEAR O ESTOQUE COM OS ITENS DA VENDA CANCELADA

                //LOCALIZAR OS ITENS DA VENDA
                DataTable dt = new DataTable();
                SqlDataAdapter da = default(SqlDataAdapter);
                da = new SqlDataAdapter("Select id_itensCompra, quantidade, id_produto from ItensCompra where id_compra = " + idCompra.ToString(), conexao.StringConexao);
                da.Fill(dt);

                //alterar a quantisdade do estoque
                Model_Produto produto;
                DAO_Conexao cxPL = new DAO_Conexao(DadoConexao.StringDeConexao);
                DAO_Produto dalProduto = new DAO_Produto(cxPL);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    produto = dalProduto.CarregaModeloProduto(Convert.ToInt32(dt.Rows[i]["id_produto"]));
                    produto.Quantidade = produto.Quantidade - Convert.ToDouble(dt.Rows[i]["quantidade"]);
                    dalProduto.Alterar(produto, true);
                }
                conexao.Desconectar();
            }
            catch (Exception)
            {
                retorno = false;
                conexao.Desconectar();
            }
            return retorno;
        }

        //METODO EXCLUIR
        public void Excluir(int idCompra)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from Compra where id_compra = @id_compra";
            cmd.Parameters.AddWithValue("@id_compra", idCompra);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        //METODO CARREGA MODELO
        public Model_Compra CarregaModeloCompra(int id_compra)
        {
            Model_Compra modelo = new Model_Compra();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from Compra where id_compra = @id_compra";
            cmd.Parameters.AddWithValue("@id_compra", id_compra);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            //SE EXITIR ALGUMA LINHA EXECUTAR
            if (registro.HasRows)
            {
                registro.Read();
                modelo.IdCompra = Convert.ToInt32(registro["id_compra"]);
                modelo.DataCompra = Convert.ToDateTime(registro["dataCompra"]);
                modelo.NFiscal = Convert.ToInt32(registro["nFiscal"]);
                modelo.Total = Convert.ToDouble(registro["total"]);
                modelo.NParcelas = Convert.ToInt32(registro["nparcelas"]);
                modelo.CompraStatus = Convert.ToString(registro["compraStatus"]);
                modelo.IdFornecedor = Convert.ToInt32(registro["id_fornecedor"]);
                modelo.IdTipoPagamento = Convert.ToInt32(registro["id_tipoPagamento"]);
            }
            conexao.Desconectar();
            return modelo;
        }

            //METODO LOCALIZAR fgeral
            public DataTable LocalizarGeral()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = default(SqlDataAdapter);
            da = new SqlDataAdapter("select c.id_compra, c.dataCompra, c.nfiscal, c.nparcelas, c.total," +
                " c.compraStatus, c.id_fornecedor, c.id_tipoPagamento," +
                " f.nome from Compra as C inner join Fornecedor as f on c.id_fornecedor = f.id_fornecedor order by c.dataCompra desc", conexao.StringConexao);
            da.Fill(dt);
            return dt;
        }

        //METODO LOCALIZAR IDCOMPRA
        public DataTable LocalizaridCompra(string idCompra)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = default(SqlDataAdapter);
            da = new SqlDataAdapter("select c.id_compra, c.dataCompra, c.nfiscal, c.nparcelas, c.total," +
                " c.compraStatus, c.id_fornecedor, c.id_tipoPagamento," +
                " f.nome from Compra as C inner join Fornecedor as f on c.id_fornecedor = f.id_fornecedor where c.id_compra like '%" + idCompra + "%'", conexao.StringConexao);
            da.Fill(dt);
            return dt;
        }

        //METODO LOCALIZAR POR NOME DE FORCECEDOR
        public DataTable LocalizarNome(String nome)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = default(SqlDataAdapter);
            da = new SqlDataAdapter("select c.id_compra, c.dataCompra, c.nfiscal, c.nparcelas, c.total," +
                "  c.compraStatus, c.id_fornecedor, c.id_tipoPagamento," +
                " f.nome from Compra as C inner join Fornecedor as f on c.id_fornecedor = f.id_fornecedor where f.nome like '%" + nome + "%' order by c.dataCompra desc", conexao.StringConexao);
            da.Fill(dt);
            return dt;
        }

        //METODO LOCALIZAR por data
        public DataTable LocalizarData(DateTime inicial, DateTime final)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select c.id_compra, c.dataCompra, c.nfiscal, c.nparcelas, c.total," +
                "  c.compraStatus, c.id_fornecedor, c.id_tipoPagamento," +
                " f.nome from Compra as C inner join Fornecedor as f on c.id_fornecedor = f.id_fornecedor " +
                " where c.dataCompra BETWEEN @inicial and @final order by c.dataCompra desc";

            cmd.Parameters.Add("@inicial", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@inicial"].Value = inicial;

            cmd.Parameters.Add("@final", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@final"].Value = final;

            //conexao.Conectar();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            //conexao.Desconectar();
            return dt;
        }
    }
}
