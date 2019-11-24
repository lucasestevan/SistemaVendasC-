using BLL;
using DAL;
using Modelo;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaVendas
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }
        //BOTAO LOGIN
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // CRIAR VARIAVEL
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;


            //VERIFICAR SE OS CAMPOS ESTAO VAZIOS
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Preencha os campos vazios!!");

                //SE NAO ESTIVER VAZIO FAZER CONEXAO COM O BD
            }
            else
            {
                //chamr bll 
                DAO_Conexao con = new DAO_Conexao(DadoConexao.StringDeConexao);
                BLL_Login bll = new BLL_Login(con);
                bll.Login(usuario, senha);

                if (bll.Existe)
                {
                    //CHAMAR O FORM Card e passar as informacoes
                    frm_Principal f = new frm_Principal();
                    this.Hide();

                    f.lblUsuario.Text = this.txtUsuario.Text;

                    f.ShowDialog();
                    this.Close();
                }
                else 
                {
                    MessageBox.Show("Usuário ou senha incorretos!");
                }
            }
        }

        //evento AO APERTAR O ENTER
        private void Frm_Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnLogin_Click(sender, e);
            }
        }


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

        //evento ao focar no txt
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            pn1.BackColor = Color.FromArgb(78, 184, 206);
            txtUsuario.ForeColor = Color.FromArgb(78, 184, 206);

            pn2.BackColor = Color.WhiteSmoke;
            txtSenha.ForeColor = Color.WhiteSmoke;
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '*';
            pn2.BackColor = Color.FromArgb(78, 184, 206);
            txtSenha.ForeColor = Color.FromArgb(78, 184, 206);

            pn1.BackColor = Color.WhiteSmoke;
            txtUsuario.ForeColor = Color.WhiteSmoke;
        }
    }
}
