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
            cmd.Parameters.AddWithValue("@nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@cpf", modelo.Cpf);
            cmd.Parameters.AddWithValue("@telefone", modelo.Telefone);
            cmd.Parameters.AddWithValue("@celular", modelo.Celular);
            cmd.Parameters.AddWithValue("@email", modelo.Email);
            cmd.Parameters.AddWithValue("@observacao", modelo.Observacao);
            cmd.Parameters.AddWithValue("@id_endereco", modelo.IdEndereco);
            cmd.Parameters.AddWithValue("@numeroEnde", modelo.NumeroEnde);
            conexao.Conectar();
            modelo.IdCliente = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        //METODO ALTERAR
        public void Alterar(Model_Cliente modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE Cliente set nome = @nome, cpf = @cpf, telefone = @telefone, celular = @celular, email = @email," +
                "observacao = @observacao, id_endereco = @id_endereco, numeroEnde = @numeroEnde where id_cliente = @id_cliente";
            cmd.Parameters.AddWithValue("@id_cliente", modelo.IdCliente);
            cmd.Parameters.AddWithValue("@nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@cpf", modelo.Cpf);
            cmd.Parameters.AddWithValue("@telefone", modelo.Telefone);
            cmd.Parameters.AddWithValue("@celular", modelo.Celular);
            cmd.Parameters.AddWithValue("@email", modelo.Email);
            cmd.Parameters.AddWithValue("@observacao", modelo.Observacao);
            cmd.Parameters.AddWithValue("@id_endereco", modelo.IdEndereco);
            cmd.Parameters.AddWithValue("@numeroEnde", modelo.NumeroEnde);
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

        //METODO CARREGA MODELO
        public Model_Cliente CarregaModeloCliente(int idCliente)
        {
            Model_Cliente modelo = new Model_Cliente();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from Cliente where id_cliente = @id_cliente";
            cmd.Parameters.AddWithValue("@id_cliente", idCliente);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            //SE EXITIR ALGUMA LINHA EXECUTAR
            if (registro.HasRows)
            {
                registro.Read();
                modelo.IdCliente = Convert.ToInt32(registro["id_cliente"]);
                modelo.Nome = Convert.ToString(registro["nome"]);
                modelo.Cpf = Convert.ToString(registro["cpf"]);
                modelo.Telefone = Convert.ToString(registro["telefone"]);
                modelo.Celular = Convert.ToString(registro["celular"]);
                modelo.Email = Convert.ToString(registro["email"]);
                modelo.Observacao = Convert.ToString(registro["observacao"]);
                modelo.IdEndereco = Convert.ToInt32(registro["id_endereco"]);
                modelo.NumeroEnde = Convert.ToString(registro["numeroEnde"]);
            }
            conexao.Desconectar();
            return modelo;
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
