using System;
using System.Windows.Forms;

namespace SistemaVendas.Apresentacao.ControlesUsuario
{
    public partial class Controle_Relatorio : UserControl
    {
        public Controle_Relatorio()
        {
            InitializeComponent();
        }

        //BOTAO PRODUTO
        private void btnProduto_Click(object sender, EventArgs e)
        {
            frm_Produto f = new frm_Produto();
            f.Show();

        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            frm_Fornecedor f = new frm_Fornecedor();
            f.Show();

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frm_Cliente f = new frm_Cliente();
            f.Show();

        }

        private void btnColaborador_Click(object sender, EventArgs e)
        {
            frm_Colaborador f = new frm_Colaborador();
            f.Show();

        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            frm_Categoria f = new frm_Categoria();
            f.Show();

        }

        private void btnFormaPagto_Click(object sender, EventArgs e)
        {
            frm_TipoPagamento f = new frm_TipoPagamento();
            f.Show();

        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            frm_Compra f = new frm_Compra();
            f.Show();

        }

        private void btnVendasBal_Click(object sender, EventArgs e)
        {
            frm_Venda f = new frm_Venda();
            f.Show();

        }
    }
}
