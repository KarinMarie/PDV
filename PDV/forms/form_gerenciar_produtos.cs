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
    public partial class form_gerenciar_produtos : MetroFramework.Forms.MetroForm
    {
        DataBaseManager gerenciador = new DataBaseManager("banco");

        bool sucesso_adicao;
        bool sucesso_atualizacao;
        bool sucesso_exclusao;

        public form_gerenciar_produtos()
        {
            InitializeComponent();
        }

        private void carregar_produtos()
        {
            dataGrid.Rows.Clear();
            
            string consulta = "SELECT * FROM Produto";

            DataTable tabela = gerenciador.ConsultarBanco(consulta);

            foreach (DataRow row in tabela.Rows)
            {
                dataGrid.Rows.Add(row["codigo_produto"], row["nome_produto"], row["preco_produto"], row["estoque_produto"], row["categoria_produto"]);
            }
        }

        private void adicionar_produto()
        {
            if (string.IsNullOrEmpty(txtNome.Text) || numPreco.Value == 0 || cbCategoria.Text == "")
            {
                MessageBox.Show("Por favor, insira corretamente todos os dados necessários.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            string nome = txtNome.Text;
            decimal preco = numPreco.Value;
            int estoque = (int)numEstoque.Value;
            string categoria = cbCategoria.Text;

            string insercao = $"INSERT INTO Produto VALUES('{nome}', {preco}, {estoque}, '{categoria}')";

            int confirmacao = gerenciador.AtualizarBanco(insercao);

            if(confirmacao == 1)
            {
                sucesso_adicao = true;
                MessageBox.Show("Produto adicionado com êxito!", "Inserção de produto", MessageBoxButtons.OK, MessageBoxIcon.None);
                carregar_produtos();
            }
            else
                MessageBox.Show("Erro na inserção do produto, tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void excluir_produto()
        {
            if(numCod.Value == 0)
            {
                MessageBox.Show("Por favor, insira corretamente todos os dados necessários.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int codigo = (int)numCod.Value;

            string delecao = $"DELETE FROM Produto WHERE codigo_produto = {codigo}";

            int confirmacao = gerenciador.AtualizarBanco(delecao);

            if (confirmacao == 1)
            {
                sucesso_exclusao = true;
                MessageBox.Show("Produto deletado com êxito!", "Deletar produto", MessageBoxButtons.OK, MessageBoxIcon.None);
                carregar_produtos();
            }
            else
                MessageBox.Show("Erro ao deletar produto, tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void atualizar_estoque()
        {
            if (numCodigoEstoque.Value == 0)
            {
                MessageBox.Show("Por favor, insira corretamente todos os dados necessários.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int codigo = (int)numCodigoEstoque.Value;
            int estoque = (int)numNovoEstoque.Value;

            string atualizacao = $"UPDATE Produto SET estoque_produto = {estoque} WHERE codigo_produto = {codigo}";

            int confirmacao = gerenciador.AtualizarBanco(atualizacao);

            if (confirmacao == 1)
            {
                sucesso_atualizacao = true;
                MessageBox.Show("Estoque atualizado com êxito!", "Atualizar estoque", MessageBoxButtons.OK, MessageBoxIcon.None);
                carregar_produtos();
            }
            else
                MessageBox.Show("Erro ao atualizar estoque produto, tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void filtrar_produtos()
        {
            if (cbFiltrarCategoria.Text == "")
            {
                MessageBox.Show("Por favor, insira corretamente todos os dados necessários.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGrid.Rows.Clear();

            string categoria = cbFiltrarCategoria.Text;

            string consulta = $"SELECT * FROM Produto WHERE categoria_produto = '{categoria}'";

            DataTable tabela = gerenciador.ConsultarBanco(consulta);

            foreach (DataRow row in tabela.Rows)
            {
                dataGrid.Rows.Add(row["codigo_produto"], row["nome_produto"], row["preco_produto"], row["estoque_produto"], row["categoria_produto"]);
            }
        }

        private void form_gerenciar_produtos_Load(object sender, EventArgs e)
        {      
            carregar_produtos();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            adicionar_produto();
            
            if(sucesso_adicao)
            {
                txtNome.Text = "";
                numPreco.Value = 0;
                numEstoque.Value = 0;
                cbCategoria.SelectedIndex = -1;
            } 
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            excluir_produto();

            if (sucesso_exclusao)
                numCod.Value = 0;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            atualizar_estoque();

            if (sucesso_atualizacao)
            {
                numCodigoEstoque.Value = 0;
                numNovoEstoque.Value = 0;
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            filtrar_produtos();
            cbFiltrarCategoria.SelectedIndex = -1;
        }

        private void btnRemoverFiltros_Click(object sender, EventArgs e)
        {
            carregar_produtos();
        }

        private void cb_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbFiltrarCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_Click(object sender, EventArgs e)
        {

        }
    }
}
