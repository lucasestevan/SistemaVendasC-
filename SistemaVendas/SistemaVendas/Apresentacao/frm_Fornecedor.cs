using Modelo;
using SistemaVendas.Apresentacao.Cadastro;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaVendas.Apresentacao
{
    public partial class frm_Fornecedor : Form
    {
        public frm_Fornecedor()
        {
            InitializeComponent();
        }

        //BOTAO NOVO
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            frm_CadFornecedor cadFornecedor = new frm_CadFornecedor();
            cadFornecedor.ShowDialog();
        }

        //botao pesquisar
        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        //METODO LISTAR
        private void Listar()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = default(SqlDataAdapter);

            try
            {
                Modelo.ConexaoDados.abrir();
                da = new SqlDataAdapter("Select * from Fornecedor", Modelo.ConexaoDados.con);
                //PREENCHER A TABELA
                da.Fill(dt);
                dgvFornecedor.DataSource = dt.DefaultView;
                da.Update(dt);

                //ContarLinhas();
                // FormatarDgColaborador();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no metodo listar " + ex.Message);
                Modelo.ConexaoDados.fechar();
            }
        }

        //BOTAO ALTERAR
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            frm_CadFornecedor cadFornecedor = new frm_CadFornecedor();
            //ABRIR O FORM DE CAD DE PACIENTE
            cadFornecedor.Show();

            //HABILITAR CAMPOS e botao alterar NO FORM PARA PODER ALTERAR
            //cadCategoria.habilitarCampos();
            cadFornecedor.btnAlterar.Enabled = true;
            cadFornecedor.btnSalvar.Enabled = false;

            // ENVIAR PARA OS DADOS AO FORM PARA ALTERAR
            cadFornecedor.txtId.Text = System.Convert.ToString(dgvFornecedor.CurrentRow.Cells[0].Value);
            
            cadFornecedor.txtNome.Text = System.Convert.ToString(dgvFornecedor.CurrentRow.Cells[1].Value);
            cadFornecedor.txtCPFCNPJ.Text = System.Convert.ToString(dgvFornecedor.CurrentRow.Cells[2].Value);
            cadFornecedor.txtTel.Text = System.Convert.ToString(dgvFornecedor.CurrentRow.Cells[3].Value);
            cadFornecedor.txtEmail.Text = System.Convert.ToString(dgvFornecedor.CurrentRow.Cells[4].Value);
        }

        //BOTAO EXCLUIR
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = default(SqlCommand);

            if (txtId.Text != "")
            {
                DialogResult msgSN = MessageBox.Show("Deseja realmente excluir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
                //SE O ESCOLHER SIM FAÇA
                if (msgSN == DialogResult.Yes)
                {
                    try
                    {
                        Modelo.ConexaoDados.abrir();
                        cmd = new SqlCommand("sp_excluirFornecedor", Modelo.ConexaoDados.con);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@id_fornecedor", txtId.Text);

                        cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = (System.Data.ParameterDirection)2;
                        cmd.ExecuteNonQuery();

                        string msg = cmd.Parameters["@mensagem"].Value.ToString();
                        MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3);
                        Listar();

                        btnAlterar.Enabled = false;
                        btnExcluir.Enabled = false;
                        txtId.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao Excluir os dados, existe vinculo deste FORNECEDOR " + ex.Message);
                        Modelo.ConexaoDados.fechar();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione o campo para poder excluir!");
            }
        }

        //EVENTO AO CLIKAR NA GRID
        private void DgvFornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //AO CLIKAR NA GRID JOGAR PARA O CAMPO ID exame
            txtId.Text = System.Convert.ToString(dgvFornecedor.CurrentRow.Cells[0].Value);

            //HABILITAR BOTOES
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
        }
    }
}
