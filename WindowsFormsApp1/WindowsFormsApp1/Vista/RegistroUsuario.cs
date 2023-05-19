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
    public partial class RegistroUsuario : Form
    {
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        public bool RegistrarUsuario(string usuario, string password)
        {
            string connectionString = "Data Source=DESKTOP-0MV3KDN\\SQLEXPRESS;Initial Catalog=CompanyIHJ;Integrated Security=True";

            string insertQuery = "INSERT INTO Usuarios (usuario, password) VALUES (@Usuario, @Password)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@Usuario", usuario);
                command.Parameters.AddWithValue("@Password", password);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al registrar el usuario: " + ex.Message);
                    return false;
                }
            }
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            string usuario = txtuser.Text;
            string password = txtpass.Text;
            string RepPassword = textBox1.Text;

            if (password.Equals(RepPassword)) {
                RegistrarUsuario(usuario, password);
                MessageBox.Show("Usuario registrado correctamente");
                this.Hide();
            } else
            {
                MessageBox.Show("Contraseñas incorrectas, Intentelo nuevamente");
            }
        }
    }
}
