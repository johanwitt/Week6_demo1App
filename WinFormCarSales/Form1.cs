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

        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;
            Initial Catalog=CarSalesDB;Integrated Security=True;");

        private void label4_Click(object sender, EventArgs e)
        {

        }
        
        

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            conn.Open();

            // Insert into Stud_details values (ID_textBox.Text, Name_textBox.Text..)
            string SqlCmd = "Insert into Stud_details values('" + textBoxID.Text + "','" + textBoxModel.Text + "','"
                + textBoxMake.Text + "','" + textBoxCost.Text + "','" + textBoxSales.Text + "')";

            SqlCommand comm = new SqlCommand(SqlCmd, conn);

            comm.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Insert done!");
        }
    }
}
