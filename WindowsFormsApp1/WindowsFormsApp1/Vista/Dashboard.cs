using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Vista
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ImagenGrande.Image = WindowsFormsApp1.Properties.Resources.fortnite;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            ImagenGrande.Image = WindowsFormsApp1.Properties.Resources.fortnite;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ImagenGrande.Image = WindowsFormsApp1.Properties.Resources._2x1_NSwitch_PokemonScarletViolet_Combo_esES;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            ImagenGrande.Image = WindowsFormsApp1.Properties.Resources._2x1_NSwitch_PokemonScarletViolet_Combo_esES;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ImagenGrande.Image = WindowsFormsApp1.Properties.Resources.cops;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            ImagenGrande.Image = WindowsFormsApp1.Properties.Resources.cops;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ImagenGrande.Image = WindowsFormsApp1.Properties.Resources.wow;
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            ImagenGrande.Image = WindowsFormsApp1.Properties.Resources.wow;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ImagenGrande.Image = WindowsFormsApp1.Properties.Resources.gow;
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            ImagenGrande.Image = WindowsFormsApp1.Properties.Resources.gow;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            ImagenGrande.Image = WindowsFormsApp1.Properties.Resources.gears_of_war;
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            ImagenGrande.Image = WindowsFormsApp1.Properties.Resources.gears_of_war;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            ImagenGrande.Image = WindowsFormsApp1.Properties.Resources.nfscode;
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            ImagenGrande.Image = WindowsFormsApp1.Properties.Resources.nfscode;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            ImagenGrande.Image = WindowsFormsApp1.Properties.Resources.untilsawn;
        }

        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {
            ImagenGrande.Image = WindowsFormsApp1.Properties.Resources.untilsawn;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
