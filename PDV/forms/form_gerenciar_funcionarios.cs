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
    public partial class form_gerenciar_funcionarios : MetroFramework.Forms.MetroForm
    {
        DataBaseManager gerenciador = new DataBaseManager("banco");

        public form_gerenciar_funcionarios()
        {
            InitializeComponent();
        }

        private void carregar_funcionarios()
        {
            dataGrid.Rows.Clear();

            string consulta = "SELECT usuario_admin, numero_vendas_admin, ganho_vendas_admin FROM Admin";

            DataTable tabela = gerenciador.ConsultarBanco(consulta);

            foreach (DataRow row in tabela.Rows)
            {
                dataGrid.Rows.Add(row["usuario_admin"], row["numero_vendas_admin"], row["ganho_vendas_admin"]);
            }
        }

        private void adicionar_funcionario()
        {
            if (string.IsNullOrEmpty(txtUsuarioAdicionar.Text) || string.IsNullOrEmpty(txtSenhaAdicionar.Text))
            {
                MessageBox.Show("Por favor, insira corretamente todos os dados necessários.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string usuario = txtUsuarioAdicionar.Text;
            string senha = txtSenhaAdicionar.Text;

            string insercao = $"INSERT INTO Admin VALUES('{usuario}', '{senha}', 0, 0)";

            int confirmacao = gerenciador.AtualizarBanco(insercao);

            if (confirmacao == 1)
            {
                MessageBox.Show("Funcionário adicionado com êxito!", "Adicionar funcionário", MessageBoxButtons.OK, MessageBoxIcon.None);
                carregar_funcionarios();
            }
            else
                MessageBox.Show("Erro ao adicionar funcionário, tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void remover_funcionario()
        {
            if (string.IsNullOrEmpty(txtUsuarioRemover.Text))
            {
                MessageBox.Show("Por favor, insira corretamente todos os dados necessários.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string usuario = txtUsuarioRemover.Text;

            string delecao = $"DELETE FROM Admin WHERE usuario_admin = '{usuario}'";

            int confirmacao = gerenciador.AtualizarBanco(delecao);

            if (confirmacao == 1)
            {
                MessageBox.Show("Funcionário removido com êxito!", "Deletar produto", MessageBoxButtons.OK, MessageBoxIcon.None);
                carregar_funcionarios();
            }
            else
                MessageBox.Show("Erro ao remover funcionário, tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void form_gerenciar_funcionarios_Load(object sender, EventArgs e)
        {
            carregar_funcionarios();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            adicionar_funcionario();
            txtUsuarioAdicionar.Text = "";
            txtSenhaAdicionar.Text = "";
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            remover_funcionario();
            txtUsuarioRemover.Text = "";
        }
    }
}
