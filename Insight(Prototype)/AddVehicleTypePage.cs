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
        string VehicleType = "";
        public AddVehicleTypePage()
        {
            InitializeComponent();
        }

        private void AVTCancelBtn_Click(object sender, EventArgs e)
        {
            Form Home = new HomeScreen();
            Home.Show();
            this.Show();
        }

        private void AVTNextBtn_Click(object sender, EventArgs e)
        {
            VehicleType = AVTypeTb.Text;
            if (VehicleType == "")
            {
                MessageBox.Show("Please enter a valid Vehicle Type.");
            }
            else
            {
                AVTConfirmLbl.Text = VehicleType;
                AddVehicleTypeTab.SelectedIndex = 1;
            }
        }

        private void AVTBackBtn_Click(object sender, EventArgs e)
        {
            AddVehicleTypeTab.SelectedIndex = 0;
            AVTypeTb.Focus();
            AVTypeTb.Clear();
        }

        private void AVTConfirmBtn_Click(object sender, EventArgs e)
        {
            VehicleType InsightVehicleType = new VehicleType();

            InsightVehicleType.VehicleTypeDescription = VehicleType;

            using (InsightEntities db = new InsightEntities())
            {
                db.VehicleTypes.Add(InsightVehicleType);
                db.SaveChanges();
                AddVehicleTypeTab.SelectedIndex = 2;
            }
        }
    }
}
