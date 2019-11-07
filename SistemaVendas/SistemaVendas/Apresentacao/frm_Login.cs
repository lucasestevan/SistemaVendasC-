using SistemaVendas.Apresentacao;
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
            /*// CRIAR VARIAVEL
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
                //CONECTAR NO BANCO E NA PROCEDURE LOGIN
                SqlCommand cmd = new SqlCommand("sp_Login", Modelo.ConexaoDados.con);
                try
                {
                    Modelo.ConexaoDados.abrir();
                    cmd.CommandType = (System.Data.CommandType)4; //SE FOR IGUAL A 4 ELE CONSEGUIU ENCONTRAR A INFORMACAO
                    cmd.Parameters.AddWithValue("@nome", usuario);
                    cmd.Parameters.AddWithValue("@senha", senha);
                    cmd.Parameters.Add("@msg", SqlDbType.VarChar, 100).Direction = (System.Data.ParameterDirection)2;

                    //EXECUTAR NOSSA CONSULTA
                    cmd.ExecuteNonQuery();
                                       
                    else
                    {*/
            frm_Principal Menu = new frm_Principal();
            this.Hide();
            Menu.ShowDialog();
            this.Close();
            /*}
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao fazer login " + ex.Message, "Erro");
            Modelo.ConexaoDados.fechar();
        }
    }*/
        }

        //AO APERTAR O ENTER
        private void Frm_Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnLogin_Click(sender, e);
            }
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            pn1.BackColor = Color.FromArgb(78, 184, 206);
            txtUsuario.ForeColor = Color.FromArgb(78, 184, 206);

            pn2.BackColor = Color.WhiteSmoke;
            txtSenha.ForeColor = Color.WhiteSmoke;
        }

        private void txtSenha_Click(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '*';
            pn2.BackColor = Color.FromArgb(78, 184, 206);
            txtSenha.ForeColor = Color.FromArgb(78, 184, 206);

            pn1.BackColor = Color.WhiteSmoke;
            txtUsuario.ForeColor = Color.WhiteSmoke;
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
    }
}
