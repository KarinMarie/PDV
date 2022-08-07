using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV.forms
{
    public partial class form_principal : MetroFramework.Forms.MetroForm
    {
        string admin;

        public form_principal(string admin)
        {
            InitializeComponent();

            this.admin = admin;

            lblAdmin.Text = $"Bem-vindo, {this.admin}.";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGerenciar_Click(object sender, EventArgs e)
        {
            using(form_gerenciar gerenciar = new form_gerenciar())
            {
                Hide();
                gerenciar.ShowDialog();
                Show();
            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            using(form_vender vender = new form_vender(admin))
            {
                Hide();
                vender.ShowDialog();
                Show();
            }
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            using(form_historico historico = new form_historico())
            {
                Hide();
                historico.ShowDialog();
                Show();
            }
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            using(form_ajuda ajuda = new form_ajuda())
            {
                Hide();
                ajuda.ShowDialog();
                Show();
            }
        }
    }
}
