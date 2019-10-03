using BLL;
using DAL;
using SistemaVendas.Apresentacao.Cadastro;
using System;
using System.Windows.Forms;

namespace SistemaVendas.Apresentacao
{
    public partial class frm_MovimentacaoCompra : Form
    {
        public frm_MovimentacaoCompra()
        {
            InitializeComponent();
        }

        //BOTAO NOVO
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            frm_CadMovimentacaoCompra cadMovimentacaoCompra = new frm_CadMovimentacaoCompra();
            cadMovimentacaoCompra.ShowDialog();
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
                        BLL_Compra bll = new BLL_Compra(con);

                        //PASSAR O CODIGO QUE ESTA NA TELA
                        bll.Excluir(Convert.ToInt32(txtId.Text));
                        MessageBox.Show("Compra excluida com sucesso!");
                        BtnPesquisar_Click(sender, e); //RECARREGA A TELA COM O ITEM EXCLUIDO
                        txtId.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir Compra, o registro está sendo utilizado em outro local \n " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione algum campo para poder excluir");
            }
        }

        //EVENTO AO CLIKAR NA DATAGRID
        private void DgvCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //AO CLIKAR NA GRID JOGAR PARA O CAMPO ID exame
            txtId.Text = System.Convert.ToString(dgvCompra.CurrentRow.Cells[0].Value);

            //HABILITAR BOTOES
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        //EVENTO LOAD
        private void Frm_MovimentacaoCompra_Load(object sender, EventArgs e)
        {
            RbGeral_CheckedChanged(sender, e);
        }


        private void RbGeral_CheckedChanged(object sender, EventArgs e)
        {
            //OCUTAR PAINEIS
            gbData.Visible = false;
            gbFornecedor.Visible = false;
            btnPesquisarGeral.Visible = false;

            //LIMPAR O GRID
            dgvCompra.DataSource = null;

            if (rbGeral.Checked == true)
            {
                btnPesquisarGeral.Visible = true;
            }
            if ((rbData.Checked == true))
            {
                gbData.Visible = true;
            }

            if ((RbFornecedor.Checked == true))
            {
                gbFornecedor.Visible = true;
            }
        }

        //BOTAO PESQUISAR geral
        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
            BLL_Compra bll = new BLL_Compra(con);
            dgvCompra.DataSource = bll.LocalizarGeral();
            FormatarDGV(); //FORMATA O DATA GRID
        }

        //BOTAO PESQUISAR FORNECEDOR
        private void BtnPesquisarFornecedor_Click(object sender, EventArgs e)
        {
            DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
            BLL_Compra bll = new BLL_Compra(con);
            dgvCompra.DataSource = bll.LocalizarNome(txtNome.Text);
            FormatarDGV(); //FORMATA O DATA GRID
        }

        private void BtnPesquisaData_Click(object sender, EventArgs e)
        {
            DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);
            BLL_Compra bll = new BLL_Compra(con);
            dgvCompra.DataSource = bll.LocalizarData(dtInicial.Value, dtFinal.Value);
            FormatarDGV(); //FORMATA O DATA GRID
        }

        //FORMATA O DATA GRID
        private void FormatarDGV()
        {
            dgvCompra.Columns[0].HeaderText = "Código"; //NOME DO CABEÇALHO
            dgvCompra.Columns[0].Width = 45; //TAMANHO DA LARGURA
            dgvCompra.Columns[1].HeaderText = "Data da Compra";
            dgvCompra.Columns[1].Width = 120;
            dgvCompra.Columns[2].HeaderText = "Nota Fiscal";
            dgvCompra.Columns[2].Width = 85;
            dgvCompra.Columns[3].HeaderText = "N° Parcelas";
            dgvCompra.Columns[3].Width = 90;
            dgvCompra.Columns[4].HeaderText = "Total";
            dgvCompra.Columns[4].Width = 80;
            dgvCompra.Columns[5].HeaderText = "Status";
            dgvCompra.Columns[5].Width = 60;
            dgvCompra.Columns[6].Visible = false;
            dgvCompra.Columns[7].Visible = false;
            dgvCompra.Columns[8].HeaderText = "Fornecedor";
            dgvCompra.Columns[8].Width = 140;
        }
    }
}
