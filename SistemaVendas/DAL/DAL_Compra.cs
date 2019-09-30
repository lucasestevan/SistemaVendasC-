using Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_Compra
    {
        private DAL_Conexao conexao;
        public DAL_Compra(DAL_Conexao con)
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
            cmd.Parameters["@dataCompra"].Value = modelo.dataCompra; //data
            cmd.Parameters.AddWithValue("@nfiscal", modelo.nFiscal);
            cmd.Parameters.AddWithValue("@total", modelo.total);
            cmd.Parameters.AddWithValue("@nparcelas", modelo.nParcelas);
            cmd.Parameters.AddWithValue("@compraStatus", modelo.CompraStatus);
            cmd.Parameters.AddWithValue("@id_fornecedor", modelo.idFornecedor);
            cmd.Parameters.AddWithValue("@id_tipoPagamento", modelo.idTipoPagamento);
            conexao.Conectar();
            modelo.idCompra = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        //METODO ALTERAR
        public void Alterar(Model_Compra modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE Cliente set dataCompra = @dataCompra, nfiscal = @nfiscal, total = @total, nparcelas = @nparcelas, compraStatus = @compraStatus," +
                "id_fornecedor = @id_fornecedor, id_tipoPagamento = @id_tipoPagamento where id_compra = @id_compra";
            cmd.Parameters.AddWithValue("@id_compra", modelo.idCompra);
            cmd.Parameters.Add("@dataCompra", System.Data.SqlDbType.DateTime); //data
            cmd.Parameters["@dataCompra"].Value = modelo.dataCompra; //data
            cmd.Parameters.AddWithValue("@nfiscal", modelo.nFiscal);
            cmd.Parameters.AddWithValue("@total", modelo.total);
            cmd.Parameters.AddWithValue("@nparcelas", modelo.nParcelas);
            cmd.Parameters.AddWithValue("@compraStatus", modelo.CompraStatus);
            cmd.Parameters.AddWithValue("@id_fornecedor", modelo.idFornecedor);
            cmd.Parameters.AddWithValue("@id_tipoPagamento", modelo.idTipoPagamento);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
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

        //METODO LOCALIZAR
        public DataTable LocalizarPorFonecedor(int codigo)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = default(SqlDataAdapter);
            da = new SqlDataAdapter("select * Compra where id_fornecedor = " + codigo.ToString(), conexao.StringConexao);
            da.Fill(dt);
            return dt;
        }
    }
}
