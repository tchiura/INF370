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
    public partial class AddVehiclePage : Form
    {

        string Reg = "";
        string Make = "";
        string Model = "";
        string Type = "";
        string Year = "";
        string PDate = "";

        public AddVehiclePage()
        {
            InitializeComponent();
        }

        private void AVCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AVNextBtn_Click(object sender, EventArgs e)
        {
            Reg = VRegTb.Text;
            Make = VMakeTb.Text;
            Model = VModelTb.Text;
            Type = VTypCmb.Text;
            Year = VYearTb.Text;
            PDate = VPDateDT.Text;

            CVRegLbl.Text = Reg;
            CVMakeLbl.Text = Make;
            CVModelLbl.Text = Model;
            CVTypeLbl.Text = Type;
            CVYearLbl.Text = Year;
            CVPDateLbl.Text = PDate;
            AddVehicleTab.SelectedIndex = 1;

        }

        private void AVConfirmBtn_Click(object sender, EventArgs e)
        {
            //VehicleType vehicleType = new VehicleType();
            Vehicle InsightVehicle = new Vehicle();
            InsightVehicle.VehicleRegistration = Reg;
            InsightVehicle.VehicleMake = Make;
            InsightVehicle.VehicleModel = Model;
            //InsightVehicle.VehicleYear = Convert.ToDateTime(Year);
            InsightVehicle.VehicleStatusID = 1;
            InsightVehicle.VehicleYear = DateTime.Now;
            InsightVehicle.PurchaseDate = Convert.ToDateTime(PDate);

            using (InsightEntities db = new InsightEntities())
            {
                InsightVehicle.VehicleType = db.VehicleTypes.SingleOrDefault(x => x.VehicleTypeDescription == Type);
                db.Vehicles.Add(InsightVehicle);
                db.SaveChanges();
                AddVehicleTab.SelectedIndex = 2;
            }
        }

        private void AVBackBtn_Click(object sender, EventArgs e)
        {
            AddVehicleTab.SelectedIndex = 0;
        }

        private void AddVehiclePage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'insightDataSet.VehicleType' table. You can move, or remove it, as needed.
            this.vehicleTypeTableAdapter.Fill(this.insightDataSet.VehicleType);

        }
    }
}
