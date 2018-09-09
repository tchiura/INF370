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
    public partial class ViewEmployeePage : Form
    {
        public ViewEmployeePage()
        {
            InitializeComponent();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            //MSG
            Form DE = new DeleteEmployeePage();
            DE.ShowDialog();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Form UE = new UpdateEmployeeDetailsPage();
            UE.ShowDialog();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Form VL = new ViewEmployeeLoginPage();
            VL.ShowDialog();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Form VES = new ViewEmployeeSchedulePage();
            VES.ShowDialog();
        }
    }
}
