using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaVendas.Apresentacao.Cadastro
{
    public partial class frm_CadProduto : Form
    {
        public frm_CadProduto()
        {
            InitializeComponent();
        }

        //LOAD DO FORM
        private void Frm_CadProduto_Load(object sender, EventArgs e)
        {
            listarComboboxBox();
        }

        //METODO LISTAR COMBOBOX
        public void listarComboboxBox()
        {
            SqlCommand cmd = default(SqlCommand);
            try
            {
                Modelo.ConexaoDados.abrir();
                cmd = new SqlCommand("select * from Categoria order by nome", Modelo.ConexaoDados.con);
                SqlDataReader dados = cmd.ExecuteReader(); // executa a consulta
                DataTable dt = new DataTable(); //CRIA A TABELA GENERICA
                dt.Load(dados);//CARREGA OS DADOS DA TABELA QUE CRIEI
                cmbCategoria.DisplayMember = "nome"; // PEGA O NOME
                cmbCategoria.ValueMember = "id_categoria"; //PEGA O ID
                cmbCategoria.DataSource = dt;
                cmbCategoria.Text = "Seleciona uma categoria";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
                Modelo.ConexaoDados.fechar();
            }
        }

        // BOTAO SALVAR
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = default(SqlCommand);
            //SE OS CAMPOS NAO FOREM VAZIOS FAÇA..
            if (txtNome.Text != "" &&
                txtPreco.Text != "" &&
                cmbCategoria.Text != "")
            {
                try
                {
                    Modelo.ConexaoDados.abrir();
                    //CHAMAR O PROCEDIMENTO SALVAR COLABORADOR
                    cmd = new SqlCommand("sp_salvarProduto", Modelo.ConexaoDados.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@preco", Convert.ToDecimal(txtPreco.Text));
                    cmd.Parameters.AddWithValue("@id_categoria", cmbCategoria.SelectedValue);
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
                txtPreco.Text != "" &&
                cmbCategoria.Text != "")
                try
                {
                    Modelo.ConexaoDados.abrir();
                    cmd = new SqlCommand("sp_alterarProduto", Modelo.ConexaoDados.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_produto", txtId.Text);
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@preco", Convert.ToDecimal(txtPreco.Text));
                    cmd.Parameters.AddWithValue("@id_categoria", cmbCategoria.SelectedValue);
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
