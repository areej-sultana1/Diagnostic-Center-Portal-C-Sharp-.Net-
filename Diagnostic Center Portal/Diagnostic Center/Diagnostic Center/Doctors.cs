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

    public partial class Doctors : Form
    {
        SqlConnection Con = new SqlConnection(@" Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Student\Documents\Diagonsticdb.mdf;Integrated Security=True;Connect Timeout=30");
        public Doctors()
        {
            InitializeComponent();
            populate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Doctors obj = new Doctors();
            obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e) // patients label
        {
            Patients obj = new Patients();
            obj.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Doctors_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e) //tests label
        {
            Tests obj = new Tests();
            obj.Show();
            this.Hide();
        }
        private void populate() //this function is used to show the data in the grid view from database
        {
            Con.Open();
            string Query = "select *from DocTable";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            Doctorslist.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Hide();
        }
        int key = 0;
        private void Doctorslist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DocName.Text = Doctorslist.SelectedRows[0].Cells[1].Value.ToString();
            DocDOB.Text = Doctorslist.SelectedRows[0].Cells[2].Value.ToString();
            DocPhone.Text = Doctorslist.SelectedRows[0].Cells[3].Value.ToString(); //this isnot showing
            DocAdd.Text = Doctorslist.SelectedRows[0].Cells[4].Value.ToString();
            DocDesig.Text = Doctorslist.SelectedRows[0].Cells[5].Value.ToString();
            Docjoin.Text = Doctorslist.SelectedRows[0].Cells[6].Value.ToString();


            if (DocName.Text == " ")
            {
                key = 0;

            }
            else
            {
                key = Convert.ToInt32(Doctorslist.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        private void Reset()
        {
            DocName.Text = "";
            DocPhone.Text = "";
            DocDesig.Text = " ";
            DocAdd.Text = "";

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        

        private void savebutton_Click(object sender, EventArgs e)
        {
            if (DocName.Text == "" || DocDOB.Text == "" || DocDesig.SelectedIndex == -1 || Docjoin.Text == "" || DocAdd.Text == "" || DocPhone.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into DocTable values('" + DocName.Text + "', '" + DocDOB.Value.Date + "','" + DocPhone.Text + "','" + DocAdd.Text + "','" + DocDesig.SelectedItem.ToString() + "','" + Docjoin.Value.Date + "')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctors Added Successfully");
                    Reset();
                    Con.Close();
                    populate();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void editbutton_Click(object sender, EventArgs e)
        {
            if (DocName.Text == "" || DocDOB.Text == "" || DocDesig.SelectedIndex == -1 || Docjoin.Text == "" || DocAdd.Text == "" || DocPhone.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string Query = "update DocTable set DocName = '" + DocName.Text + "',DocPhone= '" + DocPhone.Text + "' ,Designation='" + DocDesig.SelectedItem.ToString() + "', JoinDate ='" + Docjoin.Value.Date + "' , DocDOB ='" + DocDOB.Value.Date + "'where DocId =" + key + ";";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctors Updated Successfully");
                    Reset();
                    Con.Close();
                    populate();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        
    }

        private void reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void delbutton_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select the Doctors to be deleted");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from DocTable where DocId=" + key + ";", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctors Deleted Successfully");
                    Reset();
                    Con.Close();
                    populate();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void Doctorslist_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
