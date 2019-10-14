using Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_ParcelasVenda
    {
        private DAL_Conexao conexao;
        public DAL_ParcelasVenda(DAL_Conexao con)
        {
            this.conexao = con;
        }

        //METODO INCLUIR
        public void Incluir(Model_ParcelasVenda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into ParcelasVenda (id_parcelasVenda, valor, dataVencimento, id_venda)" +
                "values (@id_parcelasVenda, @valor, @dataVencimento, @id_venda);";
            cmd.Parameters.AddWithValue("@id_parcelasVenda", modelo.IdParcelasVenda);
            cmd.Parameters.AddWithValue("@valor", modelo.Valor);
            cmd.Parameters.AddWithValue("@id_venda", modelo.IdVenda);

            cmd.Parameters.Add("@dataVencimento", System.Data.SqlDbType.Date);
            if (modelo.DataPagto == null)
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
            cmd.Parameters["@dataVencimento"].Value = modelo.DataVencimento;

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
            cmd.CommandText = "delete from ParcelasCompra where id_venda = @id_venda";
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
    }
}
