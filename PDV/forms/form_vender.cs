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
        List<string> atualizacoes_estoque = new List<string>();
        int ultimo_index_selecionado;
        decimal preco_total_compra;

        public form_vender(string admin)
        {
            InitializeComponent();

            txtAdmin.Text = admin;

            numCodigoProduto.Controls.RemoveAt(0);
            numPrecoProduto.Controls.RemoveAt(0);
            numTotal.Controls.RemoveAt(0);

            txtNota.Text = " - - - LISTA DE COMPRAS - - - \r\n\r\n";

            timer.Interval = 1000;
            timer.Enabled = true;
            txtHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void limpar_tudo()
        {
            numCodigoProduto.Value = 0;
            txtNomeProduto.Text = "";
            numPrecoProduto.Value = 0;
            numQuantidadeProduto.Value = 1;
            numTotal.Value = 0;
            ultimo_index_selecionado = -1;
            preco_total_compra = 0;
            txtNota.Text = " - - - LISTA DE COMPRAS - - - \r\n\r\n";
            btnImprimir.Enabled = false;
            carregar_produtos();
        }

        private void carregar_produtos()
        {
            view_produtos.Items.Clear();

            string consulta = "SELECT * FROM Produto";

            DataTable tabela = gerenciador.ConsultarBanco(consulta);


            foreach (DataRow row in tabela.Rows)
            {
                if ((int)row["estoque_produto"] > 0)
                {
                    string[] linha = { row["codigo_produto"].ToString(), row["nome_produto"].ToString(), row["preco_produto"].ToString(), row["estoque_produto"].ToString(), row["categoria_produto"].ToString() };

                    ListViewItem item = new ListViewItem(linha);

                    view_produtos.Items.Add(item);
                }
            }
        }

        private void carregar_dados_produto(int codigo)
        {
            string consulta = $"SELECT * FROM Produto WHERE codigo_produto = {codigo}";

            DataTable tabela = gerenciador.ConsultarBanco(consulta);

            string nome_produto = tabela.Rows[0]["nome_produto"].ToString();
            decimal preco_produto = (decimal)tabela.Rows[0]["preco_produto"];
            int estoque_produto = (int)tabela.Rows[0]["estoque_produto"];

            numCodigoProduto.Value = codigo;
            txtNomeProduto.Text = nome_produto;
            numPrecoProduto.Value = preco_produto;

            numQuantidadeProduto.Maximum = estoque_produto;
        }

        private void limpar_dados_produto()
        {
            numCodigoProduto.Value = 0;
            txtNomeProduto.Text = "";
            numPrecoProduto.Value = 0;
            numQuantidadeProduto.Value = 1;
        }

        private void adicionar_carrinho(int codigo, string nome, decimal preco, int quantidade)
        {
            if (numCodigoProduto.Value == 0 || numPrecoProduto.Value == 0 || string.IsNullOrEmpty(txtNomeProduto.Text))
                return;

            numTotal.Value += preco * quantidade;
            txtNota.Text += $"\r\n{quantidade} - {nome} - R$ {preco * quantidade}";

            string consulta = $"UPDATE Produto SET estoque_produto = estoque_produto - {quantidade} WHERE codigo_produto = {codigo}";

            atualizacoes_estoque.Add(consulta);
            limpar_dados_produto();

            view_produtos.Items.RemoveAt(ultimo_index_selecionado);
            preco_total_compra += preco * quantidade;
        }

        private void vender()
        {
            DateTime data_venda = DateTime.Now;
            decimal preco_total_venda = numTotal.Value;
            string usuario_admin = txtAdmin.Text;

            string adiciona_venda = $"INSERT INTO Venda VALUES('{data_venda}', {preco_total_venda}, '{usuario_admin}')";
            string atualiza_admin = $"UPDATE Admin SET numero_vendas_admin = numero_vendas_admin + 1, ganho_vendas_admin = ganho_vendas_admin + {preco_total_venda} WHERE usuario_admin = '{usuario_admin}'";

            int linhas_afetadas_venda = gerenciador.AtualizarBanco(adiciona_venda);
            int linhas_afetadas_admin = gerenciador.AtualizarBanco(atualiza_admin);

            if (linhas_afetadas_venda == 1 && linhas_afetadas_admin == 1)
            {
                MessageBox.Show("Venda realizada com sucesso!", "Venda", MessageBoxButtons.OK, MessageBoxIcon.None);

                foreach(string update in atualizacoes_estoque)
                    gerenciador.AtualizarBanco(update);
                    
                carregar_produtos();

                txtNota.Text += $"\r\n\r\n\r\n[Total: R$ {preco_total_compra}]\r\n\r\nAgradecemos pela preferência!";
                btnImprimir.Enabled = true;
            }
        }

        private void form_vender_Load(object sender, EventArgs e)
        {
            carregar_produtos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void view_produtos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //view_produtos.FullRowSelect = true;

            int codigo;

            if (view_produtos.SelectedIndices.Count <= 0)
            {
                return;
            }

            int intselectedindex = view_produtos.SelectedIndices[0];

            if (intselectedindex >= 0)
            {
               codigo = Convert.ToInt32(view_produtos.Items[intselectedindex].Text);

                carregar_dados_produto(codigo);
            }

            ultimo_index_selecionado = intselectedindex;
        }

        private void btnAdicionarProdutos_Click(object sender, EventArgs e)
        {
            adicionar_carrinho((int)numCodigoProduto.Value ,txtNomeProduto.Text, numPrecoProduto.Value, (int)numQuantidadeProduto.Value);
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            vender();
            atualizacoes_estoque.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpar_tudo();
            atualizacoes_estoque.Clear();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if(printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.PrinterSettings = printDialog.PrinterSettings;
                printDocument.Print();
            }

            limpar_tudo();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtNota.Text, txtNota.Font, Brushes.Black, 100, 100);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            txtHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
