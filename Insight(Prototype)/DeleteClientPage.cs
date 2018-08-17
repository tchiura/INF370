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
    public partial class DeleteClientPage : Form
    {
        public DeleteClientPage()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to delete this client?", "Delete", MessageBoxButtons.YesNo);
            //MessageBoxButtons.YesNo =;
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void DeleteClientDetailsPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
