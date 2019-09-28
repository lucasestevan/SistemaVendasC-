using Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_Cliente
    {
        private DAL_Conexao conexao;
        public DAL_Cliente(DAL_Conexao con)
        {
            this.conexao = con;
        }

        //METODO INCLUIR
        public void Incluir(Model_Cliente modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into Cliente (nome, cpf, telefone, celular, email, observacao, id_endereco, numeroEnde)" +
                "values (@nome, @cpf, @telefone, @celular, @email, @observacao, @id_endereco, @numeroEnde); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", modelo.nome);
            cmd.Parameters.AddWithValue("@cpf", modelo.cpf);
            cmd.Parameters.AddWithValue("@telefone", modelo.telefone);
            cmd.Parameters.AddWithValue("@celular", modelo.celular);
            cmd.Parameters.AddWithValue("@email", modelo.email);
            cmd.Parameters.AddWithValue("@observacao", modelo.observacao);
            cmd.Parameters.AddWithValue("@id_endereco", modelo.idEndereco);
            cmd.Parameters.AddWithValue("@numeroEnde", modelo.numeroEnde);
            conexao.Conectar();
            modelo.idCliente = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        //METODO ALTERAR
        public void Alterar(Model_Cliente modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE Cliente set nome = @nome, cpf = @cpf, telefone = @telefone, celular = @celular, email = @email,"+
                "observacao = @observacao, id_endereco = @id_endereco, numeroEnde = @numeroEnde where id_cliente = @id_cliente";
            cmd.Parameters.AddWithValue("@id_cliente", modelo.idCliente);
            cmd.Parameters.AddWithValue("@nome", modelo.nome);
            cmd.Parameters.AddWithValue("@cpf", modelo.cpf);
            cmd.Parameters.AddWithValue("@telefone", modelo.telefone);
            cmd.Parameters.AddWithValue("@celular", modelo.celular);
            cmd.Parameters.AddWithValue("@email", modelo.email);
            cmd.Parameters.AddWithValue("@observacao", modelo.observacao);
            cmd.Parameters.AddWithValue("@id_endereco", modelo.idEndereco);
            cmd.Parameters.AddWithValue("@numeroEnde", modelo.numeroEnde);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        //METODO EXCLUIR
        public void Excluir(int idCliente)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from Cliente where id_cliente = @id_cliente";
            cmd.Parameters.AddWithValue("@id_cliente", idCliente);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        //METODO LOCALIZAR
        public DataTable Localizar(String valor)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = default(SqlDataAdapter);
            da = new SqlDataAdapter("Select cli.id_cliente, cli.nome, cli.cpf, cli.telefone, cli.celular, cli.email, cli.observacao, cli.id_endereco, Ende.cep, ende.rua, cli.numeroEnde, ende.bairro, Ende.cidade, Ende.uf from Cliente as Cli INNER JOIN Endereco as Ende on cli.id_endereco = Ende.id_endereco where nome like '%" + valor + "%' order by nome", conexao.StringConexao);
            da.Fill(dt);
            return dt;
        }
    }
}
