using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic_Cardz_Storefront_App
{
    public partial class homepage : Form
    {
        public homepage()
        {
            InitializeComponent();
        }

        public Point mouseLocation;

        private void Exit_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void Minimise_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void accountName_Click(object sender, EventArgs e)
        {

        }

        private void homepage_Load(object sender, EventArgs e)
        {
            accountName.Text = login.userName;
        }

        private void Account_Click(object sender, EventArgs e)
        {
            account f4 = new account();
            f4.Closed += (s, args) => this.Close();
            f4.Show();
            this.Hide();
        }

        private void Basket_Click(object sender, EventArgs e)
        {
            checkout f5 = new checkout();
            f5.Closed += (s, args) => this.Close();
            f5.Show();
            this.Hide();
        }

        private void pokemon_Click(object sender, EventArgs e)
        {
            productspage1 f6 = new productspage1();
            f6.Closed += (s, args) => this.Close();
            f6.Show();
            this.Hide();
        }

        private void pokemonPic_Click(object sender, EventArgs e)
        {
            productspage1 f6 = new productspage1();
            f6.Closed += (s, args) => this.Close();
            f6.Show();
            this.Hide();
        }

        private void mtg_Click(object sender, EventArgs e)
        {
            productspage3 f8 = new productspage3();
            f8.Closed += (s, args) => this.Close();
            f8.Show();
            this.Hide();
        }

        private void mtgPic_Click(object sender, EventArgs e)
        {
            productspage3 f8 = new productspage3();
            f8.Closed += (s, args) => this.Close();
            f8.Show();
            this.Hide();
        }

        private void yugioh_Click(object sender, EventArgs e)
        {
            productspage2 f7 = new productspage2();
            f7.Closed += (s, args) => this.Close();
            f7.Show();
            this.Hide();
        }

        private void yugiohPic_Click(object sender, EventArgs e)
        {
            productspage2 f7 = new productspage2();
            f7.Closed += (s, args) => this.Close();
            f7.Show();
            this.Hide();
        }

        private void lorcana_Click(object sender, EventArgs e)
        {
            productspage4 f9 = new productspage4();
            f9.Closed += (s, args) => this.Close();
            f9.Show();
            this.Hide();
        }

        private void lorcanaPic_Click(object sender, EventArgs e)
        {
            productspage4 f9 = new productspage4();
            f9.Closed += (s, args) => this.Close();
            f9.Show();
            this.Hide();
        }
    }
}
