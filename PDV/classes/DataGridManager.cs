using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV.classes
{
    internal class DataGridManager
    {
        public string stringDeConexao;
        SqlDataAdapter dataAdapter;
        SqlCommandBuilder commandBuilder;
        DataTable dataTable;

        public DataGridManager(string nomeBanco)
        {
            string caminhoDoBanco = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\"));
            stringDeConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='" + caminhoDoBanco + nomeBanco + @".mdf';Integrated Security=True";
        }

        public void CarregarDados(string consulta, DataGridView dataGrid)
        {
            SqlConnection conexao = new SqlConnection(stringDeConexao);
            dataAdapter = new SqlDataAdapter(consulta, conexao);

            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGrid.DataSource = dataTable;
        }

        public void ModificarDados()
        {
            commandBuilder = new SqlCommandBuilder(dataAdapter);
            dataAdapter.Update(dataTable);
        }
    }
}
