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
    public partial class UpdateVehicleTypePage : Form
    {
        string Type = "";
        int VTID = 0;
        public UpdateVehicleTypePage()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            UVehicleTypeTab.SelectedIndex = 0;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            Type = TypeTb.Text;
            CTypeLbl.Text = Type;

            using (InsightEntities db = new InsightEntities())
            {
                var VT = db.VehicleTypes.SingleOrDefault(x => x.VehicleTypeID == VTID);
                VT.VehicleTypeDescription = Type;
                db.SaveChanges();
            }
                UVehicleTypeTab.SelectedIndex = 1;
        }
    }
}
