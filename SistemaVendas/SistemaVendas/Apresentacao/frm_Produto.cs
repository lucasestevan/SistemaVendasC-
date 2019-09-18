using SistemaVendas.Apresentacao.Cadastro;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaVendas.Apresentacao
{
    public partial class frm_Produto : Form
    {
        public frm_Produto()
        {
            InitializeComponent();
        }

        private void Frm_Produto_Load(object sender, EventArgs e)
        {

        }

        //BOTAO NOVO
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            frm_CadProduto cadProduto = new frm_CadProduto();
            cadProduto.ShowDialog();
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
                da = new SqlDataAdapter("SELECT * FROM Produto", Modelo.ConexaoDados.con);
                //PREENCHER A TABELA
                da.Fill(dt);
                dgvProduto.DataSource = dt.DefaultView;
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
        private void DgvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //AO CLIKAR NA GRID JOGAR PARA O CAMPO ID exame
            txtId.Text = System.Convert.ToString(dgvProduto.CurrentRow.Cells[0].Value);

            //HABILITAR BOTOES
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
        }


        //BOTAO ALTERAR
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            frm_CadProduto cadProduto = new frm_CadProduto();
            //ABRIR O FORM DE CAD DE PRODUTO
            cadProduto.Show();

            //HABILITAR CAMPOS e botao alterar NO FORM PARA PODER ALTERAR
            //cadCategoria.habilitarCampos();
            cadProduto.btnAlterar.Enabled = true;
            cadProduto.btnSalvar.Enabled = false;

            // ENVIAR PARA OS DADOS AO FORM PARA ALTERAR
            cadProduto.txtId.Text = System.Convert.ToString(dgvProduto.CurrentRow.Cells[0].Value);
            cadProduto.txtNome.Text = System.Convert.ToString(dgvProduto.CurrentRow.Cells[1].Value);
            cadProduto.txtPreco.Text = System.Convert.ToString(dgvProduto.CurrentRow.Cells[2].Value);
            cadProduto.txtDesc.Text = System.Convert.ToString(dgvProduto.CurrentRow.Cells[3].Value);
            cadProduto.cmbCategoria.Text = System.Convert.ToString(dgvProduto.CurrentRow.Cells[4].Value);
            cadProduto.cmbFornecedor.Text = System.Convert.ToString(dgvProduto.CurrentRow.Cells[5].Value);
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
                        cmd = new SqlCommand("sp_excluirProduto", Modelo.ConexaoDados.con);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@id_produto", txtId.Text);

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
                        MessageBox.Show("Erro ao Excluir os dados, existe vinculo deste Produto " + ex.Message);
                        Modelo.ConexaoDados.fechar();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione o campo para poder excluir");
            }
        }
    }
}
