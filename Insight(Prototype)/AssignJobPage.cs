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

namespace Insight_Prototype_
{
    public partial class AssignJobPage : Form
    {

        SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = Insight; Integrated Security = True");
        int jid = 0;
        int eid = 0;
        public AssignJobPage()
        {
            InitializeComponent();
        }

        private void TopBarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AssignJobPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'insightDataSet.Job' table. You can move, or remove it, as needed.
            this.jobTableAdapter.Fill(this.insightDataSet.Job);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Move data to confirm Page
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            conn.Open();

            SqlCommand InsertJobEmployee = new SqlCommand("Insert into JobEmployee(JobID,EmployeeID) Values(@JobID,@EmployeeID)", conn);
            InsertJobEmployee.Parameters.AddWithValue("@JobID", jid);
            InsertJobEmployee.Parameters.AddWithValue("@EmployeeID", eid);

            InsertJobEmployee.ExecuteNonQuery();
        }

        private void EmpDGv_SelectionChanged(object sender, EventArgs e)
        {
            int PRI = EmpDGv.CurrentCell.RowIndex;

            eid = Convert.ToInt32(EmpDGv.Rows[PRI].Cells["EmployeeID"].Value.ToString());

            int JRI = JobDGv.CurrentCell.RowIndex;

            jid = Convert.ToInt32(JobDGv.Rows[JRI].Cells["JobID"].Value.ToString());
        }

        private void JobDGv_SelectionChanged(object sender, EventArgs e)
        {
        }
    }
}
