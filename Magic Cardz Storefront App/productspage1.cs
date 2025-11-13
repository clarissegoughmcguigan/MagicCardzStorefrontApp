using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Magic_Cardz_Storefront_App
{
    public partial class productspage1 : Form
    {
        public productspage1()
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

        private void productspage1_Load(object sender, EventArgs e)
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

        private void panel10_Click(object sender, EventArgs e)
        {
            items = "Scarlet and Violet Journey Together Booster Box (36 packs)";
            price = "154.44";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            items = "Scarlet and Violet Journey Together Booster Box (36 packs)";
            price = "154.44";
        }

        private void boosterPack_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void boosterPack_Click(object sender, EventArgs e)
        {
            items = "Scarlet and Violet Journey Together Booster Pack";
            price = "4.29";
        }

        private void Booster_Click(object sender, EventArgs e)
        {
            items = "Scarlet and Violet Journey Together Booster Pack";
            price = "4.29";
        }

        private void product3_Click(object sender, EventArgs e)
        {
            items = "Scarlet and Violet Journey Together 3 Pack Blister Yanmega";
            price = "13.99";
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void product4_Click(object sender, EventArgs e)
        {
            items = "Scarlet and Violet Surging Sparks Booster Box (36 packs)";
            price = "183.95";
        }

        private void product5_Click(object sender, EventArgs e)
        {
            items = "Scarlet and Violet Surging Sparks Booster Box (6 packs)";
            price = "23";
        }

        private void product6_Click(object sender, EventArgs e)
        {
            items = "Scarlet and Violet Surging Sparks Booster Pack";
            price = "4.50";
        }
    }
}
