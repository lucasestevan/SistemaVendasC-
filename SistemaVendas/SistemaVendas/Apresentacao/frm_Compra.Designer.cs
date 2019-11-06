namespace SistemaVendas.Apresentacao
{
    partial class frm_Compra
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.dgvCompra = new System.Windows.Forms.DataGridView();
            this.btnPesquisarGeral = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.rbGeral = new System.Windows.Forms.RadioButton();
            this.rbData = new System.Windows.Forms.RadioButton();
            this.RbFornecedor = new System.Windows.Forms.RadioButton();
            this.gbFornecedor = new System.Windows.Forms.GroupBox();
            this.btnPesquisarFornecedor = new System.Windows.Forms.Button();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.btnPesquisaData = new System.Windows.Forms.Button();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.dtInicial = new System.Windows.Forms.DateTimePicker();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.gbCodigo = new System.Windows.Forms.GroupBox();
            this.txtIdCompraPes = new System.Windows.Forms.TextBox();
            this.btnPesquisarCod = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnEstornar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbFornecedor.SuspendLayout();
            this.gbData.SuspendLayout();
            this.gbCodigo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(7, 18);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(287, 20);
            this.txtNome.TabIndex = 42;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(482, 293);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(32, 20);
            this.txtId.TabIndex = 40;
            this.txtId.Visible = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(473, 132);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(473, 91);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // dgvCompra
            // 
            this.dgvCompra.AllowUserToAddRows = false;
            this.dgvCompra.AllowUserToDeleteRows = false;
            this.dgvCompra.AllowUserToOrderColumns = true;
            this.dgvCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompra.Location = new System.Drawing.Point(12, 119);
            this.dgvCompra.MultiSelect = false;
            this.dgvCompra.Name = "dgvCompra";
            this.dgvCompra.ReadOnly = true;
            this.dgvCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompra.Size = new System.Drawing.Size(450, 263);
            this.dgvCompra.TabIndex = 37;
            this.dgvCompra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCompra_CellClick);
            // 
            // btnPesquisarGeral
            // 
            this.btnPesquisarGeral.Location = new System.Drawing.Point(473, 53);
            this.btnPesquisarGeral.Name = "btnPesquisarGeral";
            this.btnPesquisarGeral.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarGeral.TabIndex = 4;
            this.btnPesquisarGeral.Text = "Pesquisar";
            this.btnPesquisarGeral.UseVisualStyleBackColor = true;
            this.btnPesquisarGeral.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(473, 15);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 3;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCodigo);
            this.groupBox1.Controls.Add(this.rbGeral);
            this.groupBox1.Controls.Add(this.rbData);
            this.groupBox1.Controls.Add(this.RbFornecedor);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 111);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Location = new System.Drawing.Point(7, 36);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(86, 17);
            this.rbCodigo.TabIndex = 3;
            this.rbCodigo.Text = "Cód. Compra";
            this.rbCodigo.UseVisualStyleBackColor = true;
            this.rbCodigo.CheckedChanged += new System.EventHandler(this.RbGeral_CheckedChanged);
            // 
            // rbGeral
            // 
            this.rbGeral.AutoSize = true;
            this.rbGeral.Checked = true;
            this.rbGeral.Location = new System.Drawing.Point(7, 13);
            this.rbGeral.Name = "rbGeral";
            this.rbGeral.Size = new System.Drawing.Size(113, 17);
            this.rbGeral.TabIndex = 2;
            this.rbGeral.TabStop = true;
            this.rbGeral.Text = "Todas as Compras";
            this.rbGeral.UseVisualStyleBackColor = true;
            this.rbGeral.CheckedChanged += new System.EventHandler(this.RbGeral_CheckedChanged);
            // 
            // rbData
            // 
            this.rbData.AutoSize = true;
            this.rbData.Location = new System.Drawing.Point(7, 83);
            this.rbData.Name = "rbData";
            this.rbData.Size = new System.Drawing.Size(102, 17);
            this.rbData.TabIndex = 1;
            this.rbData.Text = "Data da Compra";
            this.rbData.UseVisualStyleBackColor = true;
            this.rbData.CheckedChanged += new System.EventHandler(this.RbGeral_CheckedChanged);
            // 
            // RbFornecedor
            // 
            this.RbFornecedor.AutoSize = true;
            this.RbFornecedor.Location = new System.Drawing.Point(7, 60);
            this.RbFornecedor.Name = "RbFornecedor";
            this.RbFornecedor.Size = new System.Drawing.Size(79, 17);
            this.RbFornecedor.TabIndex = 0;
            this.RbFornecedor.Text = "Fornecedor";
            this.RbFornecedor.UseVisualStyleBackColor = true;
            this.RbFornecedor.CheckedChanged += new System.EventHandler(this.RbGeral_CheckedChanged);
            // 
            // gbFornecedor
            // 
            this.gbFornecedor.Controls.Add(this.btnPesquisarFornecedor);
            this.gbFornecedor.Controls.Add(this.txtNome);
            this.gbFornecedor.Location = new System.Drawing.Point(162, 15);
            this.gbFornecedor.Name = "gbFornecedor";
            this.gbFornecedor.Size = new System.Drawing.Size(300, 98);
            this.gbFornecedor.TabIndex = 44;
            this.gbFornecedor.TabStop = false;
            this.gbFornecedor.Text = "Fornecedor";
            // 
            // btnPesquisarFornecedor
            // 
            this.btnPesquisarFornecedor.Location = new System.Drawing.Point(219, 49);
            this.btnPesquisarFornecedor.Name = "btnPesquisarFornecedor";
            this.btnPesquisarFornecedor.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarFornecedor.TabIndex = 46;
            this.btnPesquisarFornecedor.Text = "Pesquisar";
            this.btnPesquisarFornecedor.UseVisualStyleBackColor = true;
            this.btnPesquisarFornecedor.Click += new System.EventHandler(this.BtnPesquisarFornecedor_Click);
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.btnPesquisaData);
            this.gbData.Controls.Add(this.dtFinal);
            this.gbData.Controls.Add(this.dtInicial);
            this.gbData.Location = new System.Drawing.Point(162, 12);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(300, 101);
            this.gbData.TabIndex = 45;
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
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(473, 172);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizar.TabIndex = 7;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.BtnVisualizar_Click);
            // 
            // gbCodigo
            // 
            this.gbCodigo.Controls.Add(this.txtIdCompraPes);
            this.gbCodigo.Controls.Add(this.btnPesquisarCod);
            this.gbCodigo.Location = new System.Drawing.Point(162, 12);
            this.gbCodigo.Name = "gbCodigo";
            this.gbCodigo.Size = new System.Drawing.Size(300, 101);
            this.gbCodigo.TabIndex = 48;
            this.gbCodigo.TabStop = false;
            this.gbCodigo.Text = "Código";
            // 
            // txtIdCompraPes
            // 
            this.txtIdCompraPes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIdCompraPes.Location = new System.Drawing.Point(13, 18);
            this.txtIdCompraPes.Name = "txtIdCompraPes";
            this.txtIdCompraPes.Size = new System.Drawing.Size(281, 20);
            this.txtIdCompraPes.TabIndex = 1;
            // 
            // btnPesquisarCod
            // 
            this.btnPesquisarCod.Location = new System.Drawing.Point(219, 50);
            this.btnPesquisarCod.Name = "btnPesquisarCod";
            this.btnPesquisarCod.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarCod.TabIndex = 2;
            this.btnPesquisarCod.Text = "Pesquisar";
            this.btnPesquisarCod.UseVisualStyleBackColor = true;
            this.btnPesquisarCod.Click += new System.EventHandler(this.BtnPesquisarCod_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(473, 214);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionar.TabIndex = 8;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.BtnSelecionar_Click);
            // 
            // btnEstornar
            // 
            this.btnEstornar.Location = new System.Drawing.Point(473, 253);
            this.btnEstornar.Name = "btnEstornar";
            this.btnEstornar.Size = new System.Drawing.Size(75, 23);
            this.btnEstornar.TabIndex = 9;
            this.btnEstornar.Text = "Estornar";
            this.btnEstornar.UseVisualStyleBackColor = true;
            this.btnEstornar.Click += new System.EventHandler(this.BtnEstornar_Click);
            // 
            // frm_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 394);
            this.Controls.Add(this.btnEstornar);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.gbFornecedor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.dgvCompra);
            this.Controls.Add(this.btnPesquisarGeral);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.gbCodigo);
            this.Controls.Add(this.gbData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_Compra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_MovimentacaoCompra";
            this.Load += new System.EventHandler(this.Frm_MovimentacaoCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbFornecedor.ResumeLayout(false);
            this.gbFornecedor.PerformLayout();
            this.gbData.ResumeLayout(false);
            this.gbCodigo.ResumeLayout(false);
            this.gbCodigo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnPesquisarGeral;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbGeral;
        private System.Windows.Forms.RadioButton rbData;
        private System.Windows.Forms.RadioButton RbFornecedor;
        private System.Windows.Forms.GroupBox gbFornecedor;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.DateTimePicker dtFinal;
        private System.Windows.Forms.DateTimePicker dtInicial;
        private System.Windows.Forms.Button btnPesquisarFornecedor;
        private System.Windows.Forms.Button btnPesquisaData;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.GroupBox gbCodigo;
        private System.Windows.Forms.Button btnPesquisarCod;
        internal System.Windows.Forms.TextBox txtIdCompraPes;
        private System.Windows.Forms.Button btnSelecionar;
        internal System.Windows.Forms.DataGridView dgvCompra;
        private System.Windows.Forms.Button btnEstornar;
    }
}