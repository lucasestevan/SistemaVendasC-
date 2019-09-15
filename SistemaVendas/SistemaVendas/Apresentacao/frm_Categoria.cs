using SistemaVendas.Apresentacao.Cadastro;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaVendas.Apresentacao
{
    public partial class frm_Categoria : Form
    {
        public frm_Categoria()
        {
            InitializeComponent();
        }

        //BOTAO NOVO
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            frm_CadCategoria Categoria = new frm_CadCategoria();
            Categoria.ShowDialog();
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
                da = new SqlDataAdapter("SELECT * FROM Categoria", Modelo.ConexaoDados.con);
                //PREENCHER A TABELA
                da.Fill(dt);
                dgvCategoria.DataSource = dt.DefaultView;
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

        //BOTAO EXLUIR
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
                        cmd = new SqlCommand("sp_excluirCategoria", Modelo.ConexaoDados.con);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@id_categoria", txtId.Text);

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
                        MessageBox.Show("Erro ao Excluir os dados, existe vinculo desta Categoria " + ex.Message);
                        Modelo.ConexaoDados.fechar();
                    }
                }
            }
        }

        //EVENTO AO CLIKAR NA DATAGRID
        private void DgvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //AO CLIKAR NA GRID JOGAR PARA O CAMPO txt id
            txtId.Text = System.Convert.ToString(dgvCategoria.CurrentRow.Cells[0].Value);

            //HABILITAR BOTOES
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        //BOTAO ALTERAR
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            frm_CadCategoria cadCategoria = new frm_CadCategoria();
            //ABRIR O FORM DE CAD DE PACIENTE
            cadCategoria.Show();

            //HABILITAR CAMPOS e botao alterar NO FORM PARA PODER ALTERAR
            //cadCategoria.habilitarCampos();
            cadCategoria.btnAlterar.Enabled = true;
            cadCategoria.btnSalvar.Enabled = false;

            // ENVIAR PARA OS DADOS AO FORM PARA ALTERAR
            cadCategoria.txtId.Text = System.Convert.ToString(dgvCategoria.CurrentRow.Cells[0].Value);
            cadCategoria.txtNome.Text = System.Convert.ToString(dgvCategoria.CurrentRow.Cells[1].Value);

        }
    }
}
