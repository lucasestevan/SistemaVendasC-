using Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAO_Colaborador
    {
        private DAO_Conexao conexao;
        public DAO_Colaborador(DAO_Conexao con)
        {
            this.conexao = con;
        }

        //METODO INCLUIR
        public void Incluir(Model_Colaborador modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into Colaborador (nome, cpf, senha, telefone, celular, descricao)" +
                "values (@nome, @cpf, HASHBYTES('md2', @senha), @telefone, @celular, @descricao); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@cpf", modelo.Cpf);
            cmd.Parameters.AddWithValue("@senha", modelo.Senha);
            cmd.Parameters.AddWithValue("@telefone", modelo.Telefone);
            cmd.Parameters.AddWithValue("@celular", modelo.Celular);
            cmd.Parameters.AddWithValue("@descricao", modelo.Descricao);
            conexao.Conectar();
            modelo.IdColaborador = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        //METODO ALTERAR
        public void Alterar(Model_Colaborador modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE Colaborador set nome = @nome, cpf = @cpf, telefone = @telefone, celular = @celular," +
                "descricao = @descricao where id_colaborador = @id_colaborador";
            cmd.Parameters.AddWithValue("@id_colaborador", modelo.IdColaborador);
            cmd.Parameters.AddWithValue("@nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@cpf", modelo.Cpf);
            cmd.Parameters.AddWithValue("@telefone", modelo.Telefone);
            cmd.Parameters.AddWithValue("@celular", modelo.Celular);
            cmd.Parameters.AddWithValue("@descricao", modelo.Descricao);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        //METODO CARREGA MODELO
        public Model_Colaborador CarregaModeloColaborador(int idColaborador)
        {
            Model_Colaborador modelo = new Model_Colaborador();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from Colaborador where id_colaborador = @id_colaborador";
            cmd.Parameters.AddWithValue("@id_colaborador", idColaborador);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            //SE EXITIR ALGUMA LINHA EXECUTAR
            if (registro.HasRows)
            {
                registro.Read();
                modelo.IdColaborador = Convert.ToInt32(registro["id_colaborador"]);
                modelo.Nome = Convert.ToString(registro["nome"]);
                modelo.Cpf = Convert.ToString(registro["cpf"]);
                modelo.Senha = Convert.ToString(registro["senha"]);
                modelo.Telefone = Convert.ToString(registro["telefone"]);
                modelo.Celular = Convert.ToString(registro["celular"]);
                modelo.Descricao = Convert.ToString(registro["descricao"]);
            }
            conexao.Desconectar();
            return modelo;
        }

        //METODO EXCLUIR
        public void Excluir(int idColaborador)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from Colaborador where id_colaborador = @id_colaborador";
            cmd.Parameters.AddWithValue("@id_colaborador", idColaborador);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        //METODO LOCALIZAR
        public DataTable Localizar(String valor)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = default(SqlDataAdapter);
            da = new SqlDataAdapter("Select * from Colaborador where nome like '%" + valor + "%' order by nome", conexao.StringConexao);
            da.Fill(dt);
            return dt;
        }

        //METODO apagar Senha
        public void ApagarSenha(Model_Colaborador modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE Colaborador set senha = HASHBYTES('md2', @senha) where id_colaborador = @id_colaborador";
            cmd.Parameters.AddWithValue("@id_colaborador", modelo.IdColaborador);
            cmd.Parameters.AddWithValue("@senha", modelo.Senha);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

    }
}
