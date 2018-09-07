using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Insight_Prototype_
{
    public partial class UpdateVehicleStatusPage : Form
    {
        public UpdateVehicleStatusPage()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VStatusLbl.Visible = false;
            VStatusCmb.Visible = true;
        }

        private void UVSCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UVSNextBtn_Click(object sender, EventArgs e)
        {
            CVStatusLbl.Text = VStatusCmb.Text;
            UpdateVehicleStatusTab.SelectedIndex = 1;
        }

        private void UpdateVehicleStatusPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'insightDataSet.VehicleStatus' table. You can move, or remove it, as needed.
            this.vehicleStatusTableAdapter.Fill(this.insightDataSet.VehicleStatus);
            // TODO: This line of code loads data into the 'insightDataSet.Vehicle' table. You can move, or remove it, as needed.
            this.vehicleTableAdapter.Fill(this.insightDataSet.Vehicle);

        }

        private void UVSBackBtn_Click(object sender, EventArgs e)
        {
            UpdateVehicleStatusTab.SelectedIndex = 0;
        }

        private void UVSConfirmBtn_Click(object sender, EventArgs e)
        {


            Vehicle InsightVehicle = new Vehicle();
            InsightVehicle.VehicleStatusID = VStatusCmb.SelectedIndex + 1;

            using (InsightEntities db = new InsightEntities())
            {
                var curVehicle = db.Vehicles.SingleOrDefault(x => x.VehicleID == 3);
                curVehicle.VehicleStatusID = InsightVehicle.VehicleStatusID;
                db.SaveChanges();
            }
            UpdateVehicleStatusTab.SelectedIndex = 2;
        }
    }
}
