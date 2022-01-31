using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diagnostic_Center
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //login button
        {
           if( Uname.Text ==" "  || password.Text ==" ")
            {
                MessageBox.Show("Enter Username and Password");
            }
            else
            {
                if(Uname.Text == "admin" || password.Text == "admin")
                {
                    Patients obj = new Patients();
                    obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username and Password");
                    Uname.Text = "";
                    password.Text = "";

                }
            }
        }

        private void label5_Click(object sender, EventArgs e) //resett button means to remove the written
        {
            Uname.Text = "";
            password.Text = "";
        
        }
    }
}
