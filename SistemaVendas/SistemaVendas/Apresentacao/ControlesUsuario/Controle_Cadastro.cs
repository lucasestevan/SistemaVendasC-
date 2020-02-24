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
            f.Show();
            
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            frm_CadFornecedor f = new frm_CadFornecedor();
            f.Show();

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frm_CadCliente f = new frm_CadCliente();
            f.Show();

        }

        private void btnColaborador_Click(object sender, EventArgs e)
        {
            frm_CadColaborador f = new frm_CadColaborador();
            f.Show();

        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            frm_CadCategoria f = new frm_CadCategoria();
            f.Show();

        }

        private void btnFormaPagto_Click(object sender, EventArgs e)
        {
            frm_CadTipoPagamento f = new frm_CadTipoPagamento();
            f.Show();

        }
    }
}
