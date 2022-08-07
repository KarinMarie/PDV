namespace PDV.forms
{
    partial class form_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_principal));
            this.btnVender = new MetroFramework.Controls.MetroButton();
            this.btnGerenciar = new MetroFramework.Controls.MetroButton();
            this.btnAjuda = new MetroFramework.Controls.MetroButton();
            this.btnSair = new MetroFramework.Controls.MetroButton();
            this.lblAdmin = new MetroFramework.Controls.MetroLabel();
            this.btnHistorico = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnVender
            // 
            this.btnVender.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnVender.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnVender.Location = new System.Drawing.Point(23, 109);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(278, 48);
            this.btnVender.TabIndex = 0;
            this.btnVender.Text = "EFETUAR VENDAS";
            this.btnVender.UseSelectable = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnGerenciar
            // 
            this.btnGerenciar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnGerenciar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnGerenciar.Location = new System.Drawing.Point(23, 238);
            this.btnGerenciar.Name = "btnGerenciar";
            this.btnGerenciar.Size = new System.Drawing.Size(278, 48);
            this.btnGerenciar.TabIndex = 1;
            this.btnGerenciar.Text = "GERENCIAMENTO";
            this.btnGerenciar.UseSelectable = true;
            this.btnGerenciar.Click += new System.EventHandler(this.btnGerenciar_Click);
            // 
            // btnAjuda
            // 
            this.btnAjuda.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnAjuda.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnAjuda.Location = new System.Drawing.Point(23, 302);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(278, 48);
            this.btnAjuda.TabIndex = 2;
            this.btnAjuda.Text = "AJUDA";
            this.btnAjuda.UseSelectable = true;
            // 
            // btnSair
            // 
            this.btnSair.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSair.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSair.Location = new System.Drawing.Point(23, 413);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(278, 48);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseSelectable = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAdmin.Location = new System.Drawing.Point(6, 484);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(137, 19);
            this.lblAdmin.Style = MetroFramework.MetroColorStyle.Pink;
            this.lblAdmin.TabIndex = 4;
            this.lblAdmin.Text = "Bem-vindo, admin.";
            this.lblAdmin.UseStyleColors = true;
            // 
            // btnHistorico
            // 
            this.btnHistorico.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnHistorico.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnHistorico.Location = new System.Drawing.Point(23, 173);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(278, 48);
            this.btnHistorico.TabIndex = 5;
            this.btnHistorico.Text = "HISTÓRICO DE VENDAS";
            this.btnHistorico.UseSelectable = true;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // form_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 512);
            this.Controls.Add(this.btnHistorico);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAjuda);
            this.Controls.Add(this.btnGerenciar);
            this.Controls.Add(this.btnVender);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "form_principal";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Text = "Ponto de Venda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnVender;
        private MetroFramework.Controls.MetroButton btnGerenciar;
        private MetroFramework.Controls.MetroButton btnAjuda;
        private MetroFramework.Controls.MetroButton btnSair;
        private MetroFramework.Controls.MetroLabel lblAdmin;
        private MetroFramework.Controls.MetroButton btnHistorico;
    }
}