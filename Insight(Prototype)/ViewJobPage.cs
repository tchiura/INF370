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
    public partial class ViewJobPage : Form
    {
        public ViewJobPage()
        {
            InitializeComponent();
        }

        private void button90_Click(object sender, EventArgs e)
        {
            Form UJ = new UpdateJobPage();
            UJ.ShowDialog();
        }

        private void button89_Click(object sender, EventArgs e)
        {
            //MessageBox?
        }

        private void button84_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
