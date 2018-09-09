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
    public partial class ViewProductPage : Form
    {
        public ViewProductPage()
        {
            InitializeComponent();
        }

        private void button94_Click(object sender, EventArgs e)
        {
            Form UP = new UpdateProductPage();
            UP.ShowDialog();
        }

        private void button93_Click(object sender, EventArgs e)
        {
            //MessageBox - Quantity must be zero
        }

        private void button95_Click(object sender, EventArgs e)
        {
            Form AP = new AssignProductPage();
            AP.ShowDialog();
        }

        private void button92_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
