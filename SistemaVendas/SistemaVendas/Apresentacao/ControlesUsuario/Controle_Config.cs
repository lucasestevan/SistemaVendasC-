using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace SistemaVendas.Apresentacao.ControlesUsuario
{
    public partial class Controle_Config : UserControl
    {
        public Controle_Config()
        {
            InitializeComponent();
        }

        //BOTAO BACKUP
        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog d = new SaveFileDialog();
                d.Filter = "Backup Files|*.bak";
                d.ShowDialog();
                if (d.FileName != "")
                {
                    String nomeBanco = "SistemaVenda";
                    String localBackup = d.FileName;
                    String conexao = DadoConexao.StringDeConexao; // @"Data Source=DESKTOP-H923SLO\SQLEXPRESS;Initial Catalog = SistemaVenda; Integrated Security = True";

                    SQLServerBackup.BackupDataBase(conexao, nomeBanco, localBackup);
                    MessageBox.Show("Backup realizado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar o backup " + ex);
            }
        }

        //BOTAO RESTAURAR
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog d = new OpenFileDialog();
                d.Filter = "Backup Files|*.bak";
                d.ShowDialog();
                if (d.FileName != "")
                {
                    String nomeBanco = "SistemaVenda";
                    String localBackup = d.FileName;
                    String conexao = DadoConexao.StringDeConexao; // @"Data Source=DESKTOP-H923SLO\SQLEXPRESS;Initial Catalog = SistemaVenda; Integrated Security = True";

                    SQLServerBackup.RestauraDatabase(conexao, nomeBanco, localBackup);
                    MessageBox.Show("Backup restaurado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao restaurar o backup " + ex);
            }
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("- Salvar o backup em uma pasta que esteja com todas as permissões liberadas.\n\n" +
                "- Não utilizar o sistema no momento da geração ou restauração do backup.\n\n" +
                "- Não desligar o computador no momento da geração ou restauração do backup.\n\n" +
                "- Recomendamos a salvar o backup em um local externo.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
        }
    }
}
