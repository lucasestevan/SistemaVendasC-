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
            controle_Menu1.CarregarGrid1();//carregar a grid
            controle_Menu1.CarregarGrid2();//carregar a grid
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

        //BOTAO pagto
        private void btnPagto_Click(object sender, EventArgs e)
        {
            pnAuxiliar.Height = btnPagto.Height;
            pnAuxiliar.Top = btnPagto.Top;
            controle_Pagamento1.BringToFront();
        }

        //BOTAO relaotiro
        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            pnAuxiliar.Height = btnRelatorio.Height;
            pnAuxiliar.Top = btnRelatorio.Top;
            controle_Relatorio1.BringToFront();
        }

        //BOTAO cadastro
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            pnAuxiliar.Height = btnCadastro.Height;
            pnAuxiliar.Top = btnCadastro.Top;
            controle_Cadastro1.BringToFront();
        }

        //botao config
        private void btnConfig_Click(object sender, EventArgs e)
        {
            pnAuxiliar.Height = btnConfig.Height;
            pnAuxiliar.Top = btnConfig.Top;
            controle_Config1.BringToFront();
        }

        private void frm_Principal_Load(object sender, EventArgs e)
        {
            btnMenu_Click(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToShortDateString();
        }

        //botao minimizar
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
    }
}
