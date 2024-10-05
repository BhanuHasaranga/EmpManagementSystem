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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hasar\OneDrive\Documents\MyEmployeeDB.mdf;Integrated Security=True;Connect Timeout=30"); 
        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (EmpIdTb.Text == "" || EmpNameTb.Text == "" || EmpPhoneTb.Text == "" || EmpAddTb.Text == "" || EmpPassTb.Text == "")
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into Emptbl values('"+EmpIdTb.Text+"','"+ EmpNameTb.Text+"','"+ EmpAddTb.Text+"','"+EmpPosCb.SelectedItem.ToString()+"','"+EmpDob.Value.Date+ "','" + EmpPhoneTb.Text + "','"+EmpEduCb.SelectedItem.ToString()+"','"+EmpGenCb.SelectedItem.ToString()+ "','" + EmpPassTb.Text+"')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Successfully Added");
                    Con.Close();
                    populate();

                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
private void populate()
        {
            Con.Open();
            string query = "select * from Emptbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EmpDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Employee_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(EmpIdTb.Text == "")
            {
                MessageBox.Show("Enter The Employee Id");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query2 = "delete from WDayTable where eid='" + EmpIdTb.Text + "';";
                    SqlCommand cmd2 = new SqlCommand(query2, Con);
                    cmd2.ExecuteNonQuery();
                    string query1 = "delete from AttTable where Empid='" + EmpIdTb.Text + "';";
                    SqlCommand cmd1 = new SqlCommand(query1, Con);
                    cmd1.ExecuteNonQuery();
                    string query = "delete from Emptbl where Empid='" + EmpIdTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Empolyee Deleted Successfully");
                    Con.Close();
                    populate();
                }catch(Exception ex )
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void EmpDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpIdTb.Text = EmpDGV.SelectedRows[0].Cells[0].Value.ToString();
            EmpNameTb.Text = EmpDGV.SelectedRows[0].Cells[1].Value.ToString();
            EmpAddTb.Text = EmpDGV.SelectedRows[0].Cells[2].Value.ToString();
            EmpEduCb.Text = EmpDGV.SelectedRows[0].Cells[6].Value.ToString();
            EmpPosCb.Text = EmpDGV.SelectedRows[0].Cells[3].Value.ToString();
            EmpPhoneTb.Text = EmpDGV.SelectedRows[0].Cells[5].Value.ToString();
            EmpGenCb.Text = EmpDGV.SelectedRows[0].Cells[7].Value.ToString();
            EmpPassTb.Text = EmpDGV.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (EmpIdTb.Text == "" || EmpNameTb.Text == "" || EmpPhoneTb.Text == "" || EmpAddTb.Text == "" || EmpPassTb.Text == "")
            {
                MessageBox.Show("Misssing Informations");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update Emptbl set Empname='" + EmpNameTb.Text + "',empadd='" + EmpAddTb.Text + "',emppos='"+EmpPosCb.SelectedItem.ToString()+"',empdob='"+EmpDob.Value.Date+"',empphone='"+EmpPhoneTb.Text+"',empedu='"+EmpEduCb.SelectedItem.ToString()+"',empgen='"+EmpGenCb.SelectedItem.ToString()+"',emppass='"+EmpPassTb.Text+"' where Empid='"+EmpIdTb.Text+"';";
                    SqlCommand cmd = new SqlCommand(query,Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Updated Successfully");
                    Con.Close();
                    populate();
                }catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void EmpAddTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void EmpPhoneTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmpEduCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void EmpIdTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
