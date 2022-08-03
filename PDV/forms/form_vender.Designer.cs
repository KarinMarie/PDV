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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_vender));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNota = new MetroFramework.Controls.MetroTextBox();
            this.txt_admin = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.num_total = new System.Windows.Forms.NumericUpDown();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnConcluir = new MetroFramework.Controls.MetroButton();
            this.view_produtos = new System.Windows.Forms.ListView();
            this.btnVoltar = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_total)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNota);
            this.groupBox1.Controls.Add(this.txt_admin);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.num_total);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(527, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 432);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DETALHES";
            // 
            // txtNota
            // 
            // 
            // 
            // 
            this.txtNota.CustomButton.Image = null;
            this.txtNota.CustomButton.Location = new System.Drawing.Point(63, 1);
            this.txtNota.CustomButton.Name = "";
            this.txtNota.CustomButton.Size = new System.Drawing.Size(271, 271);
            this.txtNota.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNota.CustomButton.TabIndex = 1;
            this.txtNota.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNota.CustomButton.UseSelectable = true;
            this.txtNota.CustomButton.Visible = false;
            this.txtNota.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtNota.Lines = new string[0];
            this.txtNota.Location = new System.Drawing.Point(6, 144);
            this.txtNota.MaxLength = 32767;
            this.txtNota.Multiline = true;
            this.txtNota.Name = "txtNota";
            this.txtNota.PasswordChar = '\0';
            this.txtNota.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNota.SelectedText = "";
            this.txtNota.SelectionLength = 0;
            this.txtNota.SelectionStart = 0;
            this.txtNota.ShortcutsEnabled = true;
            this.txtNota.Size = new System.Drawing.Size(335, 273);
            this.txtNota.Style = MetroFramework.MetroColorStyle.Pink;
            this.txtNota.TabIndex = 4;
            this.txtNota.UseSelectable = true;
            this.txtNota.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNota.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_admin
            // 
            // 
            // 
            // 
            this.txt_admin.CustomButton.Image = null;
            this.txt_admin.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.txt_admin.CustomButton.Name = "";
            this.txt_admin.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txt_admin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_admin.CustomButton.TabIndex = 1;
            this.txt_admin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_admin.CustomButton.UseSelectable = true;
            this.txt_admin.CustomButton.Visible = false;
            this.txt_admin.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_admin.Lines = new string[0];
            this.txt_admin.Location = new System.Drawing.Point(152, 88);
            this.txt_admin.MaxLength = 32767;
            this.txt_admin.Multiline = true;
            this.txt_admin.Name = "txt_admin";
            this.txt_admin.PasswordChar = '\0';
            this.txt_admin.ReadOnly = true;
            this.txt_admin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_admin.SelectedText = "";
            this.txt_admin.SelectionLength = 0;
            this.txt_admin.SelectionStart = 0;
            this.txt_admin.ShortcutsEnabled = true;
            this.txt_admin.Size = new System.Drawing.Size(189, 31);
            this.txt_admin.Style = MetroFramework.MetroColorStyle.Pink;
            this.txt_admin.TabIndex = 3;
            this.txt_admin.UseSelectable = true;
            this.txt_admin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_admin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(6, 88);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(140, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Administrador:";
            // 
            // num_total
            // 
            this.num_total.DecimalPlaces = 2;
            this.num_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_total.Location = new System.Drawing.Point(165, 35);
            this.num_total.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.num_total.Name = "num_total";
            this.num_total.ReadOnly = true;
            this.num_total.Size = new System.Drawing.Size(176, 31);
            this.num_total.TabIndex = 1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(6, 35);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(153, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Preço Total (R$):";
            // 
            // btnConcluir
            // 
            this.btnConcluir.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnConcluir.Location = new System.Drawing.Point(527, 511);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(347, 55);
            this.btnConcluir.TabIndex = 2;
            this.btnConcluir.Text = "CONCLUIR VENDA";
            this.btnConcluir.UseSelectable = true;
            // 
            // view_produtos
            // 
            this.view_produtos.HideSelection = false;
            this.view_produtos.Location = new System.Drawing.Point(23, 73);
            this.view_produtos.Name = "view_produtos";
            this.view_produtos.Size = new System.Drawing.Size(498, 432);
            this.view_produtos.TabIndex = 3;
            this.view_produtos.UseCompatibleStateImageBehavior = false;
            this.view_produtos.View = System.Windows.Forms.View.Tile;
            // 
            // btnVoltar
            // 
            this.btnVoltar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnVoltar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnVoltar.Location = new System.Drawing.Point(23, 527);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(101, 39);
            this.btnVoltar.Style = MetroFramework.MetroColorStyle.Pink;
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseSelectable = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // form_vender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 594);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.view_produtos);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_vender";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Text = "Efetuar Vendas";
            this.Load += new System.EventHandler(this.form_vender_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_total)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnConcluir;
        private MetroFramework.Controls.MetroTextBox txtNota;
        private MetroFramework.Controls.MetroTextBox txt_admin;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.NumericUpDown num_total;
        private System.Windows.Forms.ListView view_produtos;
        private MetroFramework.Controls.MetroButton btnVoltar;
    }
}