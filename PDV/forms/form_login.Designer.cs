namespace PDV
{
    partial class form_login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_login));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.txtSenha = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnLogar = new MetroFramework.Controls.MetroButton();
            this.lblAviso = new MetroFramework.Controls.MetroLabel();
            this.chkMostrarSenha = new MetroFramework.Controls.MetroCheckBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(23, 80);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(70, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Usuário";
            // 
            // txtUsuario
            // 
            this.txtUsuario.AccessibleDescription = "Insira o seu usuário aqui para realizar o log-in.";
            this.txtUsuario.AccessibleName = "Campo de usuário.";
            this.txtUsuario.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            // 
            // 
            // 
            this.txtUsuario.CustomButton.Image = null;
            this.txtUsuario.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txtUsuario.CustomButton.Name = "";
            this.txtUsuario.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsuario.CustomButton.TabIndex = 1;
            this.txtUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsuario.CustomButton.UseSelectable = true;
            this.txtUsuario.CustomButton.Visible = false;
            this.txtUsuario.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtUsuario.Lines = new string[0];
            this.txtUsuario.Location = new System.Drawing.Point(23, 108);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.PromptText = "Insira seu usuário";
            this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.ShortcutsEnabled = true;
            this.txtUsuario.Size = new System.Drawing.Size(195, 31);
            this.txtUsuario.Style = MetroFramework.MetroColorStyle.Pink;
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.UseSelectable = true;
            this.txtUsuario.WaterMark = "Insira seu usuário";
            this.txtUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtSenha
            // 
            this.txtSenha.AccessibleDescription = "Insira sua senha aqui para realizar o log-in.";
            this.txtSenha.AccessibleName = "Campo de senha.";
            this.txtSenha.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            // 
            // 
            // 
            this.txtSenha.CustomButton.Image = null;
            this.txtSenha.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txtSenha.CustomButton.Name = "";
            this.txtSenha.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSenha.CustomButton.TabIndex = 1;
            this.txtSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSenha.CustomButton.UseSelectable = true;
            this.txtSenha.CustomButton.Visible = false;
            this.txtSenha.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtSenha.Lines = new string[0];
            this.txtSenha.Location = new System.Drawing.Point(23, 186);
            this.txtSenha.MaxLength = 32767;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '●';
            this.txtSenha.PromptText = "Insira sua senha";
            this.txtSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSenha.SelectedText = "";
            this.txtSenha.SelectionLength = 0;
            this.txtSenha.SelectionStart = 0;
            this.txtSenha.ShortcutsEnabled = true;
            this.txtSenha.Size = new System.Drawing.Size(195, 31);
            this.txtSenha.Style = MetroFramework.MetroColorStyle.Pink;
            this.txtSenha.TabIndex = 3;
            this.txtSenha.UseSelectable = true;
            this.txtSenha.WaterMark = "Insira sua senha";
            this.txtSenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSenha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(23, 158);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(59, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Senha";
            // 
            // btnLogar
            // 
            this.btnLogar.AccessibleDescription = "Clique aqui para realizar o log-in.";
            this.btnLogar.AccessibleName = "Botão de logar.";
            this.btnLogar.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
            this.btnLogar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnLogar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnLogar.Location = new System.Drawing.Point(23, 276);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(195, 48);
            this.btnLogar.Style = MetroFramework.MetroColorStyle.Pink;
            this.btnLogar.TabIndex = 4;
            this.btnLogar.Text = "LOGAR";
            this.btnLogar.UseSelectable = true;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // lblAviso
            // 
            this.lblAviso.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.lblAviso.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAviso.Location = new System.Drawing.Point(23, 336);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(195, 49);
            this.lblAviso.Style = MetroFramework.MetroColorStyle.Red;
            this.lblAviso.TabIndex = 5;
            this.lblAviso.UseStyleColors = true;
            // 
            // chkMostrarSenha
            // 
            this.chkMostrarSenha.AccessibleDescription = "Clique aqui se deseja que sua senha seja visível.";
            this.chkMostrarSenha.AccessibleName = "Botão de mostrar senha.";
            this.chkMostrarSenha.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.chkMostrarSenha.AutoSize = true;
            this.chkMostrarSenha.Location = new System.Drawing.Point(23, 223);
            this.chkMostrarSenha.Name = "chkMostrarSenha";
            this.chkMostrarSenha.Size = new System.Drawing.Size(98, 15);
            this.chkMostrarSenha.Style = MetroFramework.MetroColorStyle.Pink;
            this.chkMostrarSenha.TabIndex = 6;
            this.chkMostrarSenha.Text = "Mostrar senha";
            this.chkMostrarSenha.UseSelectable = true;
            this.chkMostrarSenha.CheckedChanged += new System.EventHandler(this.chkMostrarSenha_CheckedChanged);
            // 
            // form_login
            // 
            this.AcceptButton = this.btnLogar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 397);
            this.Controls.Add(this.chkMostrarSenha);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "form_login";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Text = "Log-in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtUsuario;
        private MetroFramework.Controls.MetroTextBox txtSenha;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnLogar;
        private MetroFramework.Controls.MetroLabel lblAviso;
        private MetroFramework.Controls.MetroCheckBox chkMostrarSenha;
    }
}

