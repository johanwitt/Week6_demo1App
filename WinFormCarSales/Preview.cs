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

namespace WinFormCarSales
{
    public partial class Preview : Form
    {
        public Preview()
        {
            InitializeComponent();
        }

        private void Preview_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;
            Initial Catalog=CarSalesDB;Integrated Security=True;");

            string sqlCmd = "select * from Car_sales2";

            // this are codes specific to dataGridview

            SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd, conn);
            DataSet ds = new DataSet();

            conn.Open();
            adapter.Fill(ds);
            conn.Close();

            dataGridViewPrev.DataSource = ds.Tables[0];
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            string make = textBoxMake.Text;
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;
            Initial Catalog=CarSalesDB;Integrated Security=True;");

            string sqlCmd = $"select * from Car_sales2 where Make = '{make}' ";

            // this are codes specific to dataGridview

            SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd, conn);
            DataSet ds = new DataSet();

            conn.Open();
            adapter.Fill(ds);
            conn.Close();

            dataGridViewPrev.DataSource = ds.Tables[0];
        }

        private void buttonProfit_Click(object sender, EventArgs e)
        {
            // connection string object conn
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;
            Initial Catalog=CarSalesDB;Integrated Security=True;");

            // sql command string
            string sqlCmd = $"ALTER TABLE Car_sales2 ADD Profit AS (Sale_price - Cost)";

            // output to DataGridView
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd, conn);
            DataSet ds = new DataSet();

            conn.Open();
            adapter.Fill(ds);
            conn.Close();

            dataGridViewPrev.DataSource = ds.Tables[0];
        }
    }
}
