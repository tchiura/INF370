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
        public RemoveVehiclePage()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to remove this equipment?", "Remove", MessageBoxButtons.YesNo);
        }

        private void DeleteClientDetailsPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
