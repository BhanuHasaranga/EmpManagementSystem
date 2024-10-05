using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpManagementSystem
{
    public partial class Attendance : Form
    {
        public Attendance()
        {
            InitializeComponent();
        }

        private void EmpPassTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hasar\OneDrive\Documents\MyEmployeeDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void button3_Click(object sender, EventArgs e)
        {
            if (EmpIdTb.Text == "" || EmpPassTb.Text == "")
            {
                MessageBox.Show("Enter User Name And Password");
            }
            else
            {
                Con.Open();
                string query = "select emppass from EmpTbl where EmpId='" + EmpIdTb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    string empPass = reader.GetString(0);
                    if (empPass == EmpPassTb.Text)
                    {
                        Con.Close();
                        DateTime currentTime = DateTime.Now;
                        DateTime currentDate = DateTime.Today;
                        Con.Open();
                        string query1 = "select * from AttTable where EmpId='" + EmpIdTb.Text + "'AND date='" + currentDate.ToString() + "'";
                        SqlCommand cmd1 = new SqlCommand(query1, Con);
                        SqlDataReader reader1 = cmd1.ExecuteReader();
                        if (reader1.HasRows)
                        {
                            reader1.Read();
                            string outTm = reader1["OutTime"].ToString();
                            if (outTm == "")
                            {
                                Con.Close();
                                Con.Open();
                                string query2 = "update AttTable set outtime='" + currentTime.ToString() + "' where date='"+ currentDate.ToString() + "';";
                                SqlCommand cmd2 = new SqlCommand(query2, Con);
                                cmd2.ExecuteNonQuery();
                                string query5 = "select eid from WDayTable where eid='" + EmpIdTb.Text + "'";
                                SqlCommand cmd5 = new SqlCommand(query5, Con);
                                SqlDataReader reader5 = cmd5.ExecuteReader();
                                reader5.Read();
                                if (reader1.HasRows)
                                {
                                    Con.Close();
                                    Con.Open();
                                    string query6 = "select eid from WDayTable where eid='" + EmpIdTb.Text + "'";
                                    SqlCommand cmd6 = new SqlCommand(query6, Con);
                                    SqlDataReader reader6 = cmd6.ExecuteReader();
                                    reader6.Read();
                                    string count = reader6["DCount"].ToString();
                                    int newCount = int.Parse(count)+1;
                                    Con.Close();
                                    Con.Open();
                                    string query7 = "update WDayTable set DCount='" + newCount.ToString() + "' where eid='"+ EmpIdTb.Text + "';";
                                    SqlCommand cmd7 = new SqlCommand(query7, Con);
                                    cmd7.ExecuteNonQuery();
                                    Con.Close();
                                }
                                else
                                {
                                    Con.Close();
                                    Con.Open();
                                    string query8 = "insert into WDayTable (eid, DCount) values('" + EmpIdTb.Text + "',1)";
                                    SqlCommand cmd8 = new SqlCommand(query8, Con);
                                    cmd8.ExecuteNonQuery();
                                    Con.Close();
                                }
                                MessageBox.Show("Leaving time was marked");
                            }
                            else
                            {
                                string Day = reader1["Date"].ToString();
                                if (Day == currentDate.ToString())
                                {
                                    Con.Close();
                                    MessageBox.Show("Already marked today attendance");
                                }
                                else
                                {
                                    Con.Close();
                                    Con.Open();
                                    string query3 = "insert into AttTable (EmpId, Date, InTime, OutTime) values('" + EmpIdTb.Text + "','" + currentDate.ToString() + "','" + currentTime.ToString() + "', null)";
                                    SqlCommand cmd3 = new SqlCommand(query3, Con);
                                    cmd3.ExecuteNonQuery();
                                    Con.Close();
                                    MessageBox.Show("Attending time was marked");
                                }
                            }
                        }
                        else
                        {
                            Con.Close();
                            Con.Open();
                            string query4 = "insert into AttTable (EmpId, Date, InTime, OutTime) values('" + EmpIdTb.Text + "','" + currentDate.ToString() + "','" + currentTime.ToString() + "', null)";
                            SqlCommand cmd4 = new SqlCommand(query4, Con);
                            cmd4.ExecuteNonQuery();
                            Con.Close();
                            MessageBox.Show("Attending time was marked");
                        }
                    }
                    else
                    {
                        Con.Close();
                        MessageBox.Show("Wromg User Name Or Password");
                    }
                }
                else
                {
                    Con.Close();
                    MessageBox.Show("Wromg User Name");
                }
            }
        }
    }
}
