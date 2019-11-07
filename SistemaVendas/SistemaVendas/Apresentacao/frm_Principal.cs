using SistemaVendas.Apresentacao.ControlesUsuario;
using System;
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
            controle_Menu1.BringToFront();
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

        //botao menu
        private void btnMenu_Click(object sender, EventArgs e)
        {
            pnAuxiliar.Height = btnMenu.Height;
            pnAuxiliar.Top = btnMenu.Top;
            controle_Menu1.BringToFront();
        }


        //botao vendas
        private void btnVendas_Click(object sender, EventArgs e)
        {
            pnAuxiliar.Height = btnVendas.Height;
            pnAuxiliar.Top = btnVendas.Top;
            controle_Venda1.BringToFront();
        }

        //botao Compras
        private void btnCompras_Click(object sender, EventArgs e)
        {
            pnAuxiliar.Height = btnCompras.Height;
            pnAuxiliar.Top = btnCompras.Top;
            controle_Compra1.BringToFront();
        }

        //BOTAO LOGOUt
        private void btnPagto_Click(object sender, EventArgs e)
        {
            pnAuxiliar.Height = btnPagto.Height;
            pnAuxiliar.Top = btnPagto.Top;
            controle_Pagamento1.BringToFront();
        }

        //BOTAO LOGOUt
        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            pnAuxiliar.Height = btnRelatorio.Height;
            pnAuxiliar.Top = btnRelatorio.Top;
            controle_Relatorio1.BringToFront();
        }

        //BOTAO LOGOUt
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            pnAuxiliar.Height = btnCadastro.Height;
            pnAuxiliar.Top = btnCadastro.Top;
            controle_Cadastro1.BringToFront();
        }
    }
}
