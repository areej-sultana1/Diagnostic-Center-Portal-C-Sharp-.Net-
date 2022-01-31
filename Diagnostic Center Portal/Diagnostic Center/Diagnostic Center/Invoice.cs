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
    public partial class Invoice : Form
    {
        SqlConnection Con = new SqlConnection(@" Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Student\Documents\Diagonsticdb.mdf;Integrated Security=True;Connect Timeout=30");
        public Invoice()
        {
            InitializeComponent();
            Getpatid();
            GetDocid();
            GetTestid();
        }
        private void Getpatid()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select PatID from PatTable ", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PatId", typeof(int));
            dt.Load(rdr);
            patientid.ValueMember = "PatId";
            patientid.DataSource = dt;
            Con.Close();
        }
        private void GetDocid()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select DocName from DocTable ", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("DocName", typeof(string));
            dt.Load(rdr);
            refby.ValueMember = "DocName";
            refby.DataSource = dt;
            Con.Close();
        }
        private void GetTestid()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select TesId from TestTbl ", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TesId", typeof(int));
            dt.Load(rdr);
           TestNameID.ValueMember = "TesId";
            TestNameID.DataSource = dt;
            Con.Close();
        }
        private void GetPatData()
        {
            Con.Open();
            string mysql = "Select * from PatTable where PatId=" + patientid.SelectedValue.ToString() + ";";
            SqlCommand cmd = new SqlCommand(mysql, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                patientName.Text = dr["PatName"].ToString();
                Patphone.Text = dr["Phone"].ToString();
            }

            
            Con.Close();
        }
        int cost = 0;
        private void GetTestData()
        {
            Con.Open();
            string mysql = "Select *from TestTbl where TesId=" + TestNameID.SelectedValue.ToString() + ";";
            SqlCommand cmd = new SqlCommand(mysql, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                TestNameBox.Text = dr["TestDes"].ToString();
                cost = Convert.ToInt32(dr["Testcost"].ToString());
                //Patphone.Text = dr["Phone"].ToString();
            }


            Con.Close();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void reset_Click(object sender, EventArgs e)
        {

        }

        private void delbutton_Click(object sender, EventArgs e) //this is for print button
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void editbutton_Click(object sender, EventArgs e)
        {

        }
        private void reset()
        {
            patientName.Text = "";
            Patphone.Text = " ";
            totalcost.Text = "Total";
            grandtotal = 0;

        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            if (patientid.SelectedIndex == -1 || refby.SelectedIndex == -1 ||  totalcost.Text == "Total")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into InvoiceTable values(" + patientid.SelectedIndex.ToString() + ",'" + PatName.Text + "', '" + Patphone.Text + "','" + delidate.Value.Date + "','" + refby.SelectedIndex.ToString() + "','"+totalcost.Text+"')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Invoice Saved Successfully");
                   reset();
                    Con.Close();
                    //populate();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Doctorslist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void patientid_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetPatData();
        }

        private void TestNameID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetTestData();
        }
        int n = 0, grandtotal = 0;

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
        string TestName;
        int Testid, a = 60;
        int testcost;

        private void label1_Click(object sender, EventArgs e)
        {
            Doctors obj = new Doctors();
            obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Patients obj = new Patients();
            obj.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Tests obj = new Tests();
            obj.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
           Dashboard obj = new Dashboard();
            obj.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Diagnostic Center", new Font("Century Goth", 12, FontStyle.Bold), Brushes.Red , new Point(80));
            e.Graphics.DrawString("ID  Test             Cost", new Font("Century Goth", 10, FontStyle.Bold), Brushes.Red, new Point(75,40));
            foreach (DataGridViewRow row in Totallist.Rows)
            {
                Testid = Convert.ToInt32(row.Cells["Column1"].Value);
                TestName = " " + row.Cells["Column2"].Value;
                    testcost = Convert.ToInt32(row.Cells["Column3"].Value);

                e.Graphics.DrawString(" "+Testid, new Font("Century Goth", 8, FontStyle.Bold), Brushes.Blue, new Point(75,a));
                e.Graphics.DrawString(" " + TestName, new Font("Century Goth", 8, FontStyle.Bold), Brushes.Blue, new Point(95,a));
                e.Graphics.DrawString(" " + testcost, new Font("Century Goth", 8, FontStyle.Bold), Brushes.Blue, new Point(190,a));
                a = a + 20; //this shows position
            }
            e.Graphics.DrawString(" Grand Total :Rs "+ grandtotal, new Font("Century Goth", 12, FontStyle.Bold), Brushes.Crimson, new Point(50, a+50));
            e.Graphics.DrawString("*********DIAGONOSTIC CENTER ********", new Font("Century Goth", 10, FontStyle.Bold), Brushes.Crimson, new Point(11, a+85));
            Totallist.Rows.Clear();
            Totallist.Refresh();
           a= 100;
            grandtotal = 0;




        }

        private void Addtest_Click(object sender, EventArgs e)
        {
            
            if(TestNameBox.Text == "")
            {
                MessageBox.Show("Select the test");
            }
            else
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(Totallist);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value= TestNameBox.Text;
                newRow.Cells[2].Value = cost;
                Totallist.Rows.Add(newRow);
                n++;
                grandtotal = grandtotal + cost;
                totalcost.Text = "Rs" + grandtotal;

            }
        }
    }
}
