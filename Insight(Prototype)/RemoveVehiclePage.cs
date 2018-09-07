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
    public partial class RemoveVehiclePage : Form
    {
        int VID = 0;
        public RemoveVehiclePage()
        {
            InitializeComponent();
        }

        private void AVBackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            Vehicle InsightVehicle = new Vehicle();
            using (InsightEntities db = new InsightEntities())
            {
                var V = db.Vehicles.SingleOrDefault(x => x.VehicleID == VID);
                db.Vehicles.Remove(V);
                db.SaveChanges();
            }
        }
    }
}
