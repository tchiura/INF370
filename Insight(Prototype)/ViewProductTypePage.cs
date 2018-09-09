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
    public partial class ViewProductTypePage : Form
    {
        public ViewProductTypePage()
        {
            InitializeComponent();
        }

        private void button220_Click(object sender, EventArgs e)
        {
            Form UPT = new UpdateProductTypePage();
            UPT.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox
        }

        private void button218_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
