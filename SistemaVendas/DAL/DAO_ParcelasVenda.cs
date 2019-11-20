using Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAO_ParcelasVenda
    {
        private DAO_Conexao conexao;
        public DAO_ParcelasVenda(DAO_Conexao con)
        {
            this.conexao = con;
        }

        //METODO INCLUIR
        public void Incluir(Model_ParcelasVenda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into ParcelasVenda (id_parcelasVenda, valor, dataPagto, dataVencimento, id_venda)" +
                "values (@id_parcelasVenda, @valor, @dataPagto, @dataVencimento, @id_venda);";
            cmd.Parameters.AddWithValue("@id_parcelasVenda", modelo.IdParcelasVenda);
            cmd.Parameters.AddWithValue("@valor", modelo.Valor);
            cmd.Parameters.AddWithValue("@id_venda", modelo.IdVenda);

            cmd.Parameters.Add("@dataPagto", System.Data.SqlDbType.Date);
            if (modelo.DataPagto == null)
            {
                cmd.Parameters["@dataPagto"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@dataPagto"].Value = modelo.DataPagto;
            }

            cmd.Parameters.Add("@dataVencimento", System.Data.SqlDbType.Date);
            if (modelo.DataVencimento == null)
            {
                cmd.Parameters["@dataVencimento"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@dataVencimento"].Value = modelo.DataVencimento;
            }

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        //METODO ALTERAR
        public void Alterar(Model_ParcelasVenda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE ParcelasVenda set valor = @valor, dataPagto = @dataPagto, dataVencimento = @dataVencimento" +
                "where id_parcelasVenda = @id_parcelasVenda and id_venda = @id_venda";
            cmd.Parameters.AddWithValue("@id_parcelasVenda", modelo.IdParcelasVenda);
            cmd.Parameters.AddWithValue("@valor", modelo.Valor);
            cmd.Parameters.AddWithValue("@id_venda", modelo.IdVenda);

            cmd.Parameters.Add("@dataPagto", System.Data.SqlDbType.Date);
            if (modelo.DataPagto == null)
            {
                cmd.Parameters["@dataPagto"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@dataPagto"].Value = modelo.DataPagto;
            }

            cmd.Parameters.Add("@dataVencimento", System.Data.SqlDbType.Date);
            if (modelo.DataVencimento == null)
            {
                cmd.Parameters["@dataVencimento"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@dataVencimento"].Value = modelo.DataVencimento;
            }

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        //METODO EXCLUIR
        public void Excluir(Model_ParcelasVenda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from ParcelasCompra where id_parcelasVenda = @id_parcelasVenda and id_venda = @id_venda";
            cmd.Parameters.AddWithValue("@id_parcelasVenda", modelo.IdParcelasVenda);
            cmd.Parameters.AddWithValue("@id_venda", modelo.IdVenda);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        //METODO EXCLUIR todas as parcelas
        public void ExcluirTodasParcelas(int idVenda)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from ParcelasVenda where id_venda = @id_venda";
            cmd.Parameters.AddWithValue("@id_venda", idVenda);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        //METODO CARREGA MODELO
        public Model_ParcelasVenda CarregaModeloParcelasVenda(int idParcelas, int idVenda)
        {
            Model_ParcelasVenda modelo = new Model_ParcelasVenda();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from ParcelasVenda where id_parcelasVenda = @id_parcelasVenda and id_venda = @id_venda";
            cmd.Parameters.AddWithValue("@id_parcelasVenda", idParcelas);
            cmd.Parameters.AddWithValue("@id_venda", idVenda);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            //SE EXITIR ALGUMA LINHA EXECUTAR
            if (registro.HasRows)
            {
                registro.Read();
                modelo.IdParcelasVenda = idParcelas;
                modelo.IdVenda = idVenda;
                modelo.DataPagto = Convert.ToDateTime(registro["dataPagto"]);
                modelo.DataVencimento = Convert.ToDateTime(registro["dataVencimento"]);
                modelo.Valor = Convert.ToDouble(registro["valor"]);
            }
            conexao.Desconectar();
            return modelo;
        }

        //METODO LOCALIZAR
        public DataTable Localizar(int idVenda)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = default(SqlDataAdapter);
            da = new SqlDataAdapter("Select * from ParcelasVenda where id_venda =" + idVenda.ToString(), conexao.StringConexao);
            da.Fill(dt);
            return dt;
        }

        //METODO LOCALIZAR por data
        public DataTable LocalizarPertoVencimento(DateTime inicial, DateTime final)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select id_venda, dataVencimento, valor, dataPagto from ParcelasVenda" +
                " where dataVencimento BETWEEN @inicial and @final order by dataVencimento";

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


        //RECEBIMENTO VENDA
        public void RecebimentoParcela(int idVenda, int idParcelaVenda, DateTime dtPagto)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE ParcelasVenda set dataPagto = @dataPagto where id_parcelasVenda = @id_parcelasVenda and id_venda = @id_venda";
            cmd.Parameters.AddWithValue("@id_parcelasVenda", idParcelaVenda);
            cmd.Parameters.AddWithValue("@id_venda", idVenda);
            cmd.Parameters.Add("@dataPagto", System.Data.SqlDbType.Date);
            cmd.Parameters["@dataPagto"].Value = dtPagto.Date;
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
    }
}
