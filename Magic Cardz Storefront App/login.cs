using System;
using System.Collections;
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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        public Point mouseLocation;

        Dictionary<String, String> usernameANDpassword = new Dictionary<String, String>();

        public static string userName = "";

        public void getUsers()
        {
                string filepath = "Accounts.csv";
                StreamReader sr = File.OpenText(filepath);

            sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();

                    string[] csvfields = line.Split(',');
                    string fullname = csvfields[0];
                    string username = csvfields[1];
                    string email = csvfields[2];
                    string password = csvfields[3];

                if (username != "" && password != "")
                {
                    usernameANDpassword.Add(username, password);
                    username = "";
                    password = "";
                }
            }
                sr.Close();
        }

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
            signup f2 = new signup();
            f2.Closed += (s, args) => this.Close();
            f2.Show();
            this.Hide();
        }

        private void loginBtn_MouseClick(object sender, MouseEventArgs e)
        {
            string user = usernametxt.Text;
            string pass = usernametxt.Text;
            bool userExist = false;

            if (user.Trim().Equals("") || pass.Trim().Equals(""))
            {
                MessageBox.Show("You need to enter username and password");
            }
            else
            {
                foreach (var uname in usernameANDpassword)
                {
                    if (uname.Key.ToString().Trim().Equals(user))
                    {
                        if (uname.Value.Trim().Equals(pass))
                        {
                            userExist = true;
                            break;
                        }
                    }
                }
                if (userExist)
                {
                    userName = usernametxt.Text;
                    
                    homepage f3 = new homepage();
                    f3.Closed += (s, args) => this.Close();
                    f3.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or Password not correct. Please try again");
                }
            }
        }

        private void login_Load(object sender, EventArgs e)
        {
            getUsers();
        }
    }
}
