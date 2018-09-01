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
    public partial class AssignVehiclePage : Form
    {
        public AssignVehiclePage()
        {
            InitializeComponent();
        }

        private void AssignVehiclePage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'insightDataSet.Job' table. You can move, or remove it, as needed.
            this.jobTableAdapter.Fill(this.insightDataSet.Job);
            // TODO: This line of code loads data into the 'insightDataSet.Vehicle' table. You can move, or remove it, as needed.
            this.vehicleTableAdapter.Fill(this.insightDataSet.Vehicle);

        }
    }
}
