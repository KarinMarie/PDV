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
    public partial class form_gerenciar_avancado : MetroFramework.Forms.MetroForm
    {
        DataBaseManager gerenciador = new DataBaseManager("banco");

        public form_gerenciar_avancado()
        {
            InitializeComponent();
        }

        private void btnApagarRegistros_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Essa opção apaga todos os registros de vendas, funcionários e produtos. A alteração é definitiva.\r\n\r\nDeseja continuar?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(resultado == DialogResult.Yes)
            {
                string apagar_vendas = "DELETE FROM Venda";
                string apagar_produtos = "DELETE FROM Produto";
                string apagar_admins = "DELETE FROM Admin";
                string apagar_increment_vendas = "DBCC CHECKIDENT (Venda, RESEED, 0)";
                string apagar_increment_produtos = "DBCC CHECKIDENT (Produto, RESEED, 0)";
                string add_admin_padrao = "INSERT INTO Admin VALUES ('Admin', '123456', 0, 0)";

                int confirmacao_vendas = gerenciador.AtualizarBanco(apagar_vendas);
                int confirmacao_produtos = gerenciador.AtualizarBanco(apagar_produtos);
                int confirmacao_admins = gerenciador.AtualizarBanco(apagar_admins);
                int confirmacao_increment_vendas = gerenciador.AtualizarBanco(apagar_increment_vendas);
                int confirmacao_increment_produtos = gerenciador.AtualizarBanco(apagar_increment_produtos);
                int confirmacao_adm_padrao = gerenciador.AtualizarBanco(add_admin_padrao);

                if(confirmacao_vendas != -1 && confirmacao_produtos != -1 && confirmacao_admins != -1 && confirmacao_adm_padrao == 1)
                {
                    MessageBox.Show("Todos os dados foram deletados com êxito.", "Apagar tudo", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("Erro ao deletar dados, tente novamente.", "Apagar tudo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
