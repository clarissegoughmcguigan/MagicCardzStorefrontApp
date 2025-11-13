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
    public partial class signup : Form
    {
        public signup()
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

        private void registerBtn_MouseClick(object sender, MouseEventArgs e)
        {
            string fullname = fullNametxt.Text;
            string username = usertxt.Text;
            string email = emailtxt.Text;
            string password = passtxt.Text;
            string phone = numtxt.Text;
            string address = addresstxt.Text;
            string city = ctTxt.Text;
            string postie = postietxt.Text;

            using (StreamWriter sw = File.AppendText("Accounts.csv"))
            {
                sw.Write(fullname + "," + username + "," + email + "," + password + "," + phone + "," + address + "," + city + "," + postie + ",");
                if (emailChecker.Checked)
                {
                    sw.Write("Yes");
                }
                else
                {
                    sw.Write("No");
                }
                    sw.Close();
            }
            login f1 = new login();
            f1.Closed += (s, args) => this.Close();
            f1.Show();
            this.Hide();
        }
    }
}
