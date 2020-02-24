using BLL;
using DAL;
using DGVPrinterHelper;
using Modelo;
using SistemaVendas.Apresentacao.Cadastro;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace SistemaVendas.Apresentacao
{
    public partial class frm_Categoria : Form
    {
        public int idCategoria = 0;

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
            DAO_Conexao con = new DAO_Conexao(DadoConexao.StringDeConexao);
            BLL_Categoria bll = new BLL_Categoria(con);
            dgvCategoria.DataSource = bll.Localizar(txtNome.Text);
            FormatarDGV();
            ContarLinhas();
            btnImprimirGrid.Enabled = true;
        }

        //BOTAO EXLUIR
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                DialogResult msgSN = MessageBox.Show("Deseja realmente excluir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
                //SE O ESCOLHER SIM FAÇA
                if (msgSN == DialogResult.Yes)
                {
                    try
                    {
                        //CRIAR CONEXAO
                        DAO_Conexao con = new DAO_Conexao(DadoConexao.StringDeConexao);
                        BLL_Categoria bll = new BLL_Categoria(con);

                        //EXCLUIR  UMA CATEGORIA
                        //PASSAR O CODIGO QUE ESTA NA TELA
                        bll.Excluir(Convert.ToInt32(txtId.Text));
                        MessageBox.Show("Categoria excluida com sucesso!");
                        BtnPesquisar_Click(sender, e);
                        txtId.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir Categoria, o registro está sendo utilizado em outro local \n " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione algum campo para poder excluir");
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
            //pega o id da data grid
            this.idCategoria = (Convert.ToInt32(dgvCategoria.CurrentRow.Cells[0].Value));

            //chamr modelo bll e dal 
            DAO_Conexao con = new DAO_Conexao(DadoConexao.StringDeConexao);
            BLL_Categoria bll = new BLL_Categoria(con);
            Model_Categoria modelo = bll.CarregaModeloCategoria(idCategoria);

            //CHAMAR O FORM Card e passar as informacoes
            frm_CadCategoria cadCategoria = new frm_CadCategoria();
            cadCategoria.btnAlterar.Visible = true;
            cadCategoria.btnSalvar.Visible = false;

            cadCategoria.txtId.Text = modelo.Id_categoria.ToString();
            cadCategoria.txtNome.Text = modelo.Nome.ToString();
            cadCategoria.ShowDialog();
            BtnPesquisar_Click(sender, e); // CHAMR O BOTAO PESQUISAR PARA ATUALIZAR A GRID
        }

        //METODO  DATA GRID
        private void FormatarDGV()
        {
            dgvCategoria.Columns[0].HeaderText = "Código"; //NOME DO CABEÇALHO
            dgvCategoria.Columns[0].Width = 50; //TAMANHO DA LARGURA
            dgvCategoria.Columns[1].HeaderText = "Categoria";
            dgvCategoria.Columns[1].Width = 200;
        }

        //botao minimizar
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //botao fechar
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


        //METODO CONTAR LINHAS
        private void ContarLinhas()
        {
            int total = dgvCategoria.Rows.Count;
            lblQtdTotal.Text = total.ToString();
        }

        private void btnImprimirGrid_Click(object sender, EventArgs e)
        {
            //MOSTRAR MENSAGEM SE QUER SAIR AO CLIKAR NO sair
            DialogResult msg = MessageBox.Show("Deseja imprimir a grid?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            //SE O ESCOLHER SIM
            if (msg == DialogResult.Yes)
            {
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "Relátorio de Categoria";
                printer.SubTitle = string.Format("Data: {0}", DateTime.Now);
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = "4P Tech";
                printer.FooterSpacing = 15;

                printer.PrintDataGridView(dgvCategoria);
            }
        }
    }
}
