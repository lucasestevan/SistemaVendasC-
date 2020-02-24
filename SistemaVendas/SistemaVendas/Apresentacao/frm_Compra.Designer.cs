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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Compra));
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
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImprimirGrid = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblQtdTotal = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbFornecedor.SuspendLayout();
            this.gbData.SuspendLayout();
            this.gbCodigo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(8, 22);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(487, 21);
            this.txtNome.TabIndex = 42;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(734, 422);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(37, 21);
            this.txtId.TabIndex = 40;
            this.txtId.Visible = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(713, 171);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(87, 28);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Location = new System.Drawing.Point(711, 128);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(87, 28);
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
            this.dgvCompra.Location = new System.Drawing.Point(6, 153);
            this.dgvCompra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCompra.MultiSelect = false;
            this.dgvCompra.Name = "dgvCompra";
            this.dgvCompra.ReadOnly = true;
            this.dgvCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompra.Size = new System.Drawing.Size(684, 308);
            this.dgvCompra.TabIndex = 37;
            this.dgvCompra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCompra_CellClick);
            // 
            // btnPesquisarGeral
            // 
            this.btnPesquisarGeral.Location = new System.Drawing.Point(711, 85);
            this.btnPesquisarGeral.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPesquisarGeral.Name = "btnPesquisarGeral";
            this.btnPesquisarGeral.Size = new System.Drawing.Size(87, 28);
            this.btnPesquisarGeral.TabIndex = 4;
            this.btnPesquisarGeral.Text = "Pesquisar";
            this.btnPesquisarGeral.UseVisualStyleBackColor = true;
            this.btnPesquisarGeral.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(714, 42);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(87, 28);
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
            this.groupBox1.Location = new System.Drawing.Point(6, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(155, 128);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Location = new System.Drawing.Point(8, 44);
            this.rbCodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(101, 20);
            this.rbCodigo.TabIndex = 3;
            this.rbCodigo.Text = "Cód. Compra";
            this.rbCodigo.UseVisualStyleBackColor = true;
            this.rbCodigo.CheckedChanged += new System.EventHandler(this.RbGeral_CheckedChanged);
            // 
            // rbGeral
            // 
            this.rbGeral.AutoSize = true;
            this.rbGeral.Checked = true;
            this.rbGeral.Location = new System.Drawing.Point(8, 16);
            this.rbGeral.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbGeral.Name = "rbGeral";
            this.rbGeral.Size = new System.Drawing.Size(125, 20);
            this.rbGeral.TabIndex = 2;
            this.rbGeral.TabStop = true;
            this.rbGeral.Text = "Todas as Compras";
            this.rbGeral.UseVisualStyleBackColor = true;
            this.rbGeral.CheckedChanged += new System.EventHandler(this.RbGeral_CheckedChanged);
            // 
            // rbData
            // 
            this.rbData.AutoSize = true;
            this.rbData.Location = new System.Drawing.Point(8, 102);
            this.rbData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbData.Name = "rbData";
            this.rbData.Size = new System.Drawing.Size(121, 20);
            this.rbData.TabIndex = 1;
            this.rbData.Text = "Data da Compra";
            this.rbData.UseVisualStyleBackColor = true;
            this.rbData.CheckedChanged += new System.EventHandler(this.RbGeral_CheckedChanged);
            // 
            // RbFornecedor
            // 
            this.RbFornecedor.AutoSize = true;
            this.RbFornecedor.Location = new System.Drawing.Point(8, 74);
            this.RbFornecedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RbFornecedor.Name = "RbFornecedor";
            this.RbFornecedor.Size = new System.Drawing.Size(87, 20);
            this.RbFornecedor.TabIndex = 0;
            this.RbFornecedor.Text = "Fornecedor";
            this.RbFornecedor.UseVisualStyleBackColor = true;
            this.RbFornecedor.CheckedChanged += new System.EventHandler(this.RbGeral_CheckedChanged);
            // 
            // gbFornecedor
            // 
            this.gbFornecedor.Controls.Add(this.btnPesquisarFornecedor);
            this.gbFornecedor.Controls.Add(this.txtNome);
            this.gbFornecedor.Location = new System.Drawing.Point(178, 16);
            this.gbFornecedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbFornecedor.Name = "gbFornecedor";
            this.gbFornecedor.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbFornecedor.Size = new System.Drawing.Size(512, 128);
            this.gbFornecedor.TabIndex = 44;
            this.gbFornecedor.TabStop = false;
            this.gbFornecedor.Text = "Fornecedor";
            // 
            // btnPesquisarFornecedor
            // 
            this.btnPesquisarFornecedor.Location = new System.Drawing.Point(408, 62);
            this.btnPesquisarFornecedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPesquisarFornecedor.Name = "btnPesquisarFornecedor";
            this.btnPesquisarFornecedor.Size = new System.Drawing.Size(87, 28);
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
            this.gbData.Location = new System.Drawing.Point(178, 16);
            this.gbData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbData.Name = "gbData";
            this.gbData.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbData.Size = new System.Drawing.Size(512, 124);
            this.gbData.TabIndex = 45;
            this.gbData.TabStop = false;
            this.gbData.Text = "Data";
            // 
            // btnPesquisaData
            // 
            this.btnPesquisaData.Location = new System.Drawing.Point(244, 62);
            this.btnPesquisaData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPesquisaData.Name = "btnPesquisaData";
            this.btnPesquisaData.Size = new System.Drawing.Size(87, 28);
            this.btnPesquisaData.TabIndex = 47;
            this.btnPesquisaData.Text = "Pesquisar";
            this.btnPesquisaData.UseVisualStyleBackColor = true;
            this.btnPesquisaData.Click += new System.EventHandler(this.BtnPesquisaData_Click);
            // 
            // dtFinal
            // 
            this.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinal.Location = new System.Drawing.Point(163, 23);
            this.dtFinal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(122, 21);
            this.dtFinal.TabIndex = 1;
            // 
            // dtInicial
            // 
            this.dtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicial.Location = new System.Drawing.Point(8, 23);
            this.dtInicial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtInicial.Name = "dtInicial";
            this.dtInicial.Size = new System.Drawing.Size(115, 21);
            this.dtInicial.TabIndex = 0;
            this.dtInicial.Value = new System.DateTime(2019, 10, 3, 0, 0, 0, 0);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Enabled = false;
            this.btnVisualizar.Location = new System.Drawing.Point(713, 214);
            this.btnVisualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(87, 28);
            this.btnVisualizar.TabIndex = 7;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.BtnVisualizar_Click);
            // 
            // gbCodigo
            // 
            this.gbCodigo.Controls.Add(this.txtIdCompraPes);
            this.gbCodigo.Controls.Add(this.btnPesquisarCod);
            this.gbCodigo.Location = new System.Drawing.Point(178, 16);
            this.gbCodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbCodigo.Name = "gbCodigo";
            this.gbCodigo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbCodigo.Size = new System.Drawing.Size(512, 124);
            this.gbCodigo.TabIndex = 48;
            this.gbCodigo.TabStop = false;
            this.gbCodigo.Text = "Código";
            // 
            // txtIdCompraPes
            // 
            this.txtIdCompraPes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIdCompraPes.Location = new System.Drawing.Point(15, 22);
            this.txtIdCompraPes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIdCompraPes.Name = "txtIdCompraPes";
            this.txtIdCompraPes.Size = new System.Drawing.Size(480, 21);
            this.txtIdCompraPes.TabIndex = 1;
            // 
            // btnPesquisarCod
            // 
            this.btnPesquisarCod.Location = new System.Drawing.Point(408, 64);
            this.btnPesquisarCod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPesquisarCod.Name = "btnPesquisarCod";
            this.btnPesquisarCod.Size = new System.Drawing.Size(87, 28);
            this.btnPesquisarCod.TabIndex = 2;
            this.btnPesquisarCod.Text = "Pesquisar";
            this.btnPesquisarCod.UseVisualStyleBackColor = true;
            this.btnPesquisarCod.Click += new System.EventHandler(this.BtnPesquisarCod_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Enabled = false;
            this.btnSelecionar.Location = new System.Drawing.Point(713, 257);
            this.btnSelecionar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(87, 28);
            this.btnSelecionar.TabIndex = 8;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.BtnSelecionar_Click);
            // 
            // btnEstornar
            // 
            this.btnEstornar.Enabled = false;
            this.btnEstornar.Location = new System.Drawing.Point(711, 300);
            this.btnEstornar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEstornar.Name = "btnEstornar";
            this.btnEstornar.Size = new System.Drawing.Size(87, 28);
            this.btnEstornar.TabIndex = 9;
            this.btnEstornar.Text = "Cancelar";
            this.btnEstornar.UseVisualStyleBackColor = true;
            this.btnEstornar.Click += new System.EventHandler(this.BtnEstornar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(756, 5);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(15, 15);
            this.btnMinimizar.TabIndex = 13;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(783, 5);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(15, 15);
            this.btnClose.TabIndex = 12;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnMinimizar);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(809, 26);
            this.panel2.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 50;
            this.label8.Text = "Compra";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dgvCompra);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.panel8);
            this.groupBox2.Controls.Add(this.panel6);
            this.groupBox2.Controls.Add(this.panel7);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.gbCodigo);
            this.groupBox2.Controls.Add(this.gbData);
            this.groupBox2.Controls.Add(this.gbFornecedor);
            this.groupBox2.Location = new System.Drawing.Point(10, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(696, 466);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chave de pesquisa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(179, 488);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 68;
            this.label9.Text = "Aberto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(179, 488);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 68;
            this.label6.Text = "Aberto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(100, 488);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 66;
            this.label7.Text = "Pago";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(100, 488);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 66;
            this.label5.Text = "Pago";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.LightSalmon;
            this.panel8.Location = new System.Drawing.Point(163, 488);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(16, 16);
            this.panel8.TabIndex = 67;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightSalmon;
            this.panel6.Location = new System.Drawing.Point(163, 488);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(16, 16);
            this.panel6.TabIndex = 67;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Green;
            this.panel7.Location = new System.Drawing.Point(85, 488);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(16, 16);
            this.panel7.TabIndex = 65;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Green;
            this.panel5.Location = new System.Drawing.Point(85, 488);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(16, 16);
            this.panel5.TabIndex = 65;
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(257, 463);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(242, 48);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Legenda";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(257, 463);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(242, 48);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Legenda";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnImprimirGrid);
            this.panel1.Controls.Add(this.btnEstornar);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.btnSelecionar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnVisualizar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.lblValorTotal);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.lblQtdTotal);
            this.panel1.Controls.Add(this.btnPesquisarGeral);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 566);
            this.panel1.TabIndex = 60;
            // 
            // btnImprimirGrid
            // 
            this.btnImprimirGrid.Enabled = false;
            this.btnImprimirGrid.Location = new System.Drawing.Point(713, 343);
            this.btnImprimirGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnImprimirGrid.Name = "btnImprimirGrid";
            this.btnImprimirGrid.Size = new System.Drawing.Size(87, 28);
            this.btnImprimirGrid.TabIndex = 69;
            this.btnImprimirGrid.Text = "Imprimir Grid";
            this.btnImprimirGrid.UseVisualStyleBackColor = true;
            this.btnImprimirGrid.Click += new System.EventHandler(this.btnImprimirGrid_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(607, 501);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 61;
            this.label1.Text = "Valor total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 500);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 63;
            this.label2.Text = "Quantidade:";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(684, 501);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(15, 17);
            this.lblValorTotal.TabIndex = 62;
            this.lblValorTotal.Text = "0";
            // 
            // lblQtdTotal
            // 
            this.lblQtdTotal.AutoSize = true;
            this.lblQtdTotal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdTotal.Location = new System.Drawing.Point(93, 501);
            this.lblQtdTotal.Name = "lblQtdTotal";
            this.lblQtdTotal.Size = new System.Drawing.Size(15, 17);
            this.lblQtdTotal.TabIndex = 64;
            this.lblQtdTotal.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Controls.Add(this.panel9);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.panel4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(9, 521);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(259, 40);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Legenda";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(181, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 16);
            this.label10.TabIndex = 76;
            this.label10.Text = "Cancelado";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Green;
            this.panel3.Location = new System.Drawing.Point(8, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(16, 16);
            this.panel3.TabIndex = 65;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Red;
            this.panel9.Location = new System.Drawing.Point(166, 20);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(16, 16);
            this.panel9.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 68;
            this.label4.Text = "Aberto";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSalmon;
            this.panel4.Location = new System.Drawing.Point(86, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(16, 16);
            this.panel4.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 66;
            this.label3.Text = "Pago";
            // 
            // frm_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 566);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frm_Compra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.Frm_MovimentacaoCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbFornecedor.ResumeLayout(false);
            this.gbFornecedor.PerformLayout();
            this.gbData.ResumeLayout(false);
            this.gbCodigo.ResumeLayout(false);
            this.gbCodigo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

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
        internal System.Windows.Forms.DataGridView dgvCompra;
        private System.Windows.Forms.Button btnEstornar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblQtdTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnImprimirGrid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel9;
    }
}