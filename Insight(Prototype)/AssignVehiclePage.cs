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
    public partial class AssignVehiclePage : Form
    {
        int jid = 0;
        int vid = 0;
        public AssignVehiclePage()
        {
            InitializeComponent();
        }


        //public string myConn = "Data Source =.; Initial Catalog = Insight; Integrated Security = True";

        SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = Insight; Integrated Security = True");
        private void AssignVehiclePage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'insightDataSet.Job' table. You can move, or remove it, as needed.
            this.jobTableAdapter.Fill(this.insightDataSet.Job);
            // TODO: This line of code loads data into the 'insightDataSet.Vehicle' table. You can move, or remove it, as needed.
            this.vehicleTableAdapter.Fill(this.insightDataSet.Vehicle);

        }

        private void TopBarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            //Insert Query
            //USe My IDs

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //MessageBox.Show("V = " + vid + " J = " + jid);

            conn.Open();

            SqlCommand InsertJobVehicle = new SqlCommand("Insert into JobVehicle(JobID,VehicleID) Values(@JobID,@VehicleID)", conn);
            InsertJobVehicle.Parameters.AddWithValue("@JobID", jid);
            InsertJobVehicle.Parameters.AddWithValue("@VehicleID", vid);


            InsertJobVehicle.ExecuteNonQuery();

            conn.Close();
        }

        private void DGVVehicle_SelectionChanged(object sender, EventArgs e)
        {

            int VRI = DGVVehicle.CurrentCell.RowIndex;
            int VCI = DGVVehicle.CurrentCell.ColumnIndex;
            int JRI = DGVJob.CurrentCell.RowIndex;

            vid = Convert.ToInt32(DGVVehicle.Rows[VRI].Cells["VehicleID"].Value.ToString());
            jid = Convert.ToInt32(DGVJob.Rows[JRI].Cells["JobID"].Value.ToString());
 
        }
    }
}
