
using BloodBankManagementSystem.BLL;
using BloodBankManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;

namespace BloodBankManagementSystem.UI
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        userBLL u = new userBLL();
        userDAL dal = new userDAL();

        String imageName = "no.jpg";

        

        private void label3_Click_1(object sender, EventArgs e)
        {
            u.full_name = textBox3.Text;
            u.email = textBox4.Text;
            u.password = textBox6.Text;
            u.username = textBox5.Text;
            u.contact = textBox7.Text;
            u.address = textBox8.Text;
            u.added_date = DateTime.Now;
            u.image_name = imageName;

            bool success = dal.Insert(u);

            if (success == true)
            {
                MessageBox.Show("New User Added Successfully.");

                DataTable dt = dal.Select();
                dgvdetails.DataSource = dt;

                Clear();
            }
            else
            {
                MessageBox.Show("Failed To Add New User.");
            }
        }
        public void Clear()
        {
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox2.Text = "";

        }

        private void label5_Click(object sender, EventArgs e)
        {
            u.user_id = int.Parse(textBox2.Text);

            bool success = dal.Delete(u);

            if (success == true)
            {
                MessageBox.Show("User Deleted Successfully.");

                DataTable dt = dal.Select();
                dgvdetails.DataSource = dt;

                Clear();
            }
        }

       

        private void Users_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvdetails.DataSource = dt;
        }

       
        private void label4_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            u.user_id = int.Parse(textBox2.Text);
            u.full_name = textBox3.Text;
            u.email = textBox4.Text;
            u.password = textBox6.Text;
            u.username = textBox5.Text;
            u.contact = textBox7.Text;
            u.address = textBox8.Text;
            u.added_date = DateTime.Now;
            u.image_name = imageName;

            bool success = dal.Update(u);

            if (success == true)
            {
                MessageBox.Show("User Updated Successfully.");

                DataTable dt = dal.Select();
                dgvdetails.DataSource = dt;

                Clear();
            }
            else
            {
                MessageBox.Show("Failed to update user!");
            }
        }

       
        private void Users_Load_1(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String keywords = textBox1.Text;
            if (keywords != null)
            {
                DataTable dt = dal.Search(keywords);
                dgvdetails.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Select();
                dgvdetails.DataSource = dt;
            }
        }

       

       

        private void dgvdetails_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            textBox2.Text = dgvdetails.Rows[RowIndex].Cells[0].Value.ToString();
            textBox5.Text = dgvdetails.Rows[RowIndex].Cells[1].Value.ToString();
            textBox4.Text = dgvdetails.Rows[RowIndex].Cells[2].Value.ToString();
            textBox6.Text = dgvdetails.Rows[RowIndex].Cells[3].Value.ToString();
            textBox3.Text = dgvdetails.Rows[RowIndex].Cells[4].Value.ToString();
            textBox7.Text = dgvdetails.Rows[RowIndex].Cells[5].Value.ToString();
            textBox8.Text = dgvdetails.Rows[RowIndex].Cells[6].Value.ToString();
            imageName = dgvdetails.Rows[RowIndex].Cells[8].Value.ToString();

           
        
        }

        private void pictureBox_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}