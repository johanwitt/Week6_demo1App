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
    public partial class ReportTabl : Form
    {
        public ReportTabl()
        {
            InitializeComponent();
        }

        private void ReportTabl_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet.Stud_details' table. You can move, or remove it, as needed.
            //this.stud_detailsTableAdapter.Fill(this.studentDataSet.Stud_details);

            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;
            Initial Catalog=Student;Integrated Security=True;");

            string sqlCmd = "select * from Stud_details";

            // this are codes specific to dataGridview

            SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd, conn);
            DataSet ds = new DataSet();

            conn.Open();
            adapter.Fill(ds);
            conn.Close();

            dataGridView1.DataSource= ds.Tables[0];
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;
            Initial Catalog=Student;Integrated Security=True;");

            string Fname = textBoxName.Text;
            string sqlCmd = $"select * from Stud_details where Full_name = '{Fname}'";

            // this are codes specific to dataGridview

            SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd, conn);
            DataSet ds1 = new DataSet();

            conn.Open();
            adapter.Fill(ds1);
            conn.Close();

            dataGridView1.DataSource = ds1.Tables[0];
        }
    }
}
