using SistemaVendas.Apresentacao.Cadastro;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaVendas.Apresentacao
{
    public partial class frm_Colaborador : Form
    {
        public frm_Colaborador()
        {
            InitializeComponent();
        }

        //BOTAO NOVO
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            frm_CadColaborador cadColaborador = new frm_CadColaborador();
            cadColaborador.ShowDialog();
        }

        //BOTAO PESQUISAR
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
                da = new SqlDataAdapter("SELECT * FROM Colaborador", Modelo.ConexaoDados.con);
                //PREENCHER A TABELA
                da.Fill(dt);
                dgvColaborador.DataSource = dt.DefaultView;
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

        //EVENTO AO CLIKAR NA DATAGRID
        private void DgvColaborador_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //AO CLIKAR NA GRID JOGAR PARA O CAMPO ID exame
            txtId.Text = System.Convert.ToString(dgvColaborador.CurrentRow.Cells[0].Value);

            //HABILITAR BOTOES
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        //BOTAO ALTERAR
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            frm_CadColaborador cadColaborador = new frm_CadColaborador();
            //ABRIR O FORM DE CAD DE PACIENTE
            cadColaborador.Show();

            //HABILITAR CAMPOS e botao alterar NO FORM PARA PODER ALTERAR
            //cadCategoria.habilitarCampos();
            cadColaborador.btnAlterar.Enabled = true;
            cadColaborador.btnSalvar.Enabled = false;

            // ENVIAR PARA OS DADOS AO FORM PARA ALTERAR
            cadColaborador.txtId.Text = System.Convert.ToString(dgvColaborador.CurrentRow.Cells[0].Value);
            cadColaborador.txtNome.Text = System.Convert.ToString(dgvColaborador.CurrentRow.Cells[1].Value);
            cadColaborador.txtCPF.Text = System.Convert.ToString(dgvColaborador.CurrentRow.Cells[2].Value);
            cadColaborador.txtSenha.Text = System.Convert.ToString(dgvColaborador.CurrentRow.Cells[3].Value);
            cadColaborador.txtDesc.Text = System.Convert.ToString(dgvColaborador.CurrentRow.Cells[4].Value);

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
                        cmd = new SqlCommand("sp_excluirColaborador", Modelo.ConexaoDados.con);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@id_colaborador", txtId.Text);

                        cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = (System.Data.ParameterDirection)2;
                        cmd.ExecuteNonQuery();

                        string msg = cmd.Parameters["@mensagem"].Value.ToString();
                        MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3);
                        Listar();

                        btnAlterar.Enabled = false;
                        btnExcluir.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao Excluir os dados " + ex.Message);
                        Modelo.ConexaoDados.fechar();
                    }
                }
            }
        }
    }
}
