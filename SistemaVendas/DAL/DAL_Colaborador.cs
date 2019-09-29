using Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_Colaborador
    {
        private DAL_Conexao conexao;
        public DAL_Colaborador(DAL_Conexao con)
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
            cmd.Parameters.AddWithValue("@nome", modelo.nome);
            cmd.Parameters.AddWithValue("@cpf", modelo.cpf);
            cmd.Parameters.AddWithValue("@senha", modelo.senha);
            cmd.Parameters.AddWithValue("@telefone", modelo.telefone);
            cmd.Parameters.AddWithValue("@celular", modelo.celular);
            cmd.Parameters.AddWithValue("@descricao", modelo.descricao);
            conexao.Conectar();
            modelo.idColaborador = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        //METODO ALTERAR
        public void Alterar(Model_Colaborador modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE Colaborador set nome = @nome, cpf = @cpf, telefone = @telefone, celular = @celular," +
                "descricao = @descricao where id_colaborador = @id_colaborador";
            cmd.Parameters.AddWithValue("@id_colaborador", modelo.idColaborador);
            cmd.Parameters.AddWithValue("@nome", modelo.nome);
            cmd.Parameters.AddWithValue("@cpf", modelo.cpf);
            cmd.Parameters.AddWithValue("@telefone", modelo.telefone);
            cmd.Parameters.AddWithValue("@celular", modelo.celular);
            cmd.Parameters.AddWithValue("@descricao", modelo.descricao);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
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
            cmd.Parameters.AddWithValue("@id_colaborador", modelo.idColaborador);
            cmd.Parameters.AddWithValue("@senha", modelo.senha);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

    }
}
