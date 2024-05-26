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
            

        private void button1_Click(object sender, EventArgs e) // submit button
        {
            string Id = ID_textBox.Text;
            string name = Name_textBox.Text;
            string Dob = DOB_textBox.Text;
            string address = Address_textBox.Text;
            string phone = Phone_textBox.Text;

            conn.Open();

            // Insert into Stud_details values (ID_textBox.Text, Name_textBox.Text..)
            //string SqlCmd = "Insert into Stud_details values('" + ID_textBox.Text + "','" + Name_textBox.Text + "','"
            //    + DOB_textBox.Text + "','" + Address_textBox.Text + "','" + Phone_textBox.Text + "')";

            string SqlCmd = $"Insert into Stud_details values (@Id, @name, @Dob, @address, @phone)";

            SqlCommand cmd = new SqlCommand(SqlCmd, conn);

            // cmd parameter block

            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue ("@name", name);
            cmd.Parameters.AddWithValue("@Dob", Dob);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@phone", phone);

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Insert done!");
            

        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            
            // access new form ReportTabl
            ReportTabl reportTabl = new ReportTabl();
            reportTabl.Show();
            
            
            
            
        }
    }
}
