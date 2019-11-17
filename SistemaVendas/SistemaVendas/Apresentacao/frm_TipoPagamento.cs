using BLL;
using DAL;
using Modelo;
using SistemaVendas.Apresentacao.Cadastro;
using System;
using System.Windows.Forms;

namespace SistemaVendas.Apresentacao
{
    public partial class frm_TipoPagamento : Form
    {
        public int idTipoPagamento = 0;
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
            ContarLinhas();
            
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
            if (txtId.Text != "")
            {
                //pega o id da data grid
                this.idTipoPagamento = (Convert.ToInt32(dgvTipoPag.CurrentRow.Cells[0].Value));

                //chamr modelo bll e dal 
                DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
                BLL_TipoPagamento bll = new BLL_TipoPagamento(con);
                Model_TipoPagamento modelo = bll.CarregaModeloTipoPagto(idTipoPagamento);

                //CHAMAR O FORM Card e passar as informacoes
                frm_CadTipoPagamento cadPagamento = new frm_CadTipoPagamento();
                cadPagamento.btnAlterar.Visible = true;
                cadPagamento.btnSalvar.Visible = false;

                cadPagamento.txtId.Text = modelo.IdTipoPagamento.ToString();
                cadPagamento.txtNome.Text = modelo.Nome.ToString();
                cadPagamento.ShowDialog();
                BtnPesquisar_Click(sender, e); // CHAMR O BOTAO PESQUISAR PARA ATUALIZAR A GRID
            }
            else
            {
                MessageBox.Show("Selecione algum campo para alterar!");
            }
        }

        //METODO  DATA GRID
        private void FormatarDGV()
        {
            dgvTipoPag.Columns[0].HeaderText = "Código"; //NOME DO CABEÇALHO
            dgvTipoPag.Columns[0].Width = 50; //TAMANHO DA LARGURA
            dgvTipoPag.Columns[1].HeaderText = "Tipo de Pagto";
            dgvTipoPag.Columns[1].Width = 200;
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
            int total = dgvTipoPag.Rows.Count;
            lblQtdTotal.Text = total.ToString();
        }
    }
}
