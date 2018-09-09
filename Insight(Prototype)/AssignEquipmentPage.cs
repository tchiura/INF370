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
    public partial class AssignEquipmentPage : Form
    {
        int JID = 0;
        int EID;

        ViewEquipmentPage VEP = new ViewEquipmentPage();
        public AssignEquipmentPage()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void AssignEquipmentPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'insightDataSet.Job' table. You can move, or remove it, as needed.
            this.jobTableAdapter.Fill(this.insightDataSet.Job);

        }

        private void fillByStatusPendingToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.jobTableAdapter.FillByStatusPending(this.insightDataSet.Job);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByStatusPendingToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fillByStatusPendingToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.jobTableAdapter.FillByStatusPending(this.insightDataSet.Job);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void JobDGv_SelectionChanged(object sender, EventArgs e)
        {

            int JRI = JobDGv.CurrentCell.RowIndex;

            JID = Convert.ToInt32(JobDGv.Rows[JRI].Cells["JobID"].Value.ToString());
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Console.WriteLine("JobID: " + JID);
            EID = VEP.GetEqID;

            Globals G = new Globals();
            SqlConnection conn = new SqlConnection(G.myConn);
            conn.Open();

            SqlCommand InsertJobEquipment = new SqlCommand("Insert into JobEquipment(EquipmentID,JobID) Values(@EquipmentID,@JobID)", conn);
            InsertJobEquipment.Parameters.AddWithValue("@JobID", JID);
            InsertJobEquipment.Parameters.AddWithValue("@EquipmentID", 1);

            InsertJobEquipment.ExecuteNonQuery();

            conn.Close();

            using (InsightEntities db = new InsightEntities())
            {
                var E = db.Equipments.SingleOrDefault(x => x.EquipmentID == 1);
                E.EquipmentQuantity--;

                db.SaveChanges();
            }

                AssignEqTab.SelectedIndex = 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            AssignEqTab.SelectedIndex = 0;
        }

        private void NextBtn_Click_1(object sender, EventArgs e)
        {
            AssignEqTab.SelectedIndex = 1;
            Console.WriteLine("New Form ID: " + VEP.GetEqID);
        }
    }
}
