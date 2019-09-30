using BLL;
using DAL;
using SistemaVendas.Apresentacao.Cadastro;
using System;
using System.Windows.Forms;

namespace SistemaVendas.Apresentacao
{
    public partial class frm_TipoPagamento : Form
    {
        public frm_TipoPagamento()
        {
            InitializeComponent();
        }

        //BOTAO NOVO
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            frm_CadTipoPagamento pagamento = new frm_CadTipoPagamento();
            pagamento.ShowDialog();
        }

        //BOTAO PESQUISAR
        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
            BLL_TipoPagamento bll = new BLL_TipoPagamento(con);
            dgvTipoPag.DataSource = bll.Localizar(txtNome.Text);
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
                        BLL_TipoPagamento bll = new BLL_TipoPagamento(con);

                        //EXCLUIR  UMA CATEGORIA
                        //PASSAR O CODIGO QUE ESTA NA TELA
                        bll.Excluir(Convert.ToInt32(txtId.Text));
                        MessageBox.Show("Tipo de Pagamento excluido com sucesso!");
                        BtnPesquisar_Click(sender, e);
                        txtId.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir Tipo de Pagamento, o registro está sendo utilizado em outro local \n " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione algum campo para poder excluir");
            }
        }

        //EVENTO AO CLIKAR NA DATAGRID
        private void DgvTipoPag_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //AO CLIKAR NA GRID JOGAR PARA O CAMPO txt id
            txtId.Text = System.Convert.ToString(dgvTipoPag.CurrentRow.Cells[0].Value);

            //HABILITAR BOTOES
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        //BOTAO ALTERAR
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            frm_CadTipoPagamento pagamento = new frm_CadTipoPagamento();
            //ABRIR O FORM DE CAD DE PACIENTE
            pagamento.Show();

            //HABILITAR CAMPOS e botao alterar NO FORM PARA PODER ALTERAR
            //cadCategoria.habilitarCampos();
            pagamento.btnAlterar.Enabled = true;
            pagamento.btnSalvar.Enabled = false;

            // ENVIAR PARA OS DADOS AO FORM PARA ALTERAR
            pagamento.txtId.Text = System.Convert.ToString(dgvTipoPag.CurrentRow.Cells[0].Value);
            pagamento.txtNome.Text = System.Convert.ToString(dgvTipoPag.CurrentRow.Cells[1].Value);
        }

        //METODO  DATA GRID
        private void FormatarDGV()
        {
            dgvTipoPag.Columns[0].HeaderText = "Código"; //NOME DO CABEÇALHO
            dgvTipoPag.Columns[0].Width = 50; //TAMANHO DA LARGURA
            dgvTipoPag.Columns[1].HeaderText = "Tipo de Pagto";
            dgvTipoPag.Columns[1].Width = 150;
        }
    }
}
