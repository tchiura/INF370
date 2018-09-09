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
    public partial class ViewVehiclePage : Form
    {
        public ViewVehiclePage()
        {
            InitializeComponent();
        }

        private void button99_Click(object sender, EventArgs e)
        {
            Form UV = new UpdateVehiclePage();
            UV.ShowDialog();
        }

        private void button98_Click(object sender, EventArgs e)
        {
            Form RV = new RemoveVehiclePage();
            RV.ShowDialog();
            //Or Should we MSGBox this aswell?
        }

        private void button101_Click(object sender, EventArgs e)
        {
            Form UVStat = new UpdateVehicleStatusPage();
            UVStat.ShowDialog();
        }

        private void button100_Click(object sender, EventArgs e)
        {
            Form AV = new AssignVehiclePage();
            AV.ShowDialog();
        }
    }
}
