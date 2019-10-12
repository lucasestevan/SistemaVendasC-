using Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_Categoria
    {
        private DAL_Conexao conexao;
        public DAL_Categoria(DAL_Conexao con)
        {
            this.conexao = con;
        }

        //METODO INCLUIR
        public void Incluir(Model_Categoria modelo)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into Categoria (nome) values (@nome); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", modelo.Nome);
            conexao.Conectar();
            modelo.Id_categoria = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }


        //METODO ALTERAR
        public void Alterar(Model_Categoria modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update Categoria set nome = @nome where id_categoria = @id_categoria";
            cmd.Parameters.AddWithValue("@id_categoria", modelo.Id_categoria);
            cmd.Parameters.AddWithValue("@nome", modelo.Nome);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        //METODO EXCLUIR
        public void Excluir(int idCategoria)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from Categoria where id_categoria = @id_categoria";
            cmd.Parameters.AddWithValue("@id_categoria", idCategoria);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        //METODO CARREGA MODELO
        public Model_Categoria CarregaModeloCategoria(int idCategoria)
        {
            Model_Categoria modelo = new Model_Categoria();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from Categoria where id_categoria = @id_categoria";
            cmd.Parameters.AddWithValue("@id_categoria", idCategoria);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            //SE EXITIR ALGUMA LINHA EXECUTAR
            if (registro.HasRows)
            {
                registro.Read();
                modelo.Id_categoria = Convert.ToInt32(registro["id_categoria"]);
                modelo.Nome = Convert.ToString(registro["nome"]);
            }
            conexao.Desconectar();
            return modelo;
        }

        //METODO LOCALIZAR
        public DataTable Localizar(String valor)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = default(SqlDataAdapter);
            da = new SqlDataAdapter("SELECT * FROM Categoria where nome like '%" + valor + "%' order by nome", conexao.StringConexao);
            da.Fill(dt);
            return dt;
        }

        //METODO VERIFICA SE EXISTE
        public int VerificaSeExiste(String valor)
        {
            int r = 0; //SE FOR 0 - NÃO EXISTE NO BD
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Select * from Categoria where nome = @nome";
            cmd.Parameters.AddWithValue("@nome", valor);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                r = Convert.ToInt32(registro["idcodigo"]);
            }
            return r;
        }

    }
}
