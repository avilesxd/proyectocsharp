using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Vista
{
    public partial class DashboardAdmin : Form
    {
        private string connectionString = "Data Source=DESKTOP-0MV3KDN\\SQLEXPRESS;Initial Catalog=CompanyIHJ;Integrated Security=True";
        private string tableName = "Clientes";
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;
        public DashboardAdmin()
        {
            InitializeComponent();
            dataGridView1.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            dataTable = new DataTable();

            CargarDatos();
        }

        private void CargarDatos()
        {
            string query = $"SELECT * FROM {tableName}";

            try
            {
                dataAdapter = new SqlDataAdapter(query, connection);

                connection.Open();
                dataAdapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar los datos: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
