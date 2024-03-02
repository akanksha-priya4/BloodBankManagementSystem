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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }
        int move = 0;
        private void Welcome_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 150;
            panel1.Width += 5;
            move += 5;

            if (move==90)
            {
                timer1.Stop();
                this.Hide();
                Login login = new Login();
                login.Show();
            }
                
            
        }
    }
}
