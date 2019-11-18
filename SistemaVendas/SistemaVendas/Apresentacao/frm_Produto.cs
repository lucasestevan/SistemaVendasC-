﻿using BLL;
using DAL;
using Modelo;
using SistemaVendas.Apresentacao.Cadastro;
using System;
using System.Windows.Forms;

namespace SistemaVendas.Apresentacao
{
    public partial class frm_Produto : Form
    {
        public int idProduto = 0;
        public frm_Produto()
        {
            InitializeComponent();
        }

        //BOTAO NOVO
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            frm_CadProduto cadProduto = new frm_CadProduto();
            cadProduto.ShowDialog();
        }

        //BOTAO PESQUISAR 
        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            DAO_Conexao con = new DAO_Conexao(DadoConexao.StringDeConexao);
            BLL_Produto bll = new BLL_Produto(con);
            dgvProduto.DataSource = bll.Localizar(txtNome.Text);
            FormatarDGV(); //FORMATA O DATA GRID
            ContarLinhas();
        }

        //BOTAO EXCLUIR
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                DialogResult msgSN = MessageBox.Show("Deseja realmente excluir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
                //SE O ESCOLHER SIM FAÇA
                if (msgSN == DialogResult.Yes)
                {
                    try
                    {
                        //CRIAR CONEXAO
                        DAO_Conexao con = new DAO_Conexao(DadoConexao.StringDeConexao);
                        BLL_Produto bll = new BLL_Produto(con);

                        //PASSAR O CODIGO QUE ESTA NA TELA
                        bll.Excluir(Convert.ToInt32(txtId.Text));
                        MessageBox.Show("Produto excluido com sucesso!");
                        BtnPesquisar_Click(sender, e); //RECARREGA A TELA COM O ITEM EXCLUIDO
                        txtId.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir Produto, o registro está sendo utilizado em outro local \n " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione algum campo para poder excluir");
            }
        }

        //EVENTO AO CLIKAR NA DATAGRID
        private void DgvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //AO CLIKAR NA GRID JOGAR PARA O CAMPO ID exame
            txtId.Text = System.Convert.ToString(dgvProduto.CurrentRow.Cells[0].Value);

            //HABILITAR BOTOES
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        //BOTAO ALTERAR
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                //pega o id da data grid
                this.idProduto = (Convert.ToInt32(dgvProduto.CurrentRow.Cells[0].Value));

                //chamr modelo bll e dal 
                DAO_Conexao con = new DAO_Conexao(DadoConexao.StringDeConexao);
                BLL_Produto bll = new BLL_Produto(con);
                Model_Produto modelo = bll.CarregaModeloProduto(idProduto);

                //CHAMAR O FORM Card e passar as informacoes
                frm_CadProduto cadProduto = new frm_CadProduto();
                cadProduto.btnAlterar.Visible = true;
                cadProduto.btnSalvar.Visible = false;

                cadProduto.txtId.Text = modelo.IdProduto.ToString();//id
                cadProduto.txtNome.Text = modelo.Nome.ToString(); //nome
                cadProduto.txtPreco.Text = modelo.Preco.ToString();//preco
                cadProduto.txtQtd.Text = modelo.Quantidade.ToString(); // qtd
                cadProduto.txtDesc.Text = modelo.Descricao.ToString(); // descricao
                cadProduto.cmbCategoria.SelectedValue = modelo.IdCategoria;//categora 
                cadProduto.cmbFornecedor.SelectedValue = modelo.IdFornecedor; //fornecedor 
                cadProduto.txtCodigo.Text = modelo.Codigo_pro.ToString(); //codigo 
                cadProduto.ShowDialog();
                BtnPesquisar_Click(sender, e); // CHAMR O BOTAO PESQUISAR PARA ATUALIZAR A GRID
            }
            else
            {
                MessageBox.Show("Selecione algum campo para alterar!");
            }
        }

        //METODO formatar  DATA GRID
        private void FormatarDGV()
        {
            dgvProduto.Columns[0].Visible = false; //id
            dgvProduto.Columns[1].HeaderText = "Código"; //codigo
            dgvProduto.Columns[1].Width = 60; //TAMANHO DA LARGURA
            dgvProduto.Columns[2].HeaderText = "Nome";
            dgvProduto.Columns[2].Width = 130;
            dgvProduto.Columns[3].HeaderText = "Preço";
            dgvProduto.Columns[3].Width = 70;
            dgvProduto.Columns[4].HeaderText = "Quant.";
            dgvProduto.Columns[4].Width = 60;
            dgvProduto.Columns[5].HeaderText = "Descrição";
            dgvProduto.Columns[5].Width = 100;
            dgvProduto.Columns[6].HeaderText = "Categoria";
            dgvProduto.Columns[6].Width = 120;
            dgvProduto.Columns[7].HeaderText = "Fornecedor";
            dgvProduto.Columns[7].Width = 120;
        }

        //botao minimizar
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //botao fechar
        private void btnClose_Click(object sender, EventArgs e)
        {
            //MOSTRAR MENSAGEM SE QUER SAIR AO CLIKAR NO sair
            DialogResult msg = MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            //SE O ESCOLHER SIM
            if (msg == DialogResult.Yes)
            {
                this.Hide();
                this.Close();
            }
        }
        
        //METODO CONTAR LINHAS
        private void ContarLinhas()
        {
            int total = dgvProduto.Rows.Count;
            lblQtdTotal.Text = total.ToString();
        }
    }
}