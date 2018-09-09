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
    public partial class ViewClientPage : Form
    {
        public ViewClientPage()
        {
            InitializeComponent();
        }

        private void button74_Click(object sender, EventArgs e)
        {
            Form DC = new DeleteClientPage();
            DC.ShowDialog();
        }

        private void button72_Click(object sender, EventArgs e)
        {
            Form VCL = new ViewClientLoginPage();
            VCL.ShowDialog();
        }

        private void button70_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
