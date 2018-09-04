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
    public partial class ViewVehicleTypePage : Form
    {
        public ViewVehicleTypePage()
        {
            InitializeComponent();
        }

        private void ViewVehicleTypePage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'insightDataSet.VehicleType' table. You can move, or remove it, as needed.
            this.vehicleTypeTableAdapter.Fill(this.insightDataSet.VehicleType);

        }
    }
}
