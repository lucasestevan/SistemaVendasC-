using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            f.ShowDialog();
            f.Dispose();
        }

        private void btnVendasBal_Click(object sender, EventArgs e)
        {
            frm_Venda f = new frm_Venda();
            f.ShowDialog();
            f.Dispose();
        }
    }
}
