using Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAO_Fornecedor
    {
        private DAO_Conexao conexao;
        public DAO_Fornecedor(DAO_Conexao con)
        {
            this.conexao = con;
        }

        //METODO INCLUIR
        public void Incluir(Model_Fornecedor modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into Fornecedor (nome, cpfCNPJ, telefone, celular, email, observacao, cep, numeroEnde)" +
                "values (@nome, @cpfCNPJ, @telefone, @celular, @email, @observacao, @cep, @numeroEnde); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@cpfCNPJ", modelo.CpfCNPJ);
            cmd.Parameters.AddWithValue("@telefone", modelo.Telefone);
            cmd.Parameters.AddWithValue("@celular", modelo.Celular);
            cmd.Parameters.AddWithValue("@email", modelo.Email);
            cmd.Parameters.AddWithValue("@observacao", modelo.Observacao);
            cmd.Parameters.AddWithValue("@cep", modelo.Cep);
            cmd.Parameters.AddWithValue("@numeroEnde", modelo.NumeroEnde);
            conexao.Conectar();
            modelo.IdFornecedor = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        //METODO ALTERAR
        public void Alterar(Model_Fornecedor modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE Fornecedor set nome = @nome, cpfCNPJ = @cpfCNPJ, telefone = @telefone, celular = @celular, email = @email," +
                "observacao = @observacao, cep = @cep, numeroEnde = @numeroEnde where id_fornecedor = @id_fornecedor";
            cmd.Parameters.AddWithValue("@id_fornecedor", modelo.IdFornecedor);
            cmd.Parameters.AddWithValue("@nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@cpfCNPJ", modelo.CpfCNPJ);
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
        public void Excluir(int idFornecedor)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from Fornecedor where id_fornecedor = @id_fornecedor";
            cmd.Parameters.AddWithValue("@id_fornecedor", idFornecedor);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        //METODO CARREGA MODELO
        public Model_Fornecedor CarregaModeloFornecedor(int idFornecedor)
        {
            Model_Fornecedor modelo = new Model_Fornecedor();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from Fornecedor where id_fornecedor = @id_fornecedor";
            cmd.Parameters.AddWithValue("@id_fornecedor", idFornecedor);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            //SE EXITIR ALGUMA LINHA EXECUTAR
            if (registro.HasRows)
            {
                registro.Read();
                modelo.IdFornecedor = Convert.ToInt32(registro["id_fornecedor"]);
                modelo.Nome = Convert.ToString(registro["nome"]);
                modelo.CpfCNPJ = Convert.ToString(registro["cpfCNPJ"]);
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
            da = new SqlDataAdapter("Select f.id_fornecedor, f.nome, f.cpfCNPJ, f.telefone, f.celular, f.email, f.observacao, f.cep, " +
                " ende.rua, f.numeroEnde, ende.bairro, Ende.cidade," +
                " Ende.uf from Fornecedor as f INNER JOIN Endereco as Ende on f.cep = Ende.cep where f.nome like '%" + valor + "%' order by f.nome", conexao.StringConexao);
            da.Fill(dt);
            return dt;
        }
    }
}
