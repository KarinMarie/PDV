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
    public partial class form_gerenciar : MetroFramework.Forms.MetroForm
    {
        public form_gerenciar()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            using(form_gerenciar_funcionarios gerenciar_funcionarios = new form_gerenciar_funcionarios())
            {
                Hide();
                gerenciar_funcionarios.ShowDialog();
                Show();
            }
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            using (form_gerenciar_produtos gerenciar_produtos = new form_gerenciar_produtos())
            {
                Hide();
                gerenciar_produtos.ShowDialog();
                Show();
            }
        }

        private void btnAvancado_Click(object sender, EventArgs e)
        {
            using(form_gerenciar_avancado avancado = new form_gerenciar_avancado())
            {
                Hide();
                avancado.ShowDialog();
                Show();
            }
        }
    }
}
