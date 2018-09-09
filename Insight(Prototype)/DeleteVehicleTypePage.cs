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
    public partial class DeleteVehicleTypePage : Form
    {
        int VID;
        public DeleteVehicleTypePage()
        {
            InitializeComponent();
        }

        private void DVTBackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DVTConfirmBtn_Click(object sender, EventArgs e)
        {
            using (InsightEntities db = new InsightEntities())
            {
                var VType = db.VehicleTypes.SingleOrDefault(x => x.VehicleTypeID == 2);

                if(VType != null)
                {
                    db.VehicleTypes.Remove(VType);
                    db.SaveChanges();
                }
            }
        }

        private void DeleteVehicleTypePage_Load(object sender, EventArgs e)
        {
            using (InsightEntities db = new InsightEntities())
            {
                db.VehicleTypes.SingleOrDefault(x => x.VehicleTypeID == VID);
            }
        }
    }
}
