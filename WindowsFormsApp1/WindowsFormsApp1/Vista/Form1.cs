using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Vista;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "USUARIO")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if(txtuser.Text == "")
            {
                txtuser.Text = "USUARIO";
                txtuser.ForeColor = Color.DimGray;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if(txtpass.Text == "CONTRASEÑA")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if( txtpass.Text == "")
            {
                txtpass.Text = "CONTRASEÑA";
                txtpass.ForeColor = Color.DimGray;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Dashboard board = new Dashboard();
            DashboardAdmin boardAdmin = new DashboardAdmin();
            Form1 frm = new Form1();
            string usuarioPrueba = "admin";
            string passwordPrueba = "admin";
            string usuarioPrueba2 = "tito";
            string passwordPrueba2 = "tito";
            string usuarioLogin = txtuser.Text;
            string passwordLogin = txtpass.Text;


            if (usuarioLogin.Equals(usuarioPrueba) || passwordLogin.Equals(passwordPrueba))
            {
                MessageBox.Show($"Bienvendio {usuarioLogin}");
                boardAdmin.Show();
            } else if (usuarioLogin.Equals(usuarioPrueba2) || passwordLogin.Equals(passwordPrueba2)) {
                MessageBox.Show($"Bienvendio {usuarioLogin}");
                board.Show();
            }
            else {
                MessageBox.Show("tito peruano los datos no coinciden");
            }
        }
    }
}
