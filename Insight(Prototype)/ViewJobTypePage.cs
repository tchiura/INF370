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
    public partial class ViewJobTypePage : Form
    {
        public ViewJobTypePage()
        {
            InitializeComponent();
        }

        private void button165_Click(object sender, EventArgs e)
        {
            //Message Box
        }

        private void button166_Click(object sender, EventArgs e)
        {
            Form UJT = new UpdateJobTypePage();
            UJT.ShowDialog();
        }

        private void button164_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
