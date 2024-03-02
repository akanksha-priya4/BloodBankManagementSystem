using BloodBankManagementSystem.DAL;
using BloodBankManagementSystem.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BloodBankManagementSystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        donorDAL dal=new donorDAL();

       

        private void Home_Load(object sender, EventArgs e)
        {
            allDonorCount();

            DataTable dt = dal.Select();
            dgvDonors.DataSource = dt;
            label5.Text = Login.loggedInUser;
            label5.Text = Register.registereduser;
        }
        public void allDonorCount()
        {
            label2.Text = dal.countDonors("O+");
            label26.Text = dal.countDonors("O-");
            label20.Text = dal.countDonors("A+");
            label23.Text = dal.countDonors("A-");
            label41.Text = dal.countDonors("B+");
            label35.Text = dal.countDonors("B-");
            label38.Text = dal.countDonors("AB+");
            label32.Text = dal.countDonors("AB-");
        }


    

        private void pictureBox_Click(object sender, EventArgs e)
        {
            //Code to close this application;
            this.Hide();
        }

        private void Users_Click(object sender, EventArgs e)
        {
            //open users form
            Users users = new Users();
            users.Show();
        }

        private void Donor_Click(object sender, EventArgs e)
        {
            //open donor form
            Donor donors = new Donor();
            donors.Show();
        }

        private void login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void Home_Activated(object sender, EventArgs e)
        {
            allDonorCount();
        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            
            string keywords = searchtxt.Text;
            if (keywords != null)
            {
                DataTable dt = dal.Search(keywords);
                dgvDonors.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Select();
                dgvDonors.DataSource = dt;
            }
        }
    } 
}
