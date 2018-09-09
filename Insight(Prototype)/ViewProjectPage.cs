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
    public partial class ViewProjectPage : Form
    {
        public ViewProjectPage()
        {
            InitializeComponent();
        }

        private void button80_Click(object sender, EventArgs e)
        {
            Form UP = new UpdateProjectPage();
            UP.ShowDialog();
        }

        private void button79_Click(object sender, EventArgs e)
        {
            Form UPP = new UpdateProjectPhasePage();
            UPP.ShowDialog();
        }

        private void button81_Click(object sender, EventArgs e)
        {
            Form GI = new GenerateInvoicePage();
            GI.ShowDialog();
        }

        private void button208_Click(object sender, EventArgs e)
        {
            //MessageBox??
        }

        private void button76_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
