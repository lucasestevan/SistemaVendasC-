using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVendas
{
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
            pnAuxiliar.Height = btnMenu.Height;
            pnAuxiliar.Top = btnMenu.Top;
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

        //botao menu
        private void btnMenu_Click(object sender, EventArgs e)
        {
            pnAuxiliar.Height = btnMenu.Height;
            pnAuxiliar.Top = btnMenu.Top;
        }


        //botao vendas
        private void btnVendas_Click(object sender, EventArgs e)
        {
            pnAuxiliar.Height = btnVendas.Height;
            pnAuxiliar.Top = btnVendas.Top;
        }

        //botao Compras
        private void btnCompras_Click(object sender, EventArgs e)
        {
            pnAuxiliar.Height = btnCompras.Height;
            pnAuxiliar.Top = btnCompras.Top;
        }

        //BOTAO LOGOUt
        private void btnLogout_Click(object sender, EventArgs e)
        {
            //MOSTRAR MENSAGEM SE QUER SAIR AO CLIKAR NO LOGOUT
            DialogResult msg = MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            //SE O ESCOLHER SIM
            if (msg == DialogResult.Yes)
            {
                frm_Login frm_Login = new frm_Login();
                this.Hide();
                frm_Login.ShowDialog();
                this.Visible = false;
                this.Close();
            }
        }
    }
}
