using BLL;
using DAL;
using SistemaVendas.Apresentacao.Cadastro;
using System;
using System.Windows.Forms;

namespace SistemaVendas.Apresentacao
{
    public partial class frm_Endereco : Form
    {
        public frm_Endereco()
        {
            InitializeComponent();
        }

        //BOTAO NOVO
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            frm_CadEndereco cadEndereco = new frm_CadEndereco();
            cadEndereco.ShowDialog();
        }

        //botao pesquisar
        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
            BLL_Endereco bll = new BLL_Endereco(con);
            dgvEndereco.DataSource = bll.Localizar(txtRua.Text);
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
                        BLL_Endereco bll = new BLL_Endereco(con);

                        //PASSAR O CODIGO QUE ESTA NA TELA
                        bll.Excluir(Convert.ToInt32(txtId.Text));
                        MessageBox.Show("Endereço excluido com sucesso!");
                        BtnPesquisar_Click(sender, e); //RECARREGA A TELA COM O ITEM EXCLUIDO
                        txtId.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir Endereço, o registro está sendo utilizado em outro local \n " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione algum campo para poder excluir");
            }
        }

        //BOTAO ALTERAR
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            frm_CadEndereco cadEndereco = new frm_CadEndereco();
            //ABRIR O FORM DE CAD DE PACIENTE
            cadEndereco.Show();

            //HABILITAR CAMPOS e botao alterar NO FORM PARA PODER ALTERAR
            //cadCategoria.habilitarCampos();
            cadEndereco.btnAlterar.Enabled = true;
            cadEndereco.btnSalvar.Enabled = false;

            // ENVIAR PARA OS DADOS AO FORM PARA ALTERAR
            cadEndereco.txtId.Text = System.Convert.ToString(dgvEndereco.CurrentRow.Cells[0].Value);
            cadEndereco.txtCep.Text = System.Convert.ToString(dgvEndereco.CurrentRow.Cells[1].Value);
            cadEndereco.txtRua.Text = System.Convert.ToString(dgvEndereco.CurrentRow.Cells[2].Value);
            cadEndereco.txtBairro.Text = System.Convert.ToString(dgvEndereco.CurrentRow.Cells[3].Value);
            cadEndereco.txtCidade.Text = System.Convert.ToString(dgvEndereco.CurrentRow.Cells[4].Value);
            cadEndereco.txtUf.Text = System.Convert.ToString(dgvEndereco.CurrentRow.Cells[5].Value);
        }

        //METODO FORMATAR DATA GRID
        private void FormatarDGV()
        {
            dgvEndereco.Columns[0].HeaderText = "Código"; //NOME DO CABEÇALHO
            dgvEndereco.Columns[0].Width = 45; //TAMANHO DA LARGURA
            dgvEndereco.Columns[1].HeaderText = "Cep";
            dgvEndereco.Columns[1].Width = 60;
            dgvEndereco.Columns[2].HeaderText = "Rua";
            dgvEndereco.Columns[2].Width = 110;
            dgvEndereco.Columns[3].HeaderText = "Bairro";
            dgvEndereco.Columns[3].Width = 110;
            dgvEndereco.Columns[4].HeaderText = "Cidade";
            dgvEndereco.Columns[4].Width = 80;
            dgvEndereco.Columns[5].HeaderText = "UF";
            dgvEndereco.Columns[5].Width = 35;
        }

        //EVENTO AO CLIKAR NA GRID
        private void DgvEndereco_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //AO CLIKAR NA GRID JOGAR PARA O CAMPO ID exame
            txtId.Text = System.Convert.ToString(dgvEndereco.CurrentRow.Cells[0].Value);

            //HABILITAR BOTOES
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        //botao selecionar
        private void BtnSelecionar_Click(object sender, EventArgs e)
        {
            //SELECIONA O ID E O NOME E MANDA PARA A CLASSE ESTATICA
            Modelo.Estaticos.IdEnde = System.Convert.ToString(dgvEndereco.CurrentRow.Cells[0].Value);
            Modelo.Estaticos.cep = System.Convert.ToString(dgvEndereco.CurrentRow.Cells[1].Value);
            Modelo.Estaticos.rua = System.Convert.ToString(dgvEndereco.CurrentRow.Cells[2].Value);
            Modelo.Estaticos.bairro = System.Convert.ToString(dgvEndereco.CurrentRow.Cells[3].Value);
            Modelo.Estaticos.cidade = System.Convert.ToString(dgvEndereco.CurrentRow.Cells[4].Value);
            Modelo.Estaticos.uf = System.Convert.ToString(dgvEndereco.CurrentRow.Cells[5].Value);

            this.Close();
            this.Dispose();
        }
    }
}
