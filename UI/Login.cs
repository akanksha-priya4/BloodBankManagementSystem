using BloodBankManagementSystem.BLL;
using BloodBankManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagementSystem.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        login l = new login(); 
        loginDAL dAL = new loginDAL();

         public static string loggedInUser;
        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            l.username = username.Text;
            l.password = password.Text;

            bool isSuccess = dAL.logincheck(l);

            if (isSuccess == true)
            {
                MessageBox.Show("Login Successful!");
                loggedInUser = l.username;
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Attempt!");
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
