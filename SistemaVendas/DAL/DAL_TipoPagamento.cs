using Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_TipoPagamento
    {
        private DAL_Conexao conexao;
        public DAL_TipoPagamento(DAL_Conexao con)
        {
            this.conexao = con;
        }

        //METODO INCLUIR
        public void Incluir(Model_TipoPagamento modelo)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into TipoPagamento (nome) values (@nome); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", modelo.nome);
            conexao.Conectar();
            modelo.idTipoPagamento = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        //METODO ALTERAR
        public void Alterar(Model_TipoPagamento modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update TipoPagamento set nome = @nome where id_tipoPagamento = @id_tipoPagamento";
            cmd.Parameters.AddWithValue("@id_tipoPagamento", modelo.idTipoPagamento);
            cmd.Parameters.AddWithValue("@nome", modelo.nome);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        //METODO EXCLUIR
        public void Excluir(int idTipoPagamento)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from TipoPagamento where id_tipoPagamento = @id_tipoPagamento";
            cmd.Parameters.AddWithValue("@id_tipoPagamento", idTipoPagamento);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        //METODO LOCALIZAR
        public DataTable Localizar(String valor)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = default(SqlDataAdapter);
            da = new SqlDataAdapter("SELECT * FROM TipoPagamento where nome like '%" + valor + "%' order by nome", conexao.StringConexao);
            da.Fill(dt);
            return dt;
        }
    }
}
