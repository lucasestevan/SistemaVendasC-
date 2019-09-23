using SistemaVendas.Apresentacao;
using System;
using System.Data;
using System.Data.SqlClient;
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

                    string msg = System.Convert.ToString(cmd.Parameters["@msg"].Value);
                    MessageBox.Show(msg);

                    //VERIFICAR QUAL MENSAGEM RETORNOU
                    if (msg == "Dados Incorretos")
                    {
                        this.txtUsuario.Clear();
                        this.txtSenha.Clear();
                        this.txtUsuario.Focus();
                    }
                    else
                    {
                        frm_Menu Menu = new frm_Menu();
                        this.Hide();
                        Menu.ShowDialog();
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao fazer login " + ex.Message, "Erro");
                    Modelo.ConexaoDados.fechar();
                }
            }
        }

        //AO APERTAR O ENTER
        private void Frm_Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnLogin_Click(sender, e);
            }
        }
    }
}
