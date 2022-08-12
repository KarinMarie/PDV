namespace PDV.forms
{
    partial class form_gerenciar_funcionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_gerenciar_funcionarios));
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.usuario_admin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero_vendas_admin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ganho_vendas_admin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVoltar = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdicionar = new MetroFramework.Controls.MetroButton();
            this.txtSenhaAdicionar = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtUsuarioAdicionar = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemover = new MetroFramework.Controls.MetroButton();
            this.txtUsuarioRemover = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AccessibleDescription = "Aqui estão todos os funcionários, com seus usuários, números de vendas e ganhos t" +
    "otais em vendas.";
            this.dataGrid.AccessibleName = "Tabela de funcionários.";
            this.dataGrid.AccessibleRole = System.Windows.Forms.AccessibleRole.Table;
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usuario_admin,
            this.numero_vendas_admin,
            this.ganho_vendas_admin});
            this.dataGrid.Location = new System.Drawing.Point(23, 73);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.Size = new System.Drawing.Size(344, 377);
            this.dataGrid.TabIndex = 0;
            // 
            // usuario_admin
            // 
            this.usuario_admin.HeaderText = "Usuário";
            this.usuario_admin.Name = "usuario_admin";
            this.usuario_admin.ReadOnly = true;
            // 
            // numero_vendas_admin
            // 
            this.numero_vendas_admin.HeaderText = "Número de vendas";
            this.numero_vendas_admin.Name = "numero_vendas_admin";
            this.numero_vendas_admin.ReadOnly = true;
            // 
            // ganho_vendas_admin
            // 
            this.ganho_vendas_admin.HeaderText = "Ganhos totais em vendas";
            this.ganho_vendas_admin.Name = "ganho_vendas_admin";
            this.ganho_vendas_admin.ReadOnly = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.AccessibleDescription = "Clique aqui para voltar ao menu anterior.";
            this.btnVoltar.AccessibleName = "Botão de Voltar";
            this.btnVoltar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnVoltar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnVoltar.Location = new System.Drawing.Point(23, 471);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(101, 39);
            this.btnVoltar.Style = MetroFramework.MetroColorStyle.Pink;
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseSelectable = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdicionar);
            this.groupBox1.Controls.Add(this.txtSenhaAdicionar);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.txtUsuarioAdicionar);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(395, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 248);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADICIONAR FUNCIONÁRIO";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.AccessibleDescription = "Clique aqui para adicionar um novo funcionário.";
            this.btnAdicionar.AccessibleName = "Botão de adicionar funcionário.";
            this.btnAdicionar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnAdicionar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnAdicionar.Location = new System.Drawing.Point(8, 189);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(234, 42);
            this.btnAdicionar.Style = MetroFramework.MetroColorStyle.Pink;
            this.btnAdicionar.TabIndex = 8;
            this.btnAdicionar.Text = "ADICIONAR";
            this.btnAdicionar.UseSelectable = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtSenhaAdicionar
            // 
            this.txtSenhaAdicionar.AccessibleDescription = "Insira aqui a senha do funcionário a ser adicionado.";
            this.txtSenhaAdicionar.AccessibleName = "Campo de senha para adicionar funcionário.";
            this.txtSenhaAdicionar.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            // 
            // 
            // 
            this.txtSenhaAdicionar.CustomButton.Image = null;
            this.txtSenhaAdicionar.CustomButton.Location = new System.Drawing.Point(204, 1);
            this.txtSenhaAdicionar.CustomButton.Name = "";
            this.txtSenhaAdicionar.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtSenhaAdicionar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSenhaAdicionar.CustomButton.TabIndex = 1;
            this.txtSenhaAdicionar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSenhaAdicionar.CustomButton.UseSelectable = true;
            this.txtSenhaAdicionar.CustomButton.Visible = false;
            this.txtSenhaAdicionar.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtSenhaAdicionar.Lines = new string[0];
            this.txtSenhaAdicionar.Location = new System.Drawing.Point(8, 128);
            this.txtSenhaAdicionar.MaxLength = 32767;
            this.txtSenhaAdicionar.Name = "txtSenhaAdicionar";
            this.txtSenhaAdicionar.PasswordChar = '\0';
            this.txtSenhaAdicionar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSenhaAdicionar.SelectedText = "";
            this.txtSenhaAdicionar.SelectionLength = 0;
            this.txtSenhaAdicionar.SelectionStart = 0;
            this.txtSenhaAdicionar.ShortcutsEnabled = true;
            this.txtSenhaAdicionar.Size = new System.Drawing.Size(234, 31);
            this.txtSenhaAdicionar.Style = MetroFramework.MetroColorStyle.Pink;
            this.txtSenhaAdicionar.TabIndex = 5;
            this.txtSenhaAdicionar.UseSelectable = true;
            this.txtSenhaAdicionar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSenhaAdicionar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(6, 100);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(64, 25);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Senha:";
            // 
            // txtUsuarioAdicionar
            // 
            this.txtUsuarioAdicionar.AccessibleDescription = "Insira aqui o usuário do funcionário a ser adicionado.";
            this.txtUsuarioAdicionar.AccessibleName = "Campo de usuário para adicionar novo funcionario.";
            this.txtUsuarioAdicionar.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            // 
            // 
            // 
            this.txtUsuarioAdicionar.CustomButton.Image = null;
            this.txtUsuarioAdicionar.CustomButton.Location = new System.Drawing.Point(204, 1);
            this.txtUsuarioAdicionar.CustomButton.Name = "";
            this.txtUsuarioAdicionar.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtUsuarioAdicionar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsuarioAdicionar.CustomButton.TabIndex = 1;
            this.txtUsuarioAdicionar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsuarioAdicionar.CustomButton.UseSelectable = true;
            this.txtUsuarioAdicionar.CustomButton.Visible = false;
            this.txtUsuarioAdicionar.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtUsuarioAdicionar.Lines = new string[0];
            this.txtUsuarioAdicionar.Location = new System.Drawing.Point(8, 56);
            this.txtUsuarioAdicionar.MaxLength = 32767;
            this.txtUsuarioAdicionar.Name = "txtUsuarioAdicionar";
            this.txtUsuarioAdicionar.PasswordChar = '\0';
            this.txtUsuarioAdicionar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuarioAdicionar.SelectedText = "";
            this.txtUsuarioAdicionar.SelectionLength = 0;
            this.txtUsuarioAdicionar.SelectionStart = 0;
            this.txtUsuarioAdicionar.ShortcutsEnabled = true;
            this.txtUsuarioAdicionar.Size = new System.Drawing.Size(234, 31);
            this.txtUsuarioAdicionar.Style = MetroFramework.MetroColorStyle.Pink;
            this.txtUsuarioAdicionar.TabIndex = 3;
            this.txtUsuarioAdicionar.UseSelectable = true;
            this.txtUsuarioAdicionar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsuarioAdicionar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(8, 28);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(76, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Usuário:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemover);
            this.groupBox2.Controls.Add(this.txtUsuarioRemover);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(395, 336);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 174);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "REMOVER FUNCIONÁRIO";
            // 
            // btnRemover
            // 
            this.btnRemover.AccessibleDescription = "Clique aqui para remover o usuário.";
            this.btnRemover.AccessibleName = "Botão de Remover Usuário.";
            this.btnRemover.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnRemover.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnRemover.Location = new System.Drawing.Point(8, 114);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(234, 42);
            this.btnRemover.Style = MetroFramework.MetroColorStyle.Pink;
            this.btnRemover.TabIndex = 8;
            this.btnRemover.Text = "REMOVER";
            this.btnRemover.UseSelectable = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // txtUsuarioRemover
            // 
            this.txtUsuarioRemover.AccessibleDescription = "Insira aqui o usuário do funcionário a ser removido.";
            this.txtUsuarioRemover.AccessibleName = "Campo de usuário para remover usuário.";
            this.txtUsuarioRemover.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            // 
            // 
            // 
            this.txtUsuarioRemover.CustomButton.Image = null;
            this.txtUsuarioRemover.CustomButton.Location = new System.Drawing.Point(204, 1);
            this.txtUsuarioRemover.CustomButton.Name = "";
            this.txtUsuarioRemover.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtUsuarioRemover.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsuarioRemover.CustomButton.TabIndex = 1;
            this.txtUsuarioRemover.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsuarioRemover.CustomButton.UseSelectable = true;
            this.txtUsuarioRemover.CustomButton.Visible = false;
            this.txtUsuarioRemover.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtUsuarioRemover.Lines = new string[0];
            this.txtUsuarioRemover.Location = new System.Drawing.Point(8, 59);
            this.txtUsuarioRemover.MaxLength = 32767;
            this.txtUsuarioRemover.Name = "txtUsuarioRemover";
            this.txtUsuarioRemover.PasswordChar = '\0';
            this.txtUsuarioRemover.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuarioRemover.SelectedText = "";
            this.txtUsuarioRemover.SelectionLength = 0;
            this.txtUsuarioRemover.SelectionStart = 0;
            this.txtUsuarioRemover.ShortcutsEnabled = true;
            this.txtUsuarioRemover.Size = new System.Drawing.Size(234, 31);
            this.txtUsuarioRemover.Style = MetroFramework.MetroColorStyle.Pink;
            this.txtUsuarioRemover.TabIndex = 3;
            this.txtUsuarioRemover.UseSelectable = true;
            this.txtUsuarioRemover.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsuarioRemover.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(6, 31);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(76, 25);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Usuário:";
            // 
            // form_gerenciar_funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 526);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "form_gerenciar_funcionarios";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Text = "Gerenciar funcionários";
            this.Load += new System.EventHandler(this.form_gerenciar_funcionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private MetroFramework.Controls.MetroButton btnVoltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario_admin;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_vendas_admin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ganho_vendas_admin;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtSenhaAdicionar;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtUsuarioAdicionar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnAdicionar;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton btnRemover;
        private MetroFramework.Controls.MetroTextBox txtUsuarioRemover;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}