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
    public partial class productspage4 : Form
    {
        public productspage4()
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {

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

        private void productspage4_Load(object sender, EventArgs e)
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
            items = "Disney Lorcana: Shimmering Skies Booster Box";
            price = "99.95";
        }

        private void product2_Click(object sender, EventArgs e)
        {
            items = "Disney Lorcana: The First Chapter Booster Box";
            price = "184.95";
        }

        private void product3_Click(object sender, EventArgs e)
        {
            items = "Disney Lorcana: Ursula's Return Booster Box";
            price = "94.95";
        }

        private void product4_Click(object sender, EventArgs e)
        {
            items = "Disney Lorcana: The First Chapter Booster Pack";
            price = "7.99";
        }

        private void product5_Click(object sender, EventArgs e)
        {
            items = "Disney Lorcana: Shimmering Skies Booster Pack";
            price = "7.99";
        }

        private void product6_Click(object sender, EventArgs e)
        {
            items = "Disney Lorcana: Ursula's Return Booster Pack";
            price = "4.25";
        }
    }
}
