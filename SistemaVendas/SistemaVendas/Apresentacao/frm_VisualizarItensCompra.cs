using System;
using System.Windows.Forms;

namespace SistemaVendas.Apresentacao
{
    public partial class frm_VisualizarItensCompra : Form
    {
        public frm_VisualizarItensCompra()
        {
            InitializeComponent();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void Frm_VisualizarItensCompra_Load(object sender, EventArgs e)
        {
            FormatarDGV();
        }

        //FORMATA O DATA GRID
        private void FormatarDGV()
        {
            dgvItensCompra.Columns[0].HeaderText = "Código"; //NOME DO CABEÇALHO
            dgvItensCompra.Columns[0].Width = 45; //TAMANHO DA LARGURA
            dgvItensCompra.Columns[1].HeaderText = "Produto";
            dgvItensCompra.Columns[1].Width = 160;
            dgvItensCompra.Columns[2].HeaderText = "Quant.";
            dgvItensCompra.Columns[2].Width = 80;
            dgvItensCompra.Columns[3].HeaderText = "Valor";
            dgvItensCompra.Columns[3].Width = 90;
            dgvItensCompra.Columns[4].Visible = false; //idCompra
            dgvItensCompra.Columns[5].Visible = false; // idproduto
     
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
