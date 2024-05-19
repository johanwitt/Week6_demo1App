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

namespace Week6_demo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;
            Initial Catalog=Student;Integrated Security=True;");
            

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();

            // Insert into Stud_details values (ID_textBox.Text, Name_textBox.Text..)
            string SqlCmd = "Insert into Stud_details values('" + ID_textBox.Text + "','" + Name_textBox.Text + "','" + DOB_textBox.Text + "','" + Address_textBox.Text + "','" + Phone_textBox.Text + "')";
            
            SqlCommand cmd = new SqlCommand(SqlCmd, conn);

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Insert done!");
            

        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            conn.Open();

            string SqlCmd = "SELECT * FROM Stud_details";

            SqlCommand cmd = new SqlCommand( SqlCmd, conn);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}, {1}, {2}, {3}, {4}", reader[0], reader[1], reader[2], reader[3], reader[4]));
                }
            }

            MessageBox.Show("Select done!");
        }
    }
}
