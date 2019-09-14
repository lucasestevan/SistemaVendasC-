using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaVendas.Apresentacao.Cadastro
{
    public partial class frm_CadColaborador : Form
    {
        public frm_CadColaborador()
        {
            InitializeComponent();
        }

        //BOTAO SALVAR
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = default(SqlCommand);
            //SE OS CAMPOS NAO FOREM VAZIOS FAÇA..
            if (txtNome.Text != "" &&
                txtSenha.Text != "" &&
                txtCPF.Text.Trim() != "   ,   ,   -  ")
            {
                try
                {
                    Modelo.ConexaoDados.abrir();
                    //CHAMAR O PROCEDIMENTO SALVAR COLABORADOR
                    cmd = new SqlCommand("sp_salvarColaborador", Modelo.ConexaoDados.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@senha", txtSenha.Text);
                    cmd.Parameters.AddWithValue("@cpf", txtCPF.Text);
                    cmd.Parameters.AddWithValue("@descricao", txtDesc.Text);
                    cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = (System.Data.ParameterDirection)2;
                    cmd.ExecuteNonQuery();
                    string msg = cmd.Parameters["@mensagem"].Value.ToString();
                    MessageBox.Show(msg, "Aviso");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Salvar os dados " + ex.Message);
                    Modelo.ConexaoDados.fechar();
                }
            }
            //SE OS CAMPOS ESTIVEREM VAZIOS MOSTRE
            else
            {
                MessageBox.Show("Insira os dados nos campos vazios!!");
            }
        }

        //BOTAO ALTERAR
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = default(SqlCommand);
            //SE OS CAMPOS NAO FOREM VAZIOS FAÇA..
            if (txtNome.Text != "" &&
                txtSenha.Text != "" &&
                txtCPF.Text.Trim() != "")
                try
                {
                    Modelo.ConexaoDados.abrir();
                    cmd = new SqlCommand("sp_alterarColaborador", Modelo.ConexaoDados.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_colaborador", txtId.Text);
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@senha", txtSenha.Text);
                    cmd.Parameters.AddWithValue("@cpf", txtCPF.Text);
                    cmd.Parameters.AddWithValue("@descricao", txtDesc.Text);
                    cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = (System.Data.ParameterDirection)2;
                    cmd.ExecuteNonQuery();

                    string msg = cmd.Parameters["@mensagem"].Value.ToString();
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao alterar os dados" + ex.Message);
                    Modelo.ConexaoDados.fechar();
                }
            else
            {
                MessageBox.Show("Insira os dados nos campos vazios!!");
            }
        }
    }
}
