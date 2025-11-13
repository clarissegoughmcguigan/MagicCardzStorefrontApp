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
    public partial class productspage3 : Form
    {
        public productspage3()
        {
            InitializeComponent();
        }

        public Point mouseLocation;

        public static string items = "";

        public static string price = "";

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimise_Click(object sender, EventArgs e)
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

        private void account_Click(object sender, EventArgs e)
        {
            account f4 = new account();
            f4.Closed += (s, args) => this.Close();
            f4.Show();
            this.Hide();
        }

        private void basket_Click(object sender, EventArgs e)
        {
            checkout f5 = new checkout();
            f5.Closed += (s, args) => this.Close();
            f5.Show();
            this.Hide();
        }

        private void productspage3_Load(object sender, EventArgs e)
        {
            accountName.Text = login.userName;
        }

        private void back_Click(object sender, EventArgs e)
        {
            homepage f3 = new homepage();
            f3.Closed += (s, args) => this.Close();
            f3.Show();
            this.Hide();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            homepage f3 = new homepage();
            f3.Closed += (s, args) => this.Close();
            f3.Show();
            this.Hide();
        }

        private void product1_Click(object sender, EventArgs e)
        {
            items = "Tarkir: Dragonstorm Play Booster Box";
            price = "134.95";
        }

        private void product2_Click(object sender, EventArgs e)
        {
            items = "Tarkir: Dragonstorm Collector Booster Box";
            price = "299.95";
        }

        private void product3_Click(object sender, EventArgs e)
        {
            items = "Tarkir: Dragonstorm Bundle";
            price = "52.95";
        }

        private void product4_Click(object sender, EventArgs e)
        {
            items = "Tarkir: Dragonstorm Play Booster Pack";
            price = "4.45";
        }

        private void product5_Click(object sender, EventArgs e)
        {
            items = "Tarkir: Dragonstorm Commander Deck - Jeskai Striker";
            price = "39.95";
        }

        private void product6_Click(object sender, EventArgs e)
        {
            items = "Tarkir: Dragonstorm Commander Deck - Sultai Arisen";
            price = "84.95";
        }
    }
}
