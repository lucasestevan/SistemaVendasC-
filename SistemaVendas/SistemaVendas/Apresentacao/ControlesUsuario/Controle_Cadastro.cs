using SistemaVendas.Apresentacao.Cadastro;
using System;
using System.Windows.Forms;

namespace SistemaVendas
{
    public partial class Controle_Cadastro : UserControl
    {
        public Controle_Cadastro()
        {
            InitializeComponent();
        }

        //BOTAO PRODUTO
        private void btnProduto_Click(object sender, EventArgs e)
        {
            frm_CadProduto f = new frm_CadProduto();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            frm_CadFornecedor f = new frm_CadFornecedor();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frm_CadCliente f = new frm_CadCliente();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnColaborador_Click(object sender, EventArgs e)
        {
            frm_CadColaborador f = new frm_CadColaborador();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            frm_CadCategoria f = new frm_CadCategoria();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnFormaPagto_Click(object sender, EventArgs e)
        {
            frm_CadTipoPagamento f = new frm_CadTipoPagamento();
            f.ShowDialog();
            f.Dispose();
        }
    }
}
