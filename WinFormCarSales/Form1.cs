using System.Data;
using System.Data.SqlClient;

namespace WinFormCarSales
{
    public partial class FormCarSales : Form
    {
        public FormCarSales()
        {
            InitializeComponent();
        }

        

        private void label4_Click(object sender, EventArgs e)
        {

        }



        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;
            Initial Catalog=CarSalesDB;Integrated Security=True;");

            conn.Open();

            // Insert into Stud_details values (ID_textBox.Text, Name_textBox.Text..)
            string SqlCmd = "Insert into Car_sales2 values('" + textBoxID.Text + "','" + textBoxMake.Text + "','"
                + textBoxModel.Text + "','" + textBoxCost.Text + "','" + textBoxSales.Text + "')";

            SqlCommand comm1 = new SqlCommand(SqlCmd, conn);

            comm1.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Insert done!");
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            Preview preview = new Preview();
            preview.Show();
        }
    }
}
