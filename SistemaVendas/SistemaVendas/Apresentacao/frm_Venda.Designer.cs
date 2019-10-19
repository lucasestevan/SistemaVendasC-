namespace SistemaVendas.Apresentacao
{
    partial class frm_Venda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.gbCodigo = new System.Windows.Forms.GroupBox();
            this.txtIdVenda = new System.Windows.Forms.TextBox();
            this.btnPesquisarCod = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.btnPesquisaData = new System.Windows.Forms.Button();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.dtInicial = new System.Windows.Forms.DateTimePicker();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.btnPesquisaCliente = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.rbGeral = new System.Windows.Forms.RadioButton();
            this.rbData = new System.Windows.Forms.RadioButton();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.dgvVenda = new System.Windows.Forms.DataGridView();
            this.btnPesquisarGeral = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.gbCodigo.SuspendLayout();
            this.gbData.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(470, 252);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 63;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(470, 213);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionar.TabIndex = 62;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.BtnSelecionar_Click);
            // 
            // gbCodigo
            // 
            this.gbCodigo.Controls.Add(this.txtIdVenda);
            this.gbCodigo.Controls.Add(this.btnPesquisarCod);
            this.gbCodigo.Location = new System.Drawing.Point(150, 3);
            this.gbCodigo.Name = "gbCodigo";
            this.gbCodigo.Size = new System.Drawing.Size(300, 102);
            this.gbCodigo.TabIndex = 61;
            this.gbCodigo.TabStop = false;
            this.gbCodigo.Text = "Código";
            // 
            // txtIdVenda
            // 
            this.txtIdVenda.Location = new System.Drawing.Point(13, 18);
            this.txtIdVenda.Name = "txtIdVenda";
            this.txtIdVenda.Size = new System.Drawing.Size(281, 20);
            this.txtIdVenda.TabIndex = 48;
            // 
            // btnPesquisarCod
            // 
            this.btnPesquisarCod.Location = new System.Drawing.Point(219, 50);
            this.btnPesquisarCod.Name = "btnPesquisarCod";
            this.btnPesquisarCod.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarCod.TabIndex = 47;
            this.btnPesquisarCod.Text = "Pesquisar";
            this.btnPesquisarCod.UseVisualStyleBackColor = true;
            this.btnPesquisarCod.Click += new System.EventHandler(this.BtnPesquisarCod_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(470, 171);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizar.TabIndex = 60;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.BtnVisualizar_Click);
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.btnPesquisaData);
            this.gbData.Controls.Add(this.dtFinal);
            this.gbData.Controls.Add(this.dtInicial);
            this.gbData.Location = new System.Drawing.Point(153, 3);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(300, 102);
            this.gbData.TabIndex = 59;
            this.gbData.TabStop = false;
            this.gbData.Text = "Data";
            // 
            // btnPesquisaData
            // 
            this.btnPesquisaData.Location = new System.Drawing.Point(219, 52);
            this.btnPesquisaData.Name = "btnPesquisaData";
            this.btnPesquisaData.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisaData.TabIndex = 47;
            this.btnPesquisaData.Text = "Pesquisar";
            this.btnPesquisaData.UseVisualStyleBackColor = true;
            this.btnPesquisaData.Click += new System.EventHandler(this.BtnPesquisaData_Click);
            // 
            // dtFinal
            // 
            this.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinal.Location = new System.Drawing.Point(140, 19);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(105, 20);
            this.dtFinal.TabIndex = 1;
            // 
            // dtInicial
            // 
            this.dtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicial.Location = new System.Drawing.Point(7, 19);
            this.dtInicial.Name = "dtInicial";
            this.dtInicial.Size = new System.Drawing.Size(99, 20);
            this.dtInicial.TabIndex = 0;
            this.dtInicial.Value = new System.DateTime(2019, 10, 3, 0, 0, 0, 0);
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.btnPesquisaCliente);
            this.gbCliente.Controls.Add(this.txtNome);
            this.gbCliente.Location = new System.Drawing.Point(152, 3);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(300, 102);
            this.gbCliente.TabIndex = 58;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // btnPesquisaCliente
            // 
            this.btnPesquisaCliente.Location = new System.Drawing.Point(219, 49);
            this.btnPesquisaCliente.Name = "btnPesquisaCliente";
            this.btnPesquisaCliente.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisaCliente.TabIndex = 46;
            this.btnPesquisaCliente.Text = "Pesquisar";
            this.btnPesquisaCliente.UseVisualStyleBackColor = true;
            this.btnPesquisaCliente.Click += new System.EventHandler(this.BtnPesquisaCliente_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(7, 18);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(287, 20);
            this.txtNome.TabIndex = 42;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCodigo);
            this.groupBox1.Controls.Add(this.rbGeral);
            this.groupBox1.Controls.Add(this.rbData);
            this.groupBox1.Controls.Add(this.rbCliente);
            this.groupBox1.Location = new System.Drawing.Point(9, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 111);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Location = new System.Drawing.Point(7, 36);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(81, 17);
            this.rbCodigo.TabIndex = 3;
            this.rbCodigo.Text = "Cód. Venda";
            this.rbCodigo.UseVisualStyleBackColor = true;
            this.rbCodigo.CheckedChanged += new System.EventHandler(this.RbGeral_CheckedChanged);
            // 
            // rbGeral
            // 
            this.rbGeral.AutoSize = true;
            this.rbGeral.Checked = true;
            this.rbGeral.Location = new System.Drawing.Point(7, 13);
            this.rbGeral.Name = "rbGeral";
            this.rbGeral.Size = new System.Drawing.Size(108, 17);
            this.rbGeral.TabIndex = 2;
            this.rbGeral.TabStop = true;
            this.rbGeral.Text = "Todas as Vendas";
            this.rbGeral.UseVisualStyleBackColor = true;
            this.rbGeral.CheckedChanged += new System.EventHandler(this.RbGeral_CheckedChanged);
            // 
            // rbData
            // 
            this.rbData.AutoSize = true;
            this.rbData.Location = new System.Drawing.Point(7, 83);
            this.rbData.Name = "rbData";
            this.rbData.Size = new System.Drawing.Size(97, 17);
            this.rbData.TabIndex = 1;
            this.rbData.Text = "Data da Venda";
            this.rbData.UseVisualStyleBackColor = true;
            this.rbData.CheckedChanged += new System.EventHandler(this.RbGeral_CheckedChanged);
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Location = new System.Drawing.Point(7, 60);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(57, 17);
            this.rbCliente.TabIndex = 0;
            this.rbCliente.Text = "Cliente";
            this.rbCliente.UseVisualStyleBackColor = true;
            this.rbCliente.CheckedChanged += new System.EventHandler(this.RbGeral_CheckedChanged);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(479, 292);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(32, 20);
            this.txtId.TabIndex = 56;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(470, 131);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 55;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(470, 90);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 54;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // dgvVenda
            // 
            this.dgvVenda.AllowUserToAddRows = false;
            this.dgvVenda.AllowUserToDeleteRows = false;
            this.dgvVenda.AllowUserToOrderColumns = true;
            this.dgvVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenda.Location = new System.Drawing.Point(9, 118);
            this.dgvVenda.MultiSelect = false;
            this.dgvVenda.Name = "dgvVenda";
            this.dgvVenda.ReadOnly = true;
            this.dgvVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVenda.Size = new System.Drawing.Size(450, 263);
            this.dgvVenda.TabIndex = 53;
            this.dgvVenda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVenda_CellClick);
            // 
            // btnPesquisarGeral
            // 
            this.btnPesquisarGeral.Location = new System.Drawing.Point(470, 52);
            this.btnPesquisarGeral.Name = "btnPesquisarGeral";
            this.btnPesquisarGeral.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarGeral.TabIndex = 52;
            this.btnPesquisarGeral.Text = "Pesquisar";
            this.btnPesquisarGeral.UseVisualStyleBackColor = true;
            this.btnPesquisarGeral.Click += new System.EventHandler(this.BtnPesquisarGeral_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(470, 14);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 51;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // frm_Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 394);
            this.Controls.Add(this.gbCodigo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.dgvVenda);
            this.Controls.Add(this.btnPesquisarGeral);
            this.Controls.Add(this.btnNovo);
            this.Name = "frm_Venda";
            this.Text = "frm_Venda";
            this.Load += new System.EventHandler(this.Frm_Venda_Load);
            this.gbCodigo.ResumeLayout(false);
            this.gbCodigo.PerformLayout();
            this.gbData.ResumeLayout(false);
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.GroupBox gbCodigo;
        internal System.Windows.Forms.TextBox txtIdVenda;
        private System.Windows.Forms.Button btnPesquisarCod;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.Button btnPesquisaData;
        private System.Windows.Forms.DateTimePicker dtFinal;
        private System.Windows.Forms.DateTimePicker dtInicial;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Button btnPesquisaCliente;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.RadioButton rbGeral;
        private System.Windows.Forms.RadioButton rbData;
        private System.Windows.Forms.RadioButton rbCliente;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        internal System.Windows.Forms.DataGridView dgvVenda;
        private System.Windows.Forms.Button btnPesquisarGeral;
        private System.Windows.Forms.Button btnNovo;
    }
}