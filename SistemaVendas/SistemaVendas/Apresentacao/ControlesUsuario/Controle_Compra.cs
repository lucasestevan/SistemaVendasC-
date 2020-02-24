using SistemaVendas.Apresentacao.Cadastro;
using System;
using System.Windows.Forms;

namespace SistemaVendas.Apresentacao.ControlesUsuario
{
    public partial class Controle_Compra : UserControl
    {
        public Controle_Compra()
        {
            InitializeComponent();
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            frm_CadCompra f = new frm_CadCompra();
            f.Show();

        }
    }
}
