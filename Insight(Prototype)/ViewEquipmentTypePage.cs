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
    public partial class ViewEquipmentTypePage : Form
    {
        public ViewEquipmentTypePage()
        {
            InitializeComponent();
        }

        private void button124_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox
        }

        private void button126_Click(object sender, EventArgs e)
        {
            Form UE = new UpdateEquipmentPage();
            UE.ShowDialog();
        }
    }
}
