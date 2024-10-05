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
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hasar\OneDrive\Documents\MyEmployeeDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void fetchempdata()
        {
            if(EmpIdTb.Text == "")
            {
                MessageBox.Show("Enter Employee Id");
            }
            else
            {
                Con.Open();
                string query = "select * from EmpTbl where EmpId='" + EmpIdTb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    //EmpIdTb.Text = dr["Empid"].ToString();
                    EmpNameTb.Text = dr["Empname"].ToString();
                    EmpPosTb.Text = dr["Emppos"].ToString();
                }
                Con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void Salary_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            fetchempdata();
        }

        int Dailybase, total;

        private void button1_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("=====SALARY DOCUMENT=====", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(185));
            e.Graphics.DrawString("Employee ID: " + EmpIdTb.Text, new Font("Century Gothic", 16, FontStyle.Regular), Brushes.Blue, new Point(10, 100));
            e.Graphics.DrawString("Employee Name: " + EmpNameTb.Text, new Font("Century Gothic", 16, FontStyle.Regular), Brushes.Blue, new Point(10, 140));
            e.Graphics.DrawString("Employee Position: " + EmpPosTb.Text, new Font("Century Gothic", 16, FontStyle.Regular), Brushes.Blue, new Point(10, 180));
            e.Graphics.DrawString("Worked Days: " + WorkedTb.Text, new Font("Century Gothic", 16, FontStyle.Regular), Brushes.Blue, new Point(10, 220));
            e.Graphics.DrawString("Daily payment: " + Dailybase, new Font("Century Gothic", 16, FontStyle.Regular), Brushes.Blue, new Point(10, 260));
            e.Graphics.DrawString("Total Salary: " + total, new Font("Century Gothic", 16, FontStyle.Regular), Brushes.Blue, new Point(10, 300));
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(EmpPosTb.Text == "")
            {
                MessageBox.Show("Select An Employee");
            }
            else if(WorkedTb.Text == "" || Convert.ToInt32(WorkedTb.Text) > 28)
            {
                MessageBox.Show("Enter A Valid Number of Days");
            }
            else
            {
                if(EmpPosTb.Text == "Manager")
                {
                    Dailybase = 250;
                }
                else if(EmpPosTb.Text == "Senior Developer"){
                    Dailybase = 230;
                }
                else if(EmpPosTb.Text == "Junior Developer")
                {
                    Dailybase = 200;
                }
                else
                {
                    Dailybase = 150;
                }
                total = Dailybase * Convert.ToInt32(WorkedTb.Text);
                SalarySlip.Text = "Employee Id: "+ EmpIdTb.Text + "\n" + "Employee Name: " + EmpNameTb.Text + "\n" + "Employee Position: " + EmpPosTb.Text + "\n" + "Days Worked: " + WorkedTb.Text + "\n" + "Daily Salary: Rs " + Dailybase + "\n" + "Total Amount: Rs " + total;
            }
        }
    }
}
