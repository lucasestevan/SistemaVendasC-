using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVendas.Apresentacao.Cadastro
{
    public partial class frm_CadProduto : Form
    {
        public frm_CadProduto()
        {
            InitializeComponent();
        }

        private void Frm_CadProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaVendaDataSet.Categoria'. Você pode movê-la ou removê-la conforme necessário.
            // this.categoriaTableAdapter.Fill(this.sistemaVendaDataSet.Categoria);
            // TODO: esta linha de código carrega dados na tabela 'sistemaVendaDataSet.Categoria'. Você pode movê-la ou removê-la conforme necessário.
            // this.categoriaTableAdapter.Fill(this.sistemaVendaDataSet.Categoria);
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = ("server=DESKTOP-628SFJB; database= SistemaVenda; Integrated Security = True");
            cn.Open();
            SqlCommand com1 = new SqlCommand();
            com1.Connection = cn;
            com1.CommandText = "select nome from Categoria";
            SqlDataReader dr = com1.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cmbCategoria.DisplayMember = "nome"; // PEGA O NOME
            cmbCategoria.ValueMember = "id_categoria"; //PEGA O ID
            cmbCategoria.DataSource = dt;
                        
        }



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
                    cmd.Parameters.AddWithValue("@preco", Convert.ToInt16(txtPreco.Text));
                    cmd.Parameters.AddWithValue("@id_categoria", cmbCategoria.ValueMember);
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
    }
}
