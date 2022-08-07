namespace PDV.forms
{
    partial class form_gerenciar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_gerenciar));
            this.btnVoltar = new MetroFramework.Controls.MetroButton();
            this.btnProdutos = new MetroFramework.Controls.MetroButton();
            this.btnFuncionarios = new MetroFramework.Controls.MetroButton();
            this.btnAvancado = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnVoltar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnVoltar.Location = new System.Drawing.Point(23, 356);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(278, 48);
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseSelectable = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnProdutos.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnProdutos.Location = new System.Drawing.Point(23, 179);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(278, 48);
            this.btnProdutos.TabIndex = 5;
            this.btnProdutos.Text = "GERENCIAR PRODUTOS";
            this.btnProdutos.UseSelectable = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnFuncionarios.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnFuncionarios.Location = new System.Drawing.Point(23, 116);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(278, 48);
            this.btnFuncionarios.TabIndex = 4;
            this.btnFuncionarios.Text = "GERENCIAR FUNCIONÁRIOS";
            this.btnFuncionarios.UseSelectable = true;
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
            // 
            // btnAvancado
            // 
            this.btnAvancado.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnAvancado.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnAvancado.Location = new System.Drawing.Point(23, 244);
            this.btnAvancado.Name = "btnAvancado";
            this.btnAvancado.Size = new System.Drawing.Size(278, 48);
            this.btnAvancado.TabIndex = 8;
            this.btnAvancado.Text = "AVANÇADO";
            this.btnAvancado.UseSelectable = true;
            this.btnAvancado.Click += new System.EventHandler(this.btnAvancado_Click);
            // 
            // form_gerenciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 454);
            this.Controls.Add(this.btnAvancado);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnProdutos);
            this.Controls.Add(this.btnFuncionarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "form_gerenciar";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Text = "Gerenciamento";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnVoltar;
        private MetroFramework.Controls.MetroButton btnProdutos;
        private MetroFramework.Controls.MetroButton btnFuncionarios;
        private MetroFramework.Controls.MetroButton btnAvancado;
    }
}