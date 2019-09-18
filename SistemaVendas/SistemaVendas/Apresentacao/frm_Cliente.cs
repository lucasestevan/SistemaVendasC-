using SistemaVendas.Apresentacao.Cadastro;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaVendas.Apresentacao
{
    public partial class frm_Cliente : Form
    {
        public frm_Cliente()
        {
            InitializeComponent();
        }

        //BOTAO NOVO
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            frm_CadCliente cadCliente = new frm_CadCliente();
            cadCliente.ShowDialog();
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
                da = new SqlDataAdapter(@"Select cli.id_cliente, cli.nome, cli.cpf, cli.telefone, cli.email, cli.observacao, cli.id_endereco, Ende.cep, ende.rua, cli.numeroEnde, ende.bairro, Ende.cidade, Ende.uf from Cliente as Cli INNER JOIN Endereco as Ende on cli.id_endereco = Ende.id_endereco", Modelo.ConexaoDados.con);
                //PREENCHER A TABELA
                da.Fill(dt);
                dgvCliente.DataSource = dt.DefaultView;
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

        //EVENTO AO CLIKAR NA GRID
        private void DgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //AO CLIKAR NA GRID JOGAR PARA O CAMPO ID exame
            txtId.Text = System.Convert.ToString(dgvCliente.CurrentRow.Cells[0].Value);

            //HABILITAR BOTOES
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        //BOTAO ALTERAR
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            frm_CadCliente cadCliente = new frm_CadCliente();
            //ABRIR O FORM DE CAD DE PACIENTE
            cadCliente.Show();

            //HABILITAR CAMPOS e botao alterar NO FORM PARA PODER ALTERAR
            //cadCategoria.habilitarCampos();
            cadCliente.btnAlterar.Enabled = true;
            cadCliente.btnSalvar.Enabled = false;

            // ENVIAR PARA OS DADOS AO FORM PARA ALTERAR
            cadCliente.txtId.Text = System.Convert.ToString(dgvCliente.CurrentRow.Cells[0].Value);
            cadCliente.txtNome.Text = System.Convert.ToString(dgvCliente.CurrentRow.Cells[1].Value);
            cadCliente.txtCPF.Text = System.Convert.ToString(dgvCliente.CurrentRow.Cells[2].Value);
            cadCliente.txtTelefone.Text = System.Convert.ToString(dgvCliente.CurrentRow.Cells[3].Value);
            cadCliente.txtEmail.Text = System.Convert.ToString(dgvCliente.CurrentRow.Cells[4].Value);
            cadCliente.txtObs.Text = System.Convert.ToString(dgvCliente.CurrentRow.Cells[5].Value);
            cadCliente.txtIdEnde.Text = System.Convert.ToString(dgvCliente.CurrentRow.Cells[6].Value);
            cadCliente.txtCep.Text = System.Convert.ToString(dgvCliente.CurrentRow.Cells[7].Value); //cep
            cadCliente.txtRua.Text = System.Convert.ToString(dgvCliente.CurrentRow.Cells[8].Value); //RUA
            cadCliente.txtNumero.Text = System.Convert.ToString(dgvCliente.CurrentRow.Cells[9].Value); // NUMERO
            cadCliente.txtBairro.Text = System.Convert.ToString(dgvCliente.CurrentRow.Cells[10].Value); // BAIRRO
            cadCliente.txtCidade.Text = System.Convert.ToString(dgvCliente.CurrentRow.Cells[11].Value);// CIDADE//
            cadCliente.txtUf.Text = System.Convert.ToString(dgvCliente.CurrentRow.Cells[12].Value); //UF

        }

        //botao excluir
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
                        cmd = new SqlCommand("sp_excluirCliente", Modelo.ConexaoDados.con);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@id_cliente", txtId.Text);

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
                        MessageBox.Show("Erro ao Excluir os dados, existe vinculo deste Endereço " + ex.Message);
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

