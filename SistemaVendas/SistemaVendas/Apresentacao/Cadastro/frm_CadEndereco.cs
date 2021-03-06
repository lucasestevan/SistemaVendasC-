﻿using BLL;
using DAL;
using Modelo;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaVendas.Apresentacao.Cadastro
{
    public partial class frm_CadEndereco : Form
    {
        public frm_CadEndereco()
        {
            InitializeComponent();
        }

        //BOTAO BUSCAR CEP
        private void BtnCep_Click(object sender, EventArgs e)
        {
            BuscarCEP();
        }

        //METODO BUSCAR CEP
        public void BuscarCEP()
        {
            txtRua.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtUf.Text = "";

            string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml"
                .Replace("@cep", txtCep.Text);

            DataSet ds = new DataSet();
            ds.ReadXml(xml);

            txtRua.Text = ds.Tables[0].Rows[0][6].ToString();
            txtBairro.Text = ds.Tables[0].Rows[0][4].ToString();
            txtCidade.Text = ds.Tables[0].Rows[0][3].ToString();
            txtUf.Text = ds.Tables[0].Rows[0][2].ToString();
        }

        //BOTAO SALVAR
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //LEITURA DOS DADOS
                Model_Endereco modelo = new Model_Endereco();
                modelo.Cep = txtCep.Text;
                modelo.Rua = txtRua.Text;
                modelo.Bairro = txtBairro.Text;
                modelo.Cidade = txtCidade.Text;
                modelo.Uf = txtUf.Text;
                //OBJ PARA GRAVAR NO BANCO
                DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
                BLL_Endereco bll = new BLL_Endereco(con);

                //CADASTRAR UMA CATEGORIA
                bll.Incluir(modelo);
                MessageBox.Show("Endereço cadastrado com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Cadastrar Endereço \n" + ex.Message);
            }
        }

        //BOTAO ALTERAR
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                //LEITURA DOS DADOS
                Model_Endereco modelo = new Model_Endereco();
                modelo.IdEndereco = Convert.ToInt32(txtId.Text);
                modelo.Cep = txtCep.Text;
                modelo.Rua = txtRua.Text;
                modelo.Bairro = txtBairro.Text;
                modelo.Cidade = txtCidade.Text;
                modelo.Uf = txtUf.Text;
                //OBJ PARA GRAVAR NO BANCO
                DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
                BLL_Endereco bll = new BLL_Endereco(con);

                //CADASTRAR UMA CATEGORIA
                bll.Alterar(modelo);
                MessageBox.Show("Endereço alterado com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar Endereço \n" + ex.Message);
            }
        }

        private void TxtCep_Leave(object sender, EventArgs e)
        {
            //valida cep

            if (Validacao.ValidaCep(txtCep.Text) == false)
            {
                MessageBox.Show("O Cep é invalido!");
            }
        }
    }
}
