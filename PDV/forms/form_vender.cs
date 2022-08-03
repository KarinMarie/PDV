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

namespace PDV.forms
{
    public partial class form_vender : MetroFramework.Forms.MetroForm
    {
        DataBaseManager gerenciador = new DataBaseManager("banco");

        public form_vender(string admin)
        {
            InitializeComponent();

            txt_admin.Text = admin;
        }

        private void form_vender_Load(object sender, EventArgs e)
        {
            //view_produtos.FullRowSelect = true;

            //string consulta = "SELECT * FROM Produto";

            //DataTable tabela = gerenciador.ConsultarBanco(consulta);

            //foreach (DataRow row in tabela.Rows)
            //{
            //    ListViewItem item = new ListViewItem(row[0].ToString());
            //    for (int i = 1; i < tabela.Columns.Count; i++)
            //    {
            //        item.SubItems.Add(row[i].ToString());
            //    }
            //    view_produtos.Items.Add(item);
            //}
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
