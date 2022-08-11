namespace PDV.forms
{
    partial class form_gerenciar_produtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_gerenciar_produtos));
            this.btnVoltar = new MetroFramework.Controls.MetroButton();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.codigo_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoque_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numEstoque = new System.Windows.Forms.NumericUpDown();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnAdicionar = new MetroFramework.Controls.MetroButton();
            this.cbCategoria = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.numPreco = new System.Windows.Forms.NumericUpDown();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numCod = new System.Windows.Forms.NumericUpDown();
            this.btnExcluir = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.btnAtualizar = new MetroFramework.Controls.MetroButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numNovoEstoque = new System.Windows.Forms.NumericUpDown();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.numCodigoEstoque = new System.Windows.Forms.NumericUpDown();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRemoverFiltros = new MetroFramework.Controls.MetroButton();
            this.cbFiltrarCategoria = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.btnFiltrar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPreco)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCod)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNovoEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCodigoEstoque)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnVoltar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnVoltar.Location = new System.Drawing.Point(23, 534);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(101, 39);
            this.btnVoltar.Style = MetroFramework.MetroColorStyle.Pink;
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseSelectable = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo_produto,
            this.nome_produto,
            this.preco_produto,
            this.estoque_produto,
            this.categoria_produto});
            this.dataGrid.Location = new System.Drawing.Point(23, 73);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.ShowEditingIcon = false;
            this.dataGrid.Size = new System.Drawing.Size(544, 444);
            this.dataGrid.TabIndex = 4;
            // 
            // codigo_produto
            // 
            this.codigo_produto.HeaderText = "Código";
            this.codigo_produto.Name = "codigo_produto";
            this.codigo_produto.ReadOnly = true;
            // 
            // nome_produto
            // 
            this.nome_produto.HeaderText = "Nome";
            this.nome_produto.Name = "nome_produto";
            this.nome_produto.ReadOnly = true;
            // 
            // preco_produto
            // 
            this.preco_produto.HeaderText = "Preço";
            this.preco_produto.Name = "preco_produto";
            this.preco_produto.ReadOnly = true;
            // 
            // estoque_produto
            // 
            this.estoque_produto.HeaderText = "Estoque";
            this.estoque_produto.Name = "estoque_produto";
            this.estoque_produto.ReadOnly = true;
            // 
            // categoria_produto
            // 
            this.categoria_produto.HeaderText = "Categoria";
            this.categoria_produto.Name = "categoria_produto";
            this.categoria_produto.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numEstoque);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.btnAdicionar);
            this.groupBox1.Controls.Add(this.cbCategoria);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.numPreco);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(583, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 324);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADICIONAR PRODUTO";
            // 
            // numEstoque
            // 
            this.numEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numEstoque.Location = new System.Drawing.Point(87, 159);
            this.numEstoque.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numEstoque.Name = "numEstoque";
            this.numEstoque.Size = new System.Drawing.Size(155, 26);
            this.numEstoque.TabIndex = 9;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(6, 159);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(80, 25);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Estoque:";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnAdicionar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnAdicionar.Location = new System.Drawing.Point(8, 268);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(234, 42);
            this.btnAdicionar.Style = MetroFramework.MetroColorStyle.Pink;
            this.btnAdicionar.TabIndex = 7;
            this.btnAdicionar.Text = "ADICIONAR";
            this.btnAdicionar.UseSelectable = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // cbCategoria
            // 
            this.cbCategoria.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.ItemHeight = 29;
            this.cbCategoria.Items.AddRange(new object[] {
            "SORVETE",
            "PICOLÉ",
            "BEBIDA",
            "DOCE",
            "OUTROS"});
            this.cbCategoria.Location = new System.Drawing.Point(104, 201);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(138, 35);
            this.cbCategoria.Style = MetroFramework.MetroColorStyle.Pink;
            this.cbCategoria.TabIndex = 6;
            this.cbCategoria.UseSelectable = true;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cb_categoria_SelectedIndexChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(6, 201);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(92, 25);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Categoria:";
            // 
            // numPreco
            // 
            this.numPreco.DecimalPlaces = 2;
            this.numPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPreco.Location = new System.Drawing.Point(104, 107);
            this.numPreco.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numPreco.Name = "numPreco";
            this.numPreco.Size = new System.Drawing.Size(138, 26);
            this.numPreco.TabIndex = 4;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(6, 107);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(96, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Preço (R$):";
            // 
            // txtNome
            // 
            // 
            // 
            // 
            this.txtNome.CustomButton.Image = null;
            this.txtNome.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.txtNome.CustomButton.Name = "";
            this.txtNome.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNome.CustomButton.TabIndex = 1;
            this.txtNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNome.CustomButton.UseSelectable = true;
            this.txtNome.CustomButton.Visible = false;
            this.txtNome.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtNome.Lines = new string[0];
            this.txtNome.Location = new System.Drawing.Point(15, 59);
            this.txtNome.MaxLength = 32767;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.Size = new System.Drawing.Size(227, 31);
            this.txtNome.Style = MetroFramework.MetroColorStyle.Pink;
            this.txtNome.TabIndex = 1;
            this.txtNome.UseSelectable = true;
            this.txtNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNome.Click += new System.EventHandler(this.txtNome_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(6, 31);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Nome:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numCod);
            this.groupBox2.Controls.Add(this.btnExcluir);
            this.groupBox2.Controls.Add(this.metroLabel5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(583, 417);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 156);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EXCLUIR PRODUTO";
            // 
            // numCod
            // 
            this.numCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCod.Location = new System.Drawing.Point(87, 41);
            this.numCod.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numCod.Name = "numCod";
            this.numCod.Size = new System.Drawing.Size(138, 26);
            this.numCod.TabIndex = 4;
            // 
            // btnExcluir
            // 
            this.btnExcluir.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnExcluir.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnExcluir.Location = new System.Drawing.Point(12, 97);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(230, 42);
            this.btnExcluir.Style = MetroFramework.MetroColorStyle.Pink;
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseSelectable = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(6, 41);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(75, 25);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Código:";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnAtualizar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnAtualizar.Location = new System.Drawing.Point(6, 158);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(240, 42);
            this.btnAtualizar.Style = MetroFramework.MetroColorStyle.Pink;
            this.btnAtualizar.TabIndex = 8;
            this.btnAtualizar.Text = "ATUALIZAR";
            this.btnAtualizar.UseSelectable = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAtualizar);
            this.groupBox3.Controls.Add(this.numNovoEstoque);
            this.groupBox3.Controls.Add(this.metroLabel7);
            this.groupBox3.Controls.Add(this.numCodigoEstoque);
            this.groupBox3.Controls.Add(this.metroLabel6);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(856, 73);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(252, 214);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ATUALIZAR ESTOQUE";
            // 
            // numNovoEstoque
            // 
            this.numNovoEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNovoEstoque.Location = new System.Drawing.Point(137, 79);
            this.numNovoEstoque.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numNovoEstoque.Name = "numNovoEstoque";
            this.numNovoEstoque.Size = new System.Drawing.Size(109, 26);
            this.numNovoEstoque.TabIndex = 10;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(6, 79);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(129, 25);
            this.metroLabel7.TabIndex = 9;
            this.metroLabel7.Text = "Novo estoque:";
            // 
            // numCodigoEstoque
            // 
            this.numCodigoEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCodigoEstoque.Location = new System.Drawing.Point(87, 41);
            this.numCodigoEstoque.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numCodigoEstoque.Name = "numCodigoEstoque";
            this.numCodigoEstoque.Size = new System.Drawing.Size(159, 26);
            this.numCodigoEstoque.TabIndex = 4;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(6, 41);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(75, 25);
            this.metroLabel6.TabIndex = 2;
            this.metroLabel6.Text = "Código:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnRemoverFiltros);
            this.groupBox4.Controls.Add(this.cbFiltrarCategoria);
            this.groupBox4.Controls.Add(this.metroLabel8);
            this.groupBox4.Controls.Add(this.btnFiltrar);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(856, 307);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(252, 266);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "FILTRAR POR CATEGORIA";
            // 
            // btnRemoverFiltros
            // 
            this.btnRemoverFiltros.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnRemoverFiltros.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnRemoverFiltros.Location = new System.Drawing.Point(7, 211);
            this.btnRemoverFiltros.Name = "btnRemoverFiltros";
            this.btnRemoverFiltros.Size = new System.Drawing.Size(240, 42);
            this.btnRemoverFiltros.Style = MetroFramework.MetroColorStyle.Pink;
            this.btnRemoverFiltros.TabIndex = 11;
            this.btnRemoverFiltros.Text = "REMOVER FILTROS";
            this.btnRemoverFiltros.UseSelectable = true;
            this.btnRemoverFiltros.Click += new System.EventHandler(this.btnRemoverFiltros_Click);
            // 
            // cbFiltrarCategoria
            // 
            this.cbFiltrarCategoria.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cbFiltrarCategoria.FormattingEnabled = true;
            this.cbFiltrarCategoria.ItemHeight = 29;
            this.cbFiltrarCategoria.Items.AddRange(new object[] {
            "SORVETE",
            "PICOLÉ",
            "BEBIDA",
            "DOCE",
            "OUTROS"});
            this.cbFiltrarCategoria.Location = new System.Drawing.Point(104, 62);
            this.cbFiltrarCategoria.Name = "cbFiltrarCategoria";
            this.cbFiltrarCategoria.Size = new System.Drawing.Size(138, 35);
            this.cbFiltrarCategoria.Style = MetroFramework.MetroColorStyle.Pink;
            this.cbFiltrarCategoria.TabIndex = 10;
            this.cbFiltrarCategoria.UseSelectable = true;
            this.cbFiltrarCategoria.SelectedIndexChanged += new System.EventHandler(this.cbFiltrarCategoria_SelectedIndexChanged);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(6, 62);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(92, 25);
            this.metroLabel8.TabIndex = 9;
            this.metroLabel8.Text = "Categoria:";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnFiltrar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnFiltrar.Location = new System.Drawing.Point(6, 158);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(240, 42);
            this.btnFiltrar.Style = MetroFramework.MetroColorStyle.Pink;
            this.btnFiltrar.TabIndex = 8;
            this.btnFiltrar.Text = "FILTRAR";
            this.btnFiltrar.UseSelectable = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // form_gerenciar_produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 592);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "form_gerenciar_produtos";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Text = "Gerenciar produtos";
            this.Load += new System.EventHandler(this.form_gerenciar_produtos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPreco)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCod)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNovoEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCodigoEstoque)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnVoltar;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroComboBox cbCategoria;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.NumericUpDown numPreco;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoque_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria_produto;
        private MetroFramework.Controls.MetroButton btnAdicionar;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton btnAtualizar;
        private System.Windows.Forms.NumericUpDown numCod;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.NumericUpDown numEstoque;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnExcluir;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numNovoEstoque;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.NumericUpDown numCodigoEstoque;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroButton btnFiltrar;
        private MetroFramework.Controls.MetroComboBox cbFiltrarCategoria;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton btnRemoverFiltros;
    }
}