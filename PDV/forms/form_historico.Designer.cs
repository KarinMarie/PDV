namespace PDV.forms
{
    partial class form_historico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_historico));
            this.lvVendas = new System.Windows.Forms.ListView();
            this.data_venda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.preco_total_venda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.usuario_admin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnVoltar = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFiltrar = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cbMes = new MetroFramework.Controls.MetroComboBox();
            this.numAno = new System.Windows.Forms.NumericUpDown();
            this.txtFuncionario = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.numGanhos = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnLimparFiltro = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGanhos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvVendas
            // 
            this.lvVendas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.data_venda,
            this.preco_total_venda,
            this.usuario_admin});
            this.lvVendas.HideSelection = false;
            this.lvVendas.Location = new System.Drawing.Point(23, 72);
            this.lvVendas.Name = "lvVendas";
            this.lvVendas.Size = new System.Drawing.Size(387, 501);
            this.lvVendas.TabIndex = 0;
            this.lvVendas.UseCompatibleStateImageBehavior = false;
            this.lvVendas.View = System.Windows.Forms.View.Details;
            // 
            // data_venda
            // 
            this.data_venda.Text = "DATA";
            this.data_venda.Width = 128;
            // 
            // preco_total_venda
            // 
            this.preco_total_venda.Text = "PREÇO TOTAL";
            this.preco_total_venda.Width = 128;
            // 
            // usuario_admin
            // 
            this.usuario_admin.Text = "FUNCIONÁRIO";
            this.usuario_admin.Width = 126;
            // 
            // btnVoltar
            // 
            this.btnVoltar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnVoltar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnVoltar.Location = new System.Drawing.Point(23, 592);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(101, 39);
            this.btnVoltar.Style = MetroFramework.MetroColorStyle.Pink;
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseSelectable = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimparFiltro);
            this.groupBox1.Controls.Add(this.numAno);
            this.groupBox1.Controls.Add(this.cbMes);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.btnFiltrar);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(426, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 278);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILTRAR";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnFiltrar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnFiltrar.Location = new System.Drawing.Point(14, 164);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(240, 42);
            this.btnFiltrar.Style = MetroFramework.MetroColorStyle.Pink;
            this.btnFiltrar.TabIndex = 7;
            this.btnFiltrar.Text = "FILTRAR";
            this.btnFiltrar.UseSelectable = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(6, 45);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Mês";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(8, 86);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(45, 25);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "Ano";
            // 
            // cbMes
            // 
            this.cbMes.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cbMes.FormattingEnabled = true;
            this.cbMes.ItemHeight = 29;
            this.cbMes.Items.AddRange(new object[] {
            "JANEIRO",
            "FEVEREIRO",
            "MARÇO",
            "ABRIL",
            "MAIO",
            "JUNHO",
            "JULHO",
            "AGOSTO",
            "SETEMBRO",
            "OUTUBRO",
            "NOVEMBRO",
            "DEZEMBRO"});
            this.cbMes.Location = new System.Drawing.Point(57, 39);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(199, 35);
            this.cbMes.Style = MetroFramework.MetroColorStyle.Pink;
            this.cbMes.TabIndex = 10;
            this.cbMes.UseSelectable = true;
            // 
            // numAno
            // 
            this.numAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAno.Location = new System.Drawing.Point(57, 86);
            this.numAno.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numAno.Name = "numAno";
            this.numAno.Size = new System.Drawing.Size(120, 26);
            this.numAno.TabIndex = 12;
            // 
            // txtFuncionario
            // 
            // 
            // 
            // 
            this.txtFuncionario.CustomButton.Image = null;
            this.txtFuncionario.CustomButton.Location = new System.Drawing.Point(214, 1);
            this.txtFuncionario.CustomButton.Name = "";
            this.txtFuncionario.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtFuncionario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFuncionario.CustomButton.TabIndex = 1;
            this.txtFuncionario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFuncionario.CustomButton.UseSelectable = true;
            this.txtFuncionario.CustomButton.Visible = false;
            this.txtFuncionario.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtFuncionario.Lines = new string[0];
            this.txtFuncionario.Location = new System.Drawing.Point(12, 60);
            this.txtFuncionario.MaxLength = 32767;
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.PasswordChar = '\0';
            this.txtFuncionario.ReadOnly = true;
            this.txtFuncionario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFuncionario.SelectedText = "";
            this.txtFuncionario.SelectionLength = 0;
            this.txtFuncionario.SelectionStart = 0;
            this.txtFuncionario.ShortcutsEnabled = true;
            this.txtFuncionario.Size = new System.Drawing.Size(244, 31);
            this.txtFuncionario.Style = MetroFramework.MetroColorStyle.Pink;
            this.txtFuncionario.TabIndex = 12;
            this.txtFuncionario.UseSelectable = true;
            this.txtFuncionario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFuncionario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(8, 125);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(183, 25);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Total em ganhos (R$):";
            // 
            // numGanhos
            // 
            this.numGanhos.DecimalPlaces = 2;
            this.numGanhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numGanhos.Location = new System.Drawing.Point(14, 153);
            this.numGanhos.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numGanhos.Name = "numGanhos";
            this.numGanhos.ReadOnly = true;
            this.numGanhos.Size = new System.Drawing.Size(101, 26);
            this.numGanhos.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Controls.Add(this.numGanhos);
            this.groupBox2.Controls.Add(this.txtFuncionario);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(426, 366);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 207);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(6, 32);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(248, 25);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "Funcionário que mais vendeu:";
            // 
            // btnLimparFiltro
            // 
            this.btnLimparFiltro.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnLimparFiltro.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnLimparFiltro.Location = new System.Drawing.Point(14, 222);
            this.btnLimparFiltro.Name = "btnLimparFiltro";
            this.btnLimparFiltro.Size = new System.Drawing.Size(240, 42);
            this.btnLimparFiltro.Style = MetroFramework.MetroColorStyle.Pink;
            this.btnLimparFiltro.TabIndex = 13;
            this.btnLimparFiltro.Text = "LIMPAR FILTRO";
            this.btnLimparFiltro.UseSelectable = true;
            this.btnLimparFiltro.Click += new System.EventHandler(this.btnLimparFiltro_Click);
            // 
            // form_historico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 650);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lvVendas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "form_historico";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Text = "Histórico de vendas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGanhos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvVendas;
        private System.Windows.Forms.ColumnHeader data_venda;
        private System.Windows.Forms.ColumnHeader preco_total_venda;
        private System.Windows.Forms.ColumnHeader usuario_admin;
        private MetroFramework.Controls.MetroButton btnVoltar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numAno;
        private MetroFramework.Controls.MetroComboBox cbMes;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton btnFiltrar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtFuncionario;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.NumericUpDown numGanhos;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnLimparFiltro;
    }
}