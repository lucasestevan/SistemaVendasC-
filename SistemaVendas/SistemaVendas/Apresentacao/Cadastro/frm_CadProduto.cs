﻿using BLL;
using DAL;
using Modelo;
using System;
using System.Windows.Forms;

namespace SistemaVendas.Apresentacao.Cadastro
{
    public partial class frm_CadProduto : Form
    {
        public frm_CadProduto()
        {
            InitializeComponent();
        }

        //LOAD DO FORM
        private void Frm_CadProduto_Load(object sender, EventArgs e)
        {
            listarComboboxBox();
        }

        //METODO LISTAR COMBOBOX
        public void listarComboboxBox()
        {

            //CARREGAR CATEGORIA
            try
            {
                DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
                BLL_Categoria bll = new BLL_Categoria(con);
                cmbCategoria.DataSource = bll.Localizar("");   //CARREGA OS DADOS DA TABELA QUE CRIEI
                cmbCategoria.DisplayMember = "nome";   //PEGA O NOME
                cmbCategoria.ValueMember = "id_categoria"; //PEGA O ID

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar tabela Categoria: \n" + ex);

            }

            //carregar fornecedor
            try
            {
                DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
                BLL_Fornecedor bll = new BLL_Fornecedor(con);
                cmbFornecedor.DataSource = bll.Localizar("");   //CARREGA OS DADOS DA TABELA QUE CRIEI
                cmbFornecedor.DisplayMember = "nome";   //PEGA O NOME
                cmbFornecedor.ValueMember = "id_fornecedor"; //PEGA O ID

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar tabela Fornecedor: \n" + ex);

            }
        }

        // BOTAO SALVAR
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //LEITURA DOS DADOS
                Model_Produto modelo = new Model_Produto();
                modelo.nome = txtNome.Text;
                modelo.preco = Convert.ToDouble(txtPreco.Text);
                modelo.quantidade = Convert.ToDouble(txtQtd.Text);
                modelo.descricao = txtDesc.Text;
                modelo.idCategoria = Convert.ToInt32(cmbCategoria.SelectedValue);
                modelo.idFornecedor = Convert.ToInt32(cmbFornecedor.SelectedValue);
                //OBJ PARA GRAVAR NO BANCO
                DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
                BLL_Produto bll = new BLL_Produto(con);

                //CADASTRAR UMA CATEGORIA
                bll.Incluir(modelo);
                MessageBox.Show("Produto cadastrado com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Cadastrar Produto \n" + ex.Message);
            }
        }

        //BOTAO ALTERAR
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                //LEITURA DOS DADOS
                Model_Produto modelo = new Model_Produto();
                modelo.idProduto = Convert.ToInt32(txtId.Text);
                modelo.nome = txtNome.Text;
                modelo.preco = Convert.ToDouble(txtPreco.Text);
                modelo.quantidade = Convert.ToDouble(txtQtd.Text);
                modelo.descricao = txtDesc.Text;
                modelo.idCategoria = Convert.ToInt32(cmbCategoria.SelectedValue);
                modelo.idFornecedor = Convert.ToInt32(cmbFornecedor.SelectedValue);
                //OBJ PARA GRAVAR NO BANCO
                DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
                BLL_Produto bll = new BLL_Produto(con);

                //CADASTRAR UMA CATEGORIA
                bll.Alterar(modelo);
                MessageBox.Show("Produto alterado com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar o Produto \n" + ex.Message);
            }
        }

        //AJUSTAR O CAMPO preco
        private void TxtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                if (!txtPreco.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }

        //quando sair do cmapo preco
        private void TxtPreco_Leave(object sender, EventArgs e)
        {
            if (txtPreco.Text.Contains(",") == false)
            {
                txtPreco.Text += ",";
            }
            else
            {
                if (txtPreco.Text.IndexOf(",") == txtPreco.Text.Length - 1)
                {
                    txtPreco.Text += "00";
                }
            }
            try
            {
                Double d = Convert.ToDouble(txtPreco.Text);
            }
            catch
            {
                txtPreco.Text = "0,00";
            }
        }

        //AJUSTAR O CAMPO QUANTIDADE
        private void TxtQtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',' || e.KeyChar == ',')
            {
                if (!txtQtd.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }

        //AJUSTAR O CAMPO QUANTIDADE
        private void TxtQtd_Leave(object sender, EventArgs e)
        {
            if (txtQtd.Text.Contains(",") == false)
            {
                txtQtd.Text += ",00";
            }
            else
            {
                if (txtQtd.Text.IndexOf(",") == txtQtd.Text.Length - 1)
                {
                    txtQtd.Text += "00";
                }
            }
            try
            {
                Double d = Convert.ToDouble(txtPreco.Text);
            }
            catch
            {
                txtQtd.Text = "0,00";
            }
        }
    }
}
