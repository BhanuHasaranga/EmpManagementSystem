using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EmpManagementSystem
{
    public partial class ViewEmployee : Form
    {
        public ViewEmployee()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hasar\OneDrive\Documents\MyEmployeeDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void fetchempdata()
        {
            Con.Open();
            string query = "select * from EmpTbl where EmpId='" + empidTb.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                Empidlbl.Text = dr["Empid"].ToString();
                empnamelbl.Text = dr["Empname"].ToString();
                empaddlbl.Text = dr["Empadd"].ToString();
                empposlbl.Text = dr["Emppos"].ToString();
                empphonelbl.Text = dr["Empphone"].ToString();
                empedulbl.Text = dr["Empedu"].ToString();
                empgenlbl.Text = dr["Empgen"].ToString();
                empdoblbl.Text = dr["Empdob"].ToString();

                Empidlbl.Visible = true;
                empnamelbl.Visible = true;
                empaddlbl.Visible = true;
                empposlbl.Visible = true;
                empphonelbl.Visible = true;
                empedulbl.Visible = true;
                empgenlbl.Visible = true;
                empdoblbl.Visible = true;
            }
            Con.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void ViewEmployee_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            fetchempdata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("=====EMPOLYEE SUMMARY=====", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(185));
            e.Graphics.DrawString("Employee ID: "+Empidlbl.Text+"\tEmployee Name: "+empnamelbl.Text, new Font("Century Gothic", 16, FontStyle.Regular), Brushes.Blue, new Point(10,100));
            e.Graphics.DrawString("Employee Address: " + empaddlbl.Text + "\tEmployee Gender: " + empgenlbl.Text, new Font("Century Gothic", 16, FontStyle.Regular), Brushes.Blue, new Point(10, 140));
            e.Graphics.DrawString("Employee Position: " + empposlbl.Text + "\tEmployee DOB: " + empdoblbl.Text, new Font("Century Gothic", 16, FontStyle.Regular), Brushes.Blue, new Point(10, 180));
            e.Graphics.DrawString("Employee Phone: " + empphonelbl.Text + "\tEmployee Education: " + empedulbl.Text, new Font("Century Gothic", 16, FontStyle.Regular), Brushes.Blue, new Point(10, 220));
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
