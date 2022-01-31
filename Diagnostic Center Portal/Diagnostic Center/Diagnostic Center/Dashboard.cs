using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Diagnostic_Center
{
    public partial class Dashboard : Form
    {
        SqlConnection Con = new SqlConnection(@" Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Student\Documents\Diagonsticdb.mdf;Integrated Security=True;Connect Timeout=30");
        public Dashboard()
        {
            InitializeComponent();
            getdoctors();
            getpatients();
            getcost();
            
        }
        private void getdoctors()
        {
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) As Count FROM DocTable", Con))
            {
                cmd.CommandType = CommandType.Text;
                Con.Open();
                object o = cmd.ExecuteScalar();
                if (o != null)
                {
                    Doctosnum.Text =  o.ToString();
                }
                Con.Close();
            }


        }
        private void getpatients()
        {
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) As Count FROM PatTable", Con))
            {
                cmd.CommandType = CommandType.Text;
                Con.Open();
                object o = cmd.ExecuteScalar();
                if (o != null)
                {
                    patientsnum.Text = o.ToString();
                }
                Con.Close();
            }


        }
        private void getcost()
        {
            SqlCommand cmd = new SqlCommand("SELECT SUM(Testcost) As Count FROM TestTbl", Con);
            
                cmd.CommandType = CommandType.Text;
                Con.Open();
                object o = cmd.ExecuteScalar();
                if (o != null)
                {
                    Totalnum.Text = o.ToString();
                }
                Con.Close();
            


        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Patients obj = new Patients();
            obj.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Doctors obj = new Doctors();
            obj.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Tests obj = new Tests();
            obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Invoice obj = new Invoice();
            obj.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }
    }
}
