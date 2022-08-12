namespace PDV.forms
{
    partial class form_ajuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_ajuda));
            this.cbProblema = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtTutorial = new MetroFramework.Controls.MetroTextBox();
            this.btnVoltar = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // cbProblema
            // 
            this.cbProblema.AccessibleDescription = "Selecione aqui o problema no qual você precisa de instruções.";
            this.cbProblema.AccessibleName = "Campo de selecionar problema.";
            this.cbProblema.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.cbProblema.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cbProblema.FormattingEnabled = true;
            this.cbProblema.ItemHeight = 29;
            this.cbProblema.Items.AddRange(new object[] {
            "CADASTRAR UM FUNCIONÁRIO",
            "EXCLUIR UM FUNCIONÁRIO",
            "CADASTRAR UM PRODUTO",
            "EXCLUIR UM PRODUTO",
            "ATUALIZAR ESTOQUE",
            "FILTRAR PRODUTOS",
            "REALIZAR VENDAS",
            "VISUALIZAR HISTÓRICO DE VENDAS",
            "APAGAR TODOS OS REGISTROS"});
            this.cbProblema.Location = new System.Drawing.Point(23, 119);
            this.cbProblema.Name = "cbProblema";
            this.cbProblema.Size = new System.Drawing.Size(336, 35);
            this.cbProblema.Style = MetroFramework.MetroColorStyle.Pink;
            this.cbProblema.TabIndex = 0;
            this.cbProblema.UseSelectable = true;
            this.cbProblema.SelectedIndexChanged += new System.EventHandler(this.cbProblema_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(94, 82);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(197, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Selecione seu problema:";
            // 
            // txtTutorial
            // 
            this.txtTutorial.AccessibleDescription = "Aqui está o tutorial para te guiar na solução do problema.";
            this.txtTutorial.AccessibleName = "Instruções para resolver o problema.";
            this.txtTutorial.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            // 
            // 
            // 
            this.txtTutorial.CustomButton.Image = null;
            this.txtTutorial.CustomButton.Location = new System.Drawing.Point(-104, 1);
            this.txtTutorial.CustomButton.Name = "";
            this.txtTutorial.CustomButton.Size = new System.Drawing.Size(439, 439);
            this.txtTutorial.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTutorial.CustomButton.TabIndex = 1;
            this.txtTutorial.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTutorial.CustomButton.UseSelectable = true;
            this.txtTutorial.CustomButton.Visible = false;
            this.txtTutorial.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtTutorial.Lines = new string[0];
            this.txtTutorial.Location = new System.Drawing.Point(23, 180);
            this.txtTutorial.MaxLength = 32767;
            this.txtTutorial.Multiline = true;
            this.txtTutorial.Name = "txtTutorial";
            this.txtTutorial.PasswordChar = '\0';
            this.txtTutorial.ReadOnly = true;
            this.txtTutorial.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTutorial.SelectedText = "";
            this.txtTutorial.SelectionLength = 0;
            this.txtTutorial.SelectionStart = 0;
            this.txtTutorial.ShortcutsEnabled = true;
            this.txtTutorial.Size = new System.Drawing.Size(336, 441);
            this.txtTutorial.Style = MetroFramework.MetroColorStyle.Pink;
            this.txtTutorial.TabIndex = 2;
            this.txtTutorial.UseSelectable = true;
            this.txtTutorial.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTutorial.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnVoltar
            // 
            this.btnVoltar.AccessibleDescription = "Clique aqui para voltar ao menu anterior.";
            this.btnVoltar.AccessibleName = "Botão de Voltar.";
            this.btnVoltar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnVoltar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnVoltar.Location = new System.Drawing.Point(23, 637);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(101, 39);
            this.btnVoltar.Style = MetroFramework.MetroColorStyle.Pink;
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseSelectable = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // form_ajuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 690);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtTutorial);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cbProblema);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "form_ajuda";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Text = "Ajuda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cbProblema;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtTutorial;
        private MetroFramework.Controls.MetroButton btnVoltar;
    }
}