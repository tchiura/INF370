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
    public partial class UpdateVehiclePage : Form
    {
        int VID = 0;
        string Reg = "";
        string Make = "";
        string Model = "";
        int Year = 0000;
        string Type = "";
        DateTime PDate;
        public UpdateVehiclePage()
        {
            InitializeComponent();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            Make = MakeTb.Text;
            Model = ModelTb.Text;
            Year = Convert.ToInt32(YearTb);
            Type = TypeTb.Text;
            PDate = PDateDP.Value;
            Reg = RegTB.Text;

            UpdateVehicleTab.SelectedIndex = 1;

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {

            UpdateVehicleTab.SelectedIndex = 0;
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            using (InsightEntities db = new InsightEntities())
            {
                var V = db.Vehicles.SingleOrDefault(x => x.VehicleID == VID);
                V.VehicleMake = Make;
                V.VehicleModel = Model;
                V.VehicleRegistration = Reg;
                V.VehicleTypeID = db.VehicleTypes.SingleOrDefault(x => x.VehicleTypeDescription == Type).VehicleTypeID;
                //V.VehicleYear = Year;
                V.PurchaseDate = PDate;

                db.SaveChanges();

            }


                UpdateVehicleTab.SelectedIndex = 2;
        }

        private void UpdateVehiclePage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'insightDataSet.VehicleType' table. You can move, or remove it, as needed.
            this.vehicleTypeTableAdapter.Fill(this.insightDataSet.VehicleType);

        }
    }
}
