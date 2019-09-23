﻿using BLL;
using DAL;
using SistemaVendas.Apresentacao.Cadastro;
using System;
using System.Windows.Forms;

namespace SistemaVendas.Apresentacao
{
    public partial class frm_Categoria : Form
    {
        public frm_Categoria()
        {
            InitializeComponent();
        }

        //BOTAO NOVO
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            frm_CadCategoria Categoria = new frm_CadCategoria();
            Categoria.ShowDialog();
        }

        //BOTAO PESQUISAR
        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
            BLL_Categoria bll = new BLL_Categoria(con);
            dgvCategoria.DataSource = bll.Localizar(txtNome.Text);
            FormatarDGV();
        }

        //BOTAO EXLUIR
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
                        DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
                        BLL_Categoria bll = new BLL_Categoria(con);

                        //EXCLUIR  UMA CATEGORIA
                        //PASSAR O CODIGO QUE ESTA NA TELA
                        bll.Excluir(Convert.ToInt32(txtId.Text));
                        MessageBox.Show("Categoria excluida com sucesso!");
                        BtnPesquisar_Click(sender, e);
                        txtId.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir Categoria, o registro está sendo utilizado em outro local \n " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecion algum campo para poder excluir");
            }
        }

        //EVENTO AO CLIKAR NA DATAGRID
        private void DgvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //AO CLIKAR NA GRID JOGAR PARA O CAMPO txt id
            txtId.Text = System.Convert.ToString(dgvCategoria.CurrentRow.Cells[0].Value);

            //HABILITAR BOTOES
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        //BOTAO ALTERAR
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            frm_CadCategoria cadCategoria = new frm_CadCategoria();
            //ABRIR O FORM DE CAD DE PACIENTE
            cadCategoria.Show();

            //HABILITAR CAMPOS e botao alterar NO FORM PARA PODER ALTERAR
            //cadCategoria.habilitarCampos();
            cadCategoria.btnAlterar.Enabled = true;
            cadCategoria.btnSalvar.Enabled = false;

            // ENVIAR PARA OS DADOS AO FORM PARA ALTERAR
            cadCategoria.txtId.Text = System.Convert.ToString(dgvCategoria.CurrentRow.Cells[0].Value);
            cadCategoria.txtNome.Text = System.Convert.ToString(dgvCategoria.CurrentRow.Cells[1].Value);

        }

        //load do form
        private void Frm_Categoria_Load(object sender, EventArgs e)
        {

        }

        //METODO  DATA GRID
        private void FormatarDGV()
        {
            dgvCategoria.Columns[0].HeaderText = "Código"; //NOME DO CABEÇALHO
            dgvCategoria.Columns[0].Width = 50; //TAMANHO DA LARGURA
            dgvCategoria.Columns[1].HeaderText = "Categoria";
            dgvCategoria.Columns[1].Width = 150;
        }
    }
}
