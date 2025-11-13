using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic_Cardz_Storefront_App
{
    public partial class checkout : Form
    {
        public checkout()
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

        private void checkout_Load(object sender, EventArgs e)
        {
            items.Items.Add(productspage1.items);
            items.Items.Add(productspage2.items);
            items.Items.Add(productspage3.items);
            items.Items.Add(productspage4.items);

            price.Items.Add(productspage1.price);
            price.Items.Add(productspage2.price);
            price.Items.Add(productspage3.price);
            price.Items.Add(productspage4.price);
        }

        private void checkoutBtn_Click(object sender, EventArgs e)
        {
            string userName = login.userName;

            using (StreamWriter sw = File.AppendText("Checkout.csv"))
            {
                sw.WriteLine("");
                sw.Write(userName + ",");
                foreach (string item in items.Items)
                {
                    sw.Write(item + ",");
                }
                foreach (string item in price.Items)
                {
                    sw.Write(item);
                }
                sw.Close();
            }
        }
    }
}
