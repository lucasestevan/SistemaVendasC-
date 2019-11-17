using BLL;
using DAL;
using Modelo;
using System;
using System.Windows.Forms;

namespace SistemaVendas.Apresentacao
{
    public partial class frm_RecebimentoVenda : Form
    {
        public int idParcela = 0;
        public string VerificaPago = "";

        public frm_RecebimentoVenda()
        {
            InitializeComponent();
        }

        //BOTAO RECEBER
        private void BtnReceber_Click(object sender, EventArgs e)
        {
            //pega o id da data grid
            this.VerificaPago = (Convert.ToString(dgvParcelas.CurrentRow.Cells[2].Value));
            if (VerificaPago == "01/01/0001 00:00:00")//a data que ele tras, nao deixa vazio
            {
                DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);

                BLL_ParcelasVenda bllP = new BLL_ParcelasVenda(con);
                int idVenda = Convert.ToInt32(txtIdVenda.Text);
                DateTime data = dtRecebimento.Value;
                bllP.RecebimentoParcela(idVenda, this.idParcela, data);

                BLL_ParcelasVenda bllP2 = new BLL_ParcelasVenda(con);
                dgvParcelas.DataSource = bllP2.Localizar(idVenda);
                btnReceber.Enabled = false;

                //LEITURA DOS DADOS
                Model_Venda modeloV = new Model_Venda();
                modeloV.IdVenda = Convert.ToInt32(txtIdVenda.Text);
                modeloV.VendaStatus = "PAGO";
                //OBJ PARA GRAVAR NO BANCO
                BLL_Venda bll = new BLL_Venda(con);

                bll.PagarParcelaVenda(modeloV);
                MessageBox.Show("Pagamento efetuado com sucesso!");

                FormatarDGV();

            }
            else
            {
                MessageBox.Show("Parcela já está paga!");
                
            }

        }

        //BOTAO LOCALIZAR
        private void BtnLocalizar_Click(object sender, EventArgs e)
        {
            frm_Venda venda = new frm_Venda();
            venda.btnSelecionar.Enabled = true;

            venda.ShowDialog();
            if (venda.idVenda != 0)
            {
                //chamr modelo bll e dal compra
                DAL_Conexao con = new DAL_Conexao(DadoConexao.StringDeConexao);

                BLL_Venda bll = new BLL_Venda(con);
                Model_Venda modeloV = bll.CarregaModeloVenda(venda.idVenda);
                txtIdVenda.Text = modeloV.IdVenda.ToString();
                dtVenda.Value = modeloV.DataVenda;
                txtValor.Text = modeloV.Total.ToString();

                BLL_Cliente bllC = new BLL_Cliente(con);
                Model_Cliente modeloC = bllC.CarregaModeloCliente(modeloV.IdCliente);
                txtCliente.Text = modeloC.Nome;

                BLL_ParcelasVenda bllP = new BLL_ParcelasVenda(con);
                dgvParcelas.DataSource = bllP.Localizar(modeloV.IdVenda);
                FormatarDGV();
                this.btnLocalizar.Enabled = false;
            }

        }

        //FORMATA O DATA GRID
        private void FormatarDGV()
        {
            dgvParcelas.Columns[0].HeaderText = "Parcela"; //NOME DO CABEÇALHO
            dgvParcelas.Columns[0].Width = 60; //TAMANHO DA LARGURA
            dgvParcelas.Columns[1].HeaderText = "Valor da Parcela";
            dgvParcelas.Columns[1].Width = 130;
            dgvParcelas.Columns[2].HeaderText = "Recebido em";
            dgvParcelas.Columns[2].Width = 110;
            dgvParcelas.Columns[3].HeaderText = "Data Vencimento";
            dgvParcelas.Columns[3].Width = 130;
            dgvParcelas.Columns[4].HeaderText = "Cód. Venda";
            dgvParcelas.Columns[4].Width = 110;
        }


        //evento ao clikar an grid
        private void DgvParcelas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnReceber.Enabled = true;
            this.idParcela = 0;


            btnReceber.Enabled = true;
            this.idParcela = Convert.ToInt32(dgvParcelas.Rows[e.RowIndex].Cells[0].Value);

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
    }
}

