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
    public partial class ViewClientTypePage : Form
    {
        public ViewClientTypePage()
        {
            InitializeComponent();
        }

        private void button113_Click(object sender, EventArgs e)
        {
            //Message Box
            Form DOT = new DeleteOrganisationTypePage();
            DOT.ShowDialog();

        }

        private void button114_Click(object sender, EventArgs e)
        {
            Form UOT = new UpdateOrganisationTypePage();
            UOT.ShowDialog();
        }

        private void button112_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
