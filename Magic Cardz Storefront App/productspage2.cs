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
    public partial class productspage2 : Form
    {
        public productspage2()
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

        private void productspage2_Load(object sender, EventArgs e)
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

        private void yugiohboosterbox_Click(object sender, EventArgs e)
        {
            items = "Quarter Century Stampede Booster Box";
            price = "94.95";
        }

        private void product2_Click(object sender, EventArgs e)
        {
            items = "Quarter Century Stampede Booster Pack";
            price = "4.65";
        }

        private void product3_Click(object sender, EventArgs e)
        {
            items = "Alliance Insight Booster Box";
            price = "59.95";
        }

        private void product4_Click(object sender, EventArgs e)
        {
            items = "Structure Deck: Blue Eyes White Destiny";
            price = "9.49";
        }

        private void product5_Click(object sender, EventArgs e)
        {
            items = "25th Anniversary Tin: Dueling Mirrors";
            price = "£15.95";
        }

        private void product6_Click(object sender, EventArgs e)
        {
            items = "XYZ Symphony Starter Deck";
            price = "24.95";
        }
    }
}
