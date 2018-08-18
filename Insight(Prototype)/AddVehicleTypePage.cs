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
    public partial class AddVehicleTypePage : Form
    {
        public AddVehicleTypePage()
        {
            InitializeComponent();
        }

        string VehicleDescr = "";

        private void VTNextBtn_Click(object sender, EventArgs e)
        {
            VehicleDescr = VehicleTypeTb.Text;
            if(VehicleDescr == "")
            {
                MessageBox.Show("Please Enter a Vehicle Type");
            }
            else
            {
                VTConfirmLbl.Text = VehicleDescr;
                AddVehicleTypeTC.SelectedTab = AddVehicleTypeTC.TabPages[1];
            }
        }

        private void VTCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClosePicBx_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VTBackBtn_Click(object sender, EventArgs e)
        {
            AddVehicleTypeTC.SelectedTab = AddVehicleTypeTC.TabPages[0];
        }

        private void VTConfirmBtn_Click(object sender, EventArgs e)
        {
            VehicleType InsightVehicleType = new VehicleType();
            InsightVehicleType.VehicleTypeDescription = VehicleDescr;

            using (InsightEntities db = new InsightEntities())
            {
                db.VehicleTypes.Add(InsightVehicleType);
                db.SaveChanges();
            }

            AddVehicleTypeTC.SelectedTab = AddVehicleTypeTC.TabPages[2];
        }
    }
}
