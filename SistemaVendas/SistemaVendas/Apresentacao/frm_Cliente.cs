using BLL;
using DAL;
using SistemaVendas.Apresentacao.Cadastro;
using System;
using System.Windows.Forms;

namespace SistemaVendas.Apresentacao
{
    public partial class frm_Cliente : Form
    {
        public frm_Cliente()
        {
            InitializeComponent();
        }

        //BOTAO NOVO
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            frm_CadCliente cadCliente = new frm_CadCliente();
            cadCliente.ShowDialog();
        }

        //BOTAO PESQUISAR
        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
            BLL_Cliente bll = new BLL_Cliente(con);
            dgvCliente.DataSource = bll.Localizar(txtNome.Text);
            FormatarDGV(); //FORMATA O DATA GRID
        }

       

        //botao excluir
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
                        BLL_Cliente bll = new BLL_Cliente(con);

                        //PASSAR O CODIGO QUE ESTA NA TELA
                        bll.Excluir(Convert.ToInt32(txtId.Text));
                        MessageBox.Show("Cliente excluido com sucesso!");
                        BtnPesquisar_Click(sender, e); //RECARREGA A TELA COM O ITEM EXCLUIDO
                        txtId.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir Cliente, o registro está sendo utilizado em outro local \n " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione algum campo para poder excluir");
            }
        }

        //EVENTO AO CLIKAR NA GRID
        private void DgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //AO CLIKAR NA GRID JOGAR PARA O CAMPO ID exame
            txtId.Text = System.Convert.ToString(dgvCliente.CurrentRow.Cells[0].Value);

            //HABILITAR BOTOES
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        //BOTAO ALTERAR
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            frm_CadCliente cadCliente = new frm_CadCliente();
            //ABRIR O FORM DE CAD DE PACIENTE
            cadCliente.Show();

            //HABILITAR CAMPOS e botao alterar NO FORM PARA PODER ALTERAR
            //cadCategoria.habilitarCampos();
            cadCliente.btnAlterar.Enabled = true;
            cadCliente.btnSalvar.Enabled = false;

            // ENVIAR PARA OS DADOS AO FORM PARA ALTERAR
            cadCliente.txtId.Text = System.Convert.ToString(dgvCliente.CurrentRow.Cells[0].Value);
            cadCliente.txtNome.Text = System.Convert.ToString(dgvCliente.CurrentRow.Cells[1].Value);
            cadCliente.txtCPF.Text = System.Convert.ToString(dgvCliente.CurrentRow.Cells[2].Value);
            cadCliente.txtTelefone.Text = System.Convert.ToString(dgvCliente.CurrentRow.Cells[3].Value);
            cadCliente.txtCel.Text = System.Convert.ToString(dgvCliente.CurrentRow.Cells[4].Value);
            cadCliente.txtEmail.Text = System.Convert.ToString(dgvCliente.CurrentRow.Cells[5].Value);
            cadCliente.txtObs.Text = System.Convert.ToString(dgvCliente.CurrentRow.Cells[6].Value);
            cadCliente.txtIdEnde.Text = System.Convert.ToString(dgvCliente.CurrentRow.Cells[7].Value);
            cadCliente.txtCep.Text = System.Convert.ToString(dgvCliente.CurrentRow.Cells[8].Value); //Cep
            cadCliente.txtRua.Text = System.Convert.ToString(dgvCliente.CurrentRow.Cells[9].Value); //RUA
            cadCliente.txtNumero.Text = System.Convert.ToString(dgvCliente.CurrentRow.Cells[10].Value); // NUMERO
            cadCliente.txtBairro.Text = System.Convert.ToString(dgvCliente.CurrentRow.Cells[11].Value); // BAIRRO
            cadCliente.txtCidade.Text = System.Convert.ToString(dgvCliente.CurrentRow.Cells[12].Value);// CIDADE//
            cadCliente.txtUf.Text = System.Convert.ToString(dgvCliente.CurrentRow.Cells[13].Value); //UF

        }

        //METODO formatar  DATA GRID
       private void FormatarDGV()
        {
            dgvCliente.Columns[0].HeaderText = "Código"; //NOME DO CABEÇALHO
            dgvCliente.Columns[0].Width = 45; //TAMANHO DA LARGURA
            dgvCliente.Columns[1].HeaderText = "Nome";
            dgvCliente.Columns[1].Width = 130;
            dgvCliente.Columns[2].HeaderText = "CPF";
            dgvCliente.Columns[2].Width = 90;
            dgvCliente.Columns[3].HeaderText = "Telefone";
            dgvCliente.Columns[3].Width = 90;
            dgvCliente.Columns[4].HeaderText = "Celular";
            dgvCliente.Columns[4].Width = 90;
            dgvCliente.Columns[5].HeaderText = "E-mail";
            dgvCliente.Columns[5].Width = 120;
            dgvCliente.Columns[6].HeaderText = "Observação";
            dgvCliente.Columns[6].Width = 120;
            dgvCliente.Columns[7].Visible = false;
            dgvCliente.Columns[8].Visible = false;
            dgvCliente.Columns[9].Visible = false;
            dgvCliente.Columns[10].Visible = false;
            dgvCliente.Columns[11].Visible = false;
            dgvCliente.Columns[12].Visible = false;
            dgvCliente.Columns[13].Visible = false;
        }
    }
}

