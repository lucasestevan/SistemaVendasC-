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
            frm_Compra f = new frm_Compra();
            f.ShowDialog();
            f.Dispose();
        }
    }
}
