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
    public partial class Controle_Pagamento : UserControl
    {
        public Controle_Pagamento()
        {
            InitializeComponent();
        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {
            frm_PagamentoCompra f = new frm_PagamentoCompra();
            f.Show();

        }

        private void btnRecebimentoV_Click(object sender, EventArgs e)
        {
            frm_RecebimentoVenda f = new frm_RecebimentoVenda();
            f.Show();

        }
    }
}
