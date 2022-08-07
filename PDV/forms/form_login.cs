using PDV.forms;
using PDV.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV
{
    public partial class form_login : MetroFramework.Forms.MetroForm
    {
        DataBaseManager gerenciador = new DataBaseManager("banco");
        string admin;


        public form_login()
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";

            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtSenha.Text))
            {
                lblAviso.Text = "Por favor, preencha todos\nos campos.";
                return;
            }

            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            string consulta = $"SELECT COUNT(*) FROM Admin WHERE usuario_admin = '{usuario}' AND senha_admin = '{senha}'";

            DataTable tabela = gerenciador.ConsultarBanco(consulta);

            int confirmacao = (int)tabela.Rows[0][0];

            if (confirmacao == 1)
            {
                admin = usuario;

                using (form_principal principal = new form_principal(admin))
                {
                    Hide();
                    principal.ShowDialog();
                    Close();
                }
            }
            else
                lblAviso.Text = "Não foi possível realizar o\nlog-in, tente novamente.";

        }

        private void chkMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarSenha.Checked)
                txtSenha.PasswordChar = '\0';
            else txtSenha.PasswordChar = '●';
        }
    }
}
