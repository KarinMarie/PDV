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
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtSenha.Text))
            {
                lblAviso.Text = "Por favor, preencha todos os campos.";
                return;
            }
        }
    }
}
