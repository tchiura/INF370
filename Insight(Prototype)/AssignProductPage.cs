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
    public partial class AssignProductPage : Form
    {

        SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = Insight; Integrated Security = True");
        int jid = 0;
        int pid = 0;
        public AssignProductPage()
        {
            InitializeComponent();
        }

        private void TopBarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AssignProductPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'insightDataSet.Job' table. You can move, or remove it, as needed.
            this.jobTableAdapter.Fill(this.insightDataSet.Job);
            // TODO: This line of code loads data into the 'insightDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.insightDataSet.Product);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Move data to confirm Page
        }

        private void JobDGv_SelectionChanged(object sender, EventArgs e)
        {

            //int VRI = DGVVehicle.CurrentCell.RowIndex;
            int JRI = JobDGv.CurrentCell.RowIndex;

            //vid = Convert.ToInt32(DGVVehicle.Rows[VRI].Cells["VehicleID"].Value.ToString());
            jid = Convert.ToInt32(JobDGv.Rows[JRI].Cells["JobID"].Value.ToString());

            //int PRI = ProdDJv.CurrentCell.RowIndex;

            //pid = Convert.ToInt32(ProdDJv.Rows[PRI].Cells["ProductID"].Value.ToString());
        }

        private void ProdDJv_SelectionChanged(object sender, EventArgs e)
        {

            //int VRI = DGVVehicle.CurrentCell.RowIndex;
            //int PRI = ProdDJv.CurrentCell.RowIndex;

            //pid = Convert.ToInt32(ProdDJv.Rows[PRI].Cells["ProductID"].Value.ToString());
            //jid = Convert.ToInt32(DGVJob.Rows[JRI].Cells["JobID"].Value.ToString());
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand InsertJobProduct = new SqlCommand("Insert into JobProduct(JobID,ProductID) Values(@JobID,@ProductID)", conn);
            InsertJobProduct.Parameters.AddWithValue("@JobID", jid);
            InsertJobProduct.Parameters.AddWithValue("@ProductID", pid);

            InsertJobProduct.ExecuteNonQuery();
        }
    }
}
