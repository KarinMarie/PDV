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
    public partial class form_historico : MetroFramework.Forms.MetroForm
    {
        DataBaseManager gerenciador = new DataBaseManager("banco");

        public form_historico()
        {
            InitializeComponent();

            carregar_mes_ano();
        }

        private void carregar_mes_ano()
        {
            numAno.Value = DateTime.Now.Year;

            int mes = DateTime.Now.Month;

            switch (mes)
            {
                case 1:
                    cbMes.Text = "JANEIRO";
                    break;
                case 2:
                    cbMes.Text = "FEVEREIRO";
                    break;
                case 3:
                    cbMes.Text = "MARÇO";
                    break;
                case 4:
                    cbMes.Text = "ABRIL";
                    break;
                case 5:
                    cbMes.Text = "MAIO";
                    break;
                case 6:
                    cbMes.Text = "JUNHO";
                    break;
                case 7:
                    cbMes.Text = "JULHO";
                    break;
                case 8:
                    cbMes.Text = "AGOSTO";
                    break;
                case 9:
                    cbMes.Text = "SETEMBRO";
                    break;
                case 10:
                    cbMes.Text = "OUTUBRO";
                    break;
                case 11:
                    cbMes.Text = "NOVEMBRO";
                    break;
                case 12:
                    cbMes.Text = "DEZEMBRO";
                    break;
            }

            carregar_vendas_filtro();
        }

        private void carregar_vendas()
        {
            lvVendas.Items.Clear();
            
            string consulta = "SELECT data_venda, preco_total_venda, usuario_admin FROM Venda";

            DataTable tabela = gerenciador.ConsultarBanco(consulta);

            foreach (DataRow row in tabela.Rows)
            {
                string[] linha = { row["data_venda"].ToString(), row["preco_total_venda"].ToString(), row["usuario_admin"].ToString()};

                ListViewItem item = new ListViewItem(linha);

               lvVendas.Items.Add(item);
            }
        }

        private void carregar_vendas_filtro()
        {
            int mes = 0;
            int ano = (int)numAno.Value;

            switch (cbMes.Text)
            {
                case "JANEIRO":
                    mes = 1;
                    break;
                case "FEVEREIRO":
                    mes = 2;
                    break;
                case "MARÇO":
                    mes = 3;
                    break;
                case "ABRIL":
                    mes = 4;
                    break;
                case "MAIO":
                    mes = 5;
                    break;
                case "JUNHO":
                    mes = 6;
                    break;
                case "JULHO":
                    mes = 7;
                    break;
                case "AGOSTO":
                    mes = 8;
                    break;
                case "SETEMBRO":
                    mes = 9;
                    break;
                case "OUTUBRO":
                    mes = 10;
                    break;
                case "NOVEMBRO":
                    mes = 11;
                    break;
                case "DEZEMBRO":
                    mes = 12;
                    break;
            }

            string data;

            if (mes < 10)
                data = $"{ano}-__-0{mes}%";
            else data = $"{ano}-__-{mes}%";


            string consulta_lista = $"SELECT data_venda, preco_total_venda, usuario_admin FROM Venda WHERE CONVERT(VARCHAR(25), data_venda, 126) LIKE '{data}'";

            DataTable tabela_lista = gerenciador.ConsultarBanco(consulta_lista);

            lvVendas.Items.Clear();

            foreach (DataRow row in tabela_lista.Rows)
            {
                string[] linha = { row["data_venda"].ToString(), row["preco_total_venda"].ToString(), row["usuario_admin"].ToString() };

                ListViewItem item = new ListViewItem(linha);

                lvVendas.Items.Add(item);
            }

            string consulta_ganhos = $"SELECT SUM(preco_total_venda) FROM Venda WHERE CONVERT(VARCHAR(25), data_venda, 126) LIKE '{data}'";

            DataTable tabela_ganhos = gerenciador.ConsultarBanco(consulta_ganhos);

            if (tabela_ganhos.Rows[0][0].ToString() != "")
                numGanhos.Value = (decimal)tabela_ganhos.Rows[0][0];
            else numGanhos.Value = 0;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            carregar_vendas_filtro();
        }

        private void btnLimparFiltro_Click(object sender, EventArgs e)
        {
            carregar_vendas();
            txtFuncionario.Text = "";
            numGanhos.Value = 0;
        }
    }
}
