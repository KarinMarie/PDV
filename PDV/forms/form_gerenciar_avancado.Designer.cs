namespace PDV.forms
{
    partial class form_gerenciar_avancado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_gerenciar_avancado));
            this.btnApagarRegistros = new MetroFramework.Controls.MetroButton();
            this.btnVoltar = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnApagarRegistros
            // 
            this.btnApagarRegistros.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnApagarRegistros.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnApagarRegistros.Location = new System.Drawing.Point(27, 94);
            this.btnApagarRegistros.Name = "btnApagarRegistros";
            this.btnApagarRegistros.Size = new System.Drawing.Size(278, 48);
            this.btnApagarRegistros.TabIndex = 9;
            this.btnApagarRegistros.Text = "APAGAR TODOS OS REGISTROS";
            this.btnApagarRegistros.UseSelectable = true;
            this.btnApagarRegistros.Click += new System.EventHandler(this.btnApagarRegistros_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnVoltar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnVoltar.Location = new System.Drawing.Point(27, 207);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(278, 48);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseSelectable = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // form_gerenciar_avancado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 300);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnApagarRegistros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "form_gerenciar_avancado";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Text = "Avançado";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnApagarRegistros;
        private MetroFramework.Controls.MetroButton btnVoltar;
    }
}