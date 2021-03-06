﻿using Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAO_Cliente
    {
        private DAO_Conexao conexao;
        public DAO_Cliente(DAO_Conexao con)
        {
            this.conexao = con;
        }

        //METODO INCLUIR
        public void Incluir(Model_Cliente modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into Cliente (nome, cpf, telefone, celular, email, observacao, cep, numeroEnde)" +
                "values (@nome, @cpf, @telefone, @celular, @email, @observacao, @cep, @numeroEnde); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@cpf", modelo.Cpf);
            cmd.Parameters.AddWithValue("@telefone", modelo.Telefone);
            cmd.Parameters.AddWithValue("@celular", modelo.Celular);
            cmd.Parameters.AddWithValue("@email", modelo.Email);
            cmd.Parameters.AddWithValue("@observacao", modelo.Observacao);
            cmd.Parameters.AddWithValue("@cep", modelo.Cep);
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
                "observacao = @observacao, cep = @cep, numeroEnde = @numeroEnde where id_cliente = @id_cliente";
            cmd.Parameters.AddWithValue("@id_cliente", modelo.IdCliente);
            cmd.Parameters.AddWithValue("@nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@cpf", modelo.Cpf);
            cmd.Parameters.AddWithValue("@telefone", modelo.Telefone);
            cmd.Parameters.AddWithValue("@celular", modelo.Celular);
            cmd.Parameters.AddWithValue("@email", modelo.Email);
            cmd.Parameters.AddWithValue("@observacao", modelo.Observacao);
            cmd.Parameters.AddWithValue("@cep", modelo.Cep);
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
                modelo.Cep = Convert.ToString(registro["cep"]);
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
            da = new SqlDataAdapter("Select cli.id_cliente, cli.nome, cli.cpf, cli.telefone, cli.celular, cli.email, cli.observacao, cli.cep," +
                " ende.rua, cli.numeroEnde, ende.bairro, Ende.cidade," +
                " Ende.uf from Cliente as Cli INNER JOIN Endereco as Ende on cli.cep = Ende.cep where cli.nome like '%" + valor + "%' order by cli.nome", conexao.StringConexao);
            da.Fill(dt);
            return dt;
        }
    }
}
