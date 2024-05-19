using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            this.stud_detailsTableAdapter.Fill(this.studentDataSet.Stud_details);

        }
    }
}
