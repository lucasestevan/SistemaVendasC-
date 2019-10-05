﻿using BLL;
using DAL;
using Modelo;
using SistemaVendas.Apresentacao.Cadastro;
using System;
using System.Windows.Forms;

namespace SistemaVendas.Apresentacao
{
    public partial class frm_Colaborador : Form
    {
        public int idColaborador = 0;

        public frm_Colaborador()
        {
            InitializeComponent();
        }

        //BOTAO NOVO
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            frm_CadColaborador cadColaborador = new frm_CadColaborador();
            cadColaborador.ShowDialog();
        }

        //BOTAO PESQUISAR
        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
            BLL_Colaborador bll = new BLL_Colaborador(con);
            dgvColaborador.DataSource = bll.Localizar(txtNome.Text);
            FormatarDGV(); //FORMATA O DATA GRID
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
                        DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
                        BLL_Colaborador bll = new BLL_Colaborador(con);

                        //PASSAR O CODIGO QUE ESTA NA TELA
                        bll.Excluir(Convert.ToInt32(txtId.Text));
                        MessageBox.Show("Colaborador excluido com sucesso!");
                        BtnPesquisar_Click(sender, e); //RECARREGA A TELA COM O ITEM EXCLUIDO
                        txtId.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir Colaborador, o registro está sendo utilizado em outro local \n " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione algum campo para poder excluir");
            }
        }

        //EVENTO AO CLIKAR NA DATAGRID
        private void DgvColaborador_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //AO CLIKAR NA GRID JOGAR PARA O CAMPO ID exame
            txtId.Text = System.Convert.ToString(dgvColaborador.CurrentRow.Cells[0].Value);

            //HABILITAR BOTOES
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        //BOTAO ALTERAR
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            //pega o id da data grid
            this.idColaborador = (Convert.ToInt32(dgvColaborador.CurrentRow.Cells[0].Value));

            //chamr modelo bll e dal 
            DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
            BLL_Colaborador bll = new BLL_Colaborador(con);
            Model_Colaborador modelo = bll.CarregaModeloColaborador(idColaborador);

            //CHAMAR O FORM Card e passar as informacoes
            frm_CadColaborador cadColaborador = new frm_CadColaborador();
            cadColaborador.btnAlterar.Enabled = true;
            cadColaborador.btnSalvar.Enabled = false;

            cadColaborador.txtId.Text = modelo.idColaborador.ToString();//id
            cadColaborador.txtNome.Text = modelo.nome.ToString(); //nome
            cadColaborador.txtCPF.Text = modelo.cpf.ToString();// cpf
            cadColaborador.txtSenha.Enabled = false; //senha
            cadColaborador.txtTelefone.Text = modelo.telefone.ToString(); // telefone 
            cadColaborador.txtCel.Text = modelo.celular.ToString(); // celular 
            cadColaborador.txtDesc.Text = modelo.descricao.ToString(); // descricao 
            cadColaborador.ShowDialog();
            this.BtnPesquisar_Click(sender, e); // CHAMR O BOTAO PESQUISAR PARA ATUALIZAR A GRID
        }

        //METODO formatar  DATA GRID
        private void FormatarDGV()
        {
            dgvColaborador.Columns[0].HeaderText = "Código"; //NOME DO CABEÇALHO
            dgvColaborador.Columns[0].Width = 45; //TAMANHO DA LARGURA
            dgvColaborador.Columns[1].HeaderText = "Nome";
            dgvColaborador.Columns[1].Width = 130;
            dgvColaborador.Columns[2].HeaderText = "CPF";
            dgvColaborador.Columns[2].Width = 90;
            dgvColaborador.Columns[3].Visible = false; //senha
            dgvColaborador.Columns[4].HeaderText = "Telefone";
            dgvColaborador.Columns[4].Width = 90;
            dgvColaborador.Columns[5].HeaderText = "Celular";
            dgvColaborador.Columns[5].Width = 120;
            dgvColaborador.Columns[6].HeaderText = "Descrição";
            dgvColaborador.Columns[6].Width = 120;
        }

        //BOTAO APAGAR SENHA
        private void BtnSenha_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                DialogResult msgSN = MessageBox.Show("Deseja realmente apagar a senha?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
                //SE O ESCOLHER SIM FAÇA
                if (msgSN == DialogResult.Yes)
                {
                    try
                    {
                        //LEITURA DOS DADOS
                        Model_Colaborador modelo = new Model_Colaborador();
                        modelo.idColaborador = Convert.ToInt32(txtId.Text);
                        modelo.senha = Convert.ToString("");
                        //OBJ PARA GRAVAR NO BANCO
                        DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
                        BLL_Colaborador bll = new BLL_Colaborador(con);

                        //CADASTRAR UMA CATEGORIA
                        bll.ApagarSenha(modelo);
                        MessageBox.Show("Senha apagada com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao apagar Senha \n" + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione algum campo para poder excluir");
            }
        }
    }
}
