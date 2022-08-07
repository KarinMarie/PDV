using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV.forms
{
    public partial class form_ajuda : MetroFramework.Forms.MetroForm
    {
        string path = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\", @"tutorial\"));

        public form_ajuda()
        {
            InitializeComponent();
        }

        private void carregar_problema(int index)
        {
            try
            {
                string[] arquivos = Directory.GetFiles(path);

                using (StreamReader leitor = new StreamReader(arquivos[index]))
                {
                    txtTutorial.Text = leitor.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().FullName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbProblema_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cbProblema.Text)
            {
                case "REALIZAR UMA VENDA":
                    carregar_problema(0);
                    break;

            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
