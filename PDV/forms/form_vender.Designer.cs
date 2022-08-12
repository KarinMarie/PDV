namespace PDV.forms
{
    partial class form_vender
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_vender));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnImprimir = new MetroFramework.Controls.MetroButton();
            this.txtNota = new MetroFramework.Controls.MetroTextBox();
            this.txtAdmin = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.numTotal = new System.Windows.Forms.NumericUpDown();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnConcluir = new MetroFramework.Controls.MetroButton();
            this.view_produtos = new System.Windows.Forms.ListView();
            this.codigo_produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nome_produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.preco_produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.estoque_produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categoria_produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnVoltar = new MetroFramework.Controls.MetroButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numCodigoProduto = new System.Windows.Forms.NumericUpDown();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.btnAdicionarProdutos = new MetroFramework.Controls.MetroButton();
            this.numQuantidadeProduto = new System.Windows.Forms.NumericUpDown();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.numPrecoProduto = new System.Windows.Forms.NumericUpDown();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtNomeProduto = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.txtHora = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTotal)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCodigoProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidadeProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnImprimir);
            this.groupBox1.Controls.Add(this.txtNota);
            this.groupBox1.Controls.Add(this.txtAdmin);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.numTotal);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(542, 407);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 358);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DETALHES";
            // 
            // btnImprimir
            // 
            this.btnImprimir.AccessibleDescription = "Clique aqui para imprimir a nota após a conclusão da venda.";
            this.btnImprimir.AccessibleName = "Botão de imprimir nota.";
            this.btnImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
            this.btnImprimir.Enabled = false;
            this.btnImprimir.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnImprimir.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnImprimir.Location = new System.Drawing.Point(10, 310);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(421, 39);
            this.btnImprimir.Style = MetroFramework.MetroColorStyle.Pink;
            this.btnImprimir.TabIndex = 9;
            this.btnImprimir.Text = "IMPRIMIR NOTA";
            this.btnImprimir.UseSelectable = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // txtNota
            // 
            this.txtNota.AccessibleDescription = "Aqui está a nota a ser gerada pela venda em curso.";
            this.txtNota.AccessibleName = "Nota da compra.";
            this.txtNota.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            // 
            // 
            // 
            this.txtNota.CustomButton.Image = null;
            this.txtNota.CustomButton.Location = new System.Drawing.Point(255, 1);
            this.txtNota.CustomButton.Name = "";
            this.txtNota.CustomButton.Size = new System.Drawing.Size(165, 165);
            this.txtNota.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNota.CustomButton.TabIndex = 1;
            this.txtNota.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNota.CustomButton.UseSelectable = true;
            this.txtNota.CustomButton.Visible = false;
            this.txtNota.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtNota.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtNota.Lines = new string[0];
            this.txtNota.Location = new System.Drawing.Point(10, 137);
            this.txtNota.MaxLength = 32767;
            this.txtNota.Multiline = true;
            this.txtNota.Name = "txtNota";
            this.txtNota.PasswordChar = '\0';
            this.txtNota.ReadOnly = true;
            this.txtNota.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNota.SelectedText = "";
            this.txtNota.SelectionLength = 0;
            this.txtNota.SelectionStart = 0;
            this.txtNota.ShortcutsEnabled = true;
            this.txtNota.Size = new System.Drawing.Size(421, 167);
            this.txtNota.Style = MetroFramework.MetroColorStyle.Pink;
            this.txtNota.TabIndex = 4;
            this.txtNota.UseSelectable = true;
            this.txtNota.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNota.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAdmin
            // 
            this.txtAdmin.AccessibleDescription = "Aqui está o funcionário que efetua a venda.";
            this.txtAdmin.AccessibleName = "Funcionário.";
            this.txtAdmin.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            // 
            // 
            // 
            this.txtAdmin.CustomButton.Image = null;
            this.txtAdmin.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtAdmin.CustomButton.Name = "";
            this.txtAdmin.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtAdmin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAdmin.CustomButton.TabIndex = 1;
            this.txtAdmin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdmin.CustomButton.UseSelectable = true;
            this.txtAdmin.CustomButton.Visible = false;
            this.txtAdmin.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtAdmin.Lines = new string[0];
            this.txtAdmin.Location = new System.Drawing.Point(133, 88);
            this.txtAdmin.MaxLength = 32767;
            this.txtAdmin.Multiline = true;
            this.txtAdmin.Name = "txtAdmin";
            this.txtAdmin.PasswordChar = '\0';
            this.txtAdmin.ReadOnly = true;
            this.txtAdmin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdmin.SelectedText = "";
            this.txtAdmin.SelectionLength = 0;
            this.txtAdmin.SelectionStart = 0;
            this.txtAdmin.ShortcutsEnabled = true;
            this.txtAdmin.Size = new System.Drawing.Size(208, 31);
            this.txtAdmin.Style = MetroFramework.MetroColorStyle.Pink;
            this.txtAdmin.TabIndex = 3;
            this.txtAdmin.UseSelectable = true;
            this.txtAdmin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAdmin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(10, 88);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(117, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Funcionário:";
            // 
            // numTotal
            // 
            this.numTotal.AccessibleDescription = "Aqui está o preço total da venda em curso.";
            this.numTotal.AccessibleName = "Preço Total em reais.";
            this.numTotal.DecimalPlaces = 2;
            this.numTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTotal.Location = new System.Drawing.Point(169, 34);
            this.numTotal.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numTotal.Name = "numTotal";
            this.numTotal.ReadOnly = true;
            this.numTotal.Size = new System.Drawing.Size(172, 31);
            this.numTotal.TabIndex = 1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(10, 34);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(153, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Preço Total (R$):";
            // 
            // btnConcluir
            // 
            this.btnConcluir.AccessibleDescription = "Clique aqui para concluir a venda e emitir a nota da compra.";
            this.btnConcluir.AccessibleName = "Botão de Concluir Venda.";
            this.btnConcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConcluir.Enabled = false;
            this.btnConcluir.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnConcluir.Location = new System.Drawing.Point(542, 791);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(441, 55);
            this.btnConcluir.TabIndex = 2;
            this.btnConcluir.Text = "CONCLUIR VENDA";
            this.btnConcluir.UseSelectable = true;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // view_produtos
            // 
            this.view_produtos.AccessibleDescription = "Aqui estão todos os produtos disponíveis para venda, juntamente com seus códigos," +
    " preços, estoques e categorias.";
            this.view_produtos.AccessibleName = "Tabela de produtos disponíveis.";
            this.view_produtos.AccessibleRole = System.Windows.Forms.AccessibleRole.Table;
            this.view_produtos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.view_produtos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codigo_produto,
            this.nome_produto,
            this.preco_produto,
            this.estoque_produto,
            this.categoria_produto});
            this.view_produtos.FullRowSelect = true;
            this.view_produtos.HideSelection = false;
            this.view_produtos.Location = new System.Drawing.Point(23, 78);
            this.view_produtos.Name = "view_produtos";
            this.view_produtos.Size = new System.Drawing.Size(498, 682);
            this.view_produtos.TabIndex = 3;
            this.view_produtos.UseCompatibleStateImageBehavior = false;
            this.view_produtos.View = System.Windows.Forms.View.Details;
            this.view_produtos.SelectedIndexChanged += new System.EventHandler(this.view_produtos_SelectedIndexChanged);
            // 
            // codigo_produto
            // 
            this.codigo_produto.Text = "CÓDIGO";
            // 
            // nome_produto
            // 
            this.nome_produto.Text = "NOME";
            this.nome_produto.Width = 202;
            // 
            // preco_produto
            // 
            this.preco_produto.Text = "PREÇO";
            this.preco_produto.Width = 72;
            // 
            // estoque_produto
            // 
            this.estoque_produto.Text = "ESTOQUE";
            this.estoque_produto.Width = 70;
            // 
            // categoria_produto
            // 
            this.categoria_produto.Text = "CATEGORIA";
            this.categoria_produto.Width = 90;
            // 
            // btnVoltar
            // 
            this.btnVoltar.AccessibleDescription = "Clique aqui para voltar ao menu anterior.";
            this.btnVoltar.AccessibleName = "Botão de Voltar.";
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVoltar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnVoltar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnVoltar.Location = new System.Drawing.Point(21, 807);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(101, 39);
            this.btnVoltar.Style = MetroFramework.MetroColorStyle.Pink;
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseSelectable = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.numCodigoProduto);
            this.groupBox2.Controls.Add(this.metroLabel6);
            this.groupBox2.Controls.Add(this.btnAdicionarProdutos);
            this.groupBox2.Controls.Add(this.numQuantidadeProduto);
            this.groupBox2.Controls.Add(this.metroLabel5);
            this.groupBox2.Controls.Add(this.numPrecoProduto);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.txtNomeProduto);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(542, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 312);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PRODUTO";
            // 
            // numCodigoProduto
            // 
            this.numCodigoProduto.AccessibleName = "Código do produto a ser vendido.";
            this.numCodigoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCodigoProduto.Location = new System.Drawing.Point(193, 35);
            this.numCodigoProduto.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numCodigoProduto.Name = "numCodigoProduto";
            this.numCodigoProduto.ReadOnly = true;
            this.numCodigoProduto.Size = new System.Drawing.Size(176, 31);
            this.numCodigoProduto.TabIndex = 11;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(6, 35);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(178, 25);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "Código do produto:";
            // 
            // btnAdicionarProdutos
            // 
            this.btnAdicionarProdutos.AccessibleDescription = "Clique aqui para adicionar um produto à venda em curso.";
            this.btnAdicionarProdutos.AccessibleName = "Botão de adicionar ao carrinho.";
            this.btnAdicionarProdutos.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnAdicionarProdutos.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnAdicionarProdutos.Location = new System.Drawing.Point(10, 260);
            this.btnAdicionarProdutos.Name = "btnAdicionarProdutos";
            this.btnAdicionarProdutos.Size = new System.Drawing.Size(421, 42);
            this.btnAdicionarProdutos.Style = MetroFramework.MetroColorStyle.Pink;
            this.btnAdicionarProdutos.TabIndex = 9;
            this.btnAdicionarProdutos.Text = "ADICIONAR AO CARRINHO";
            this.btnAdicionarProdutos.UseSelectable = true;
            this.btnAdicionarProdutos.Click += new System.EventHandler(this.btnAdicionarProdutos_Click);
            // 
            // numQuantidadeProduto
            // 
            this.numQuantidadeProduto.AccessibleName = "Quantidade de unidades do produto a ser vendido.";
            this.numQuantidadeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQuantidadeProduto.Location = new System.Drawing.Point(193, 174);
            this.numQuantidadeProduto.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numQuantidadeProduto.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantidadeProduto.Name = "numQuantidadeProduto";
            this.numQuantidadeProduto.Size = new System.Drawing.Size(176, 31);
            this.numQuantidadeProduto.TabIndex = 8;
            this.numQuantidadeProduto.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(70, 174);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(117, 25);
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "Quantidade:";
            // 
            // numPrecoProduto
            // 
            this.numPrecoProduto.AccessibleName = "Preço do produto a ser vendido.";
            this.numPrecoProduto.DecimalPlaces = 2;
            this.numPrecoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPrecoProduto.Location = new System.Drawing.Point(193, 130);
            this.numPrecoProduto.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numPrecoProduto.Name = "numPrecoProduto";
            this.numPrecoProduto.ReadOnly = true;
            this.numPrecoProduto.Size = new System.Drawing.Size(176, 31);
            this.numPrecoProduto.TabIndex = 6;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(81, 130);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(106, 25);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Preço (R$):";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.AccessibleName = "Nome do produto a ser vendido.";
            this.txtNomeProduto.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            // 
            // 
            // 
            this.txtNomeProduto.CustomButton.Image = null;
            this.txtNomeProduto.CustomButton.Location = new System.Drawing.Point(208, 1);
            this.txtNomeProduto.CustomButton.Name = "";
            this.txtNomeProduto.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtNomeProduto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomeProduto.CustomButton.TabIndex = 1;
            this.txtNomeProduto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomeProduto.CustomButton.UseSelectable = true;
            this.txtNomeProduto.CustomButton.Visible = false;
            this.txtNomeProduto.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtNomeProduto.Lines = new string[0];
            this.txtNomeProduto.Location = new System.Drawing.Point(193, 82);
            this.txtNomeProduto.MaxLength = 32767;
            this.txtNomeProduto.Multiline = true;
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.PasswordChar = '\0';
            this.txtNomeProduto.ReadOnly = true;
            this.txtNomeProduto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomeProduto.SelectedText = "";
            this.txtNomeProduto.SelectionLength = 0;
            this.txtNomeProduto.SelectionStart = 0;
            this.txtNomeProduto.ShortcutsEnabled = true;
            this.txtNomeProduto.Size = new System.Drawing.Size(238, 31);
            this.txtNomeProduto.Style = MetroFramework.MetroColorStyle.Pink;
            this.txtNomeProduto.TabIndex = 4;
            this.txtNomeProduto.UseSelectable = true;
            this.txtNomeProduto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomeProduto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(18, 82);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(169, 25);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Nome do produto:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.AccessibleDescription = "Clique aqui para cancelar a venda em curso.";
            this.btnCancelar.AccessibleName = "Botão de Cancelar Venda.";
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCancelar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnCancelar.Location = new System.Drawing.Point(315, 791);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(206, 55);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "CANCELAR VENDA";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // txtHora
            // 
            this.txtHora.AccessibleName = "Horário atual.";
            this.txtHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHora.AutoSize = true;
            this.txtHora.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.txtHora.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.txtHora.Location = new System.Drawing.Point(439, 31);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(82, 25);
            this.txtHora.Style = MetroFramework.MetroColorStyle.Pink;
            this.txtHora.TabIndex = 11;
            this.txtHora.Text = "00:00:00";
            this.txtHora.UseStyleColors = true;
            // 
            // form_vender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 869);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.view_produtos);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_vender";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Text = "Efetuar vendas";
            this.Load += new System.EventHandler(this.form_vender_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTotal)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCodigoProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidadeProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnConcluir;
        private MetroFramework.Controls.MetroTextBox txtNota;
        private MetroFramework.Controls.MetroTextBox txtAdmin;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.NumericUpDown numTotal;
        private System.Windows.Forms.ListView view_produtos;
        private MetroFramework.Controls.MetroButton btnVoltar;
        private System.Windows.Forms.ColumnHeader codigo_produto;
        private System.Windows.Forms.ColumnHeader nome_produto;
        private System.Windows.Forms.ColumnHeader preco_produto;
        private System.Windows.Forms.ColumnHeader estoque_produto;
        private System.Windows.Forms.ColumnHeader categoria_produto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numQuantidadeProduto;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.NumericUpDown numPrecoProduto;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtNomeProduto;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnAdicionarProdutos;
        private System.Windows.Forms.NumericUpDown numCodigoProduto;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnImprimir;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.Timer timer;
        private MetroFramework.Controls.MetroLabel txtHora;
    }
}