using SistemaVendas.Apresentacao.Cadastro;
using System;
using System.Windows.Forms;

namespace SistemaVendas.Apresentacao.ControlesUsuario
{
    public partial class Controle_Venda : UserControl
    {
        public Controle_Venda()
        {
            InitializeComponent();
        }

        private void btnVendaRapida_Click(object sender, EventArgs e)
        {
            frm_VendasFC f = new frm_VendasFC();
            f.Show();
        }

        private void btnVendasBal_Click(object sender, EventArgs e)
        {
            frm_CadVenda f = new frm_CadVenda();
            f.Show();
        }
    }
}
