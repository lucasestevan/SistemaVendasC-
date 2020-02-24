using BLL;
using DAL;
using DGVPrinterHelper;
using Modelo;
using SistemaVendas.Apresentacao.Cadastro;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaVendas.Apresentacao
{
    public partial class frm_Colaborador : Form
    {
        public int idColaborador = 0;

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
            DAO_Conexao con = new DAO_Conexao(DadoConexao.StringDeConexao);
            BLL_Colaborador bll = new BLL_Colaborador(con);
            dgvColaborador.DataSource = bll.Localizar(txtNome.Text);
            FormatarDGV(); //FORMATA O DATA GRID
            ContarLinhas();
            btnImprimirGrid.Enabled = true;

        }

        //BOTAO EXCLUIR
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
                        BLL_Colaborador bll = new BLL_Colaborador(con);

                        //PASSAR O CODIGO QUE ESTA NA TELA
                        bll.Excluir(Convert.ToInt32(txtId.Text));
                        MessageBox.Show("Colaborador excluido com sucesso!");
                        BtnPesquisar_Click(sender, e); //RECARREGA A TELA COM O ITEM EXCLUIDO
                        txtId.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir Colaborador, o registro está sendo utilizado em outro local \n " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione algum campo para poder excluir");
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
            //pega o id da data grid
            this.idColaborador = (Convert.ToInt32(dgvColaborador.CurrentRow.Cells[0].Value));

            //chamr modelo bll e dal 
            DAO_Conexao con = new DAO_Conexao(DadoConexao.StringDeConexao);
            BLL_Colaborador bll = new BLL_Colaborador(con);
            Model_Colaborador modelo = bll.CarregaModeloColaborador(idColaborador);

            //CHAMAR O FORM Card e passar as informacoes
            frm_CadColaborador cadColaborador = new frm_CadColaborador();
            cadColaborador.btnAlterar.Visible = true;
            cadColaborador.btnSalvar.Visible = false;

            cadColaborador.txtId.Text = modelo.IdColaborador.ToString();//id
            cadColaborador.txtNome.Text = modelo.Nome.ToString(); //nome
            cadColaborador.txtCPF.Text = modelo.Cpf.ToString();// cpf
            cadColaborador.txtSenha.Enabled = false; //senha
            cadColaborador.txtTelefone.Text = modelo.Telefone.ToString(); // telefone 
            cadColaborador.txtCel.Text = modelo.Celular.ToString(); // celular 
            cadColaborador.txtDesc.Text = modelo.Descricao.ToString(); // descricao 
            cadColaborador.ShowDialog();
            this.BtnPesquisar_Click(sender, e); // CHAMR O BOTAO PESQUISAR PARA ATUALIZAR A GRID
        }

        //METODO formatar  DATA GRID
        private void FormatarDGV()
        {
            dgvColaborador.Columns[0].HeaderText = "Código"; //NOME DO CABEÇALHO
            dgvColaborador.Columns[0].Width = 50; //TAMANHO DA LARGURA
            dgvColaborador.Columns[1].HeaderText = "Nome";
            dgvColaborador.Columns[1].Width = 130;
            dgvColaborador.Columns[2].HeaderText = "CPF";
            dgvColaborador.Columns[2].Width = 90;
            dgvColaborador.Columns[3].Visible = false; //senha
            dgvColaborador.Columns[4].HeaderText = "Telefone";
            dgvColaborador.Columns[4].Width = 90;
            dgvColaborador.Columns[5].HeaderText = "Celular";
            dgvColaborador.Columns[5].Width = 120;
            dgvColaborador.Columns[6].HeaderText = "Descrição";
            dgvColaborador.Columns[6].Width = 120;
        }

        //BOTAO APAGAR SENHA
        private void BtnSenha_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                DialogResult msgSN = MessageBox.Show("Deseja realmente apagar a senha?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
                //SE O ESCOLHER SIM FAÇA
                if (msgSN == DialogResult.Yes)
                {
                    try
                    {
                        //LEITURA DOS DADOS
                        Model_Colaborador modelo = new Model_Colaborador();
                        modelo.IdColaborador = Convert.ToInt32(txtId.Text);
                        modelo.Senha = Convert.ToString("");
                        //OBJ PARA GRAVAR NO BANCO
                        DAO_Conexao con = new DAO_Conexao(DadoConexao.StringDeConexao);
                        BLL_Colaborador bll = new BLL_Colaborador(con);

                        //CADASTRAR UMA CATEGORIA
                        bll.ApagarSenha(modelo);
                        MessageBox.Show("Senha apagada com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao apagar Senha \n" + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione algum campo para poder excluir");
            }
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
            int total = dgvColaborador.Rows.Count;
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
                printer.Title = "Relátorio de Colaborador";
                printer.SubTitle = string.Format("Data: {0}", DateTime.Now);
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = "4P Tech";
                printer.FooterSpacing = 15;

                printer.PrintDataGridView(dgvColaborador);
            }
        }
    }
}
