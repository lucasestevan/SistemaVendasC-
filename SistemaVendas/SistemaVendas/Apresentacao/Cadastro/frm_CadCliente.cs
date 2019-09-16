using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaVendas.Apresentacao.Cadastro
{
    public partial class frm_CadCliente : Form
    {
        public frm_CadCliente()
        {
            InitializeComponent();
        }

        //botao salvar
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = default(SqlCommand);
            //SE OS CAMPOS NAO FOREM VAZIOS FAÇA..
            if (txtNome.Text != "" &&
                txtIdEnde.Text != "" &&
                txtCPF.Text != "")
            {
                try
                {
                    Modelo.ConexaoDados.abrir();
                    //CHAMAR O PROCEDIMENTO SALVAR cliente
                    cmd = new SqlCommand("sp_salvarcliente", Modelo.ConexaoDados.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@cpf", txtCPF.Text);
                    cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@observacao", txtObs.Text);
                    cmd.Parameters.AddWithValue("@id_endereco", txtIdEnde.Text);
                    cmd.Parameters.AddWithValue("@numeroEnde", txtNumero.Text);
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

        //botao localizar endereco
        private void BtnEndereco_Click(object sender, EventArgs e)
        {
            txtCep.Text = "";
            txtRua.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtUf.Text = "";


            frm_Endereco endereco = new frm_Endereco();
            //DESABILITAR OS BOTOES PRIMEIRO E DPS CHAMAR O FORM enderecoO
            endereco.btnAlterar.Visible = false;
            endereco.btnExcluir.Visible = false;
            endereco.btnSelecionar.Visible = true;
            endereco.ShowDialog();

            //PEGA O QUE ESTÁ NA CLASSE ESTATICA E JOGA NO TXT NOME E ID colaborador
            txtIdEnde.Text = Modelo.Estaticos.IdEnde;
            txtCep.Text = Modelo.Estaticos.cep;
            txtRua.Text = Modelo.Estaticos.rua;
            txtBairro.Text = Modelo.Estaticos.bairro;
            txtCidade.Text = Modelo.Estaticos.cidade;
            txtUf.Text = Modelo.Estaticos.uf;
        }

        //botao alterar
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = default(SqlCommand);
            //SE OS CAMPOS NAO FOREM VAZIOS FAÇA..
            if (txtNome.Text != "" &&
                txtCPF.Text != "")
                try
                {
                    Modelo.ConexaoDados.abrir();
                    cmd = new SqlCommand("sp_alterarCliente", Modelo.ConexaoDados.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_cliente", txtId.Text);
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@cpf", txtCPF.Text);
                    cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@observacao", txtObs.Text);
                    cmd.Parameters.AddWithValue("@id_endereco", txtIdEnde.Text);
                    cmd.Parameters.AddWithValue("@numeroEnde", txtNumero.Text);
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
