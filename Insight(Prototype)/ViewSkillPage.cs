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
    public partial class ViewSkillPage : Form
    {
        public ViewSkillPage()
        {
            InitializeComponent();
        }

        private void button136_Click(object sender, EventArgs e)
        {
            //Are You Sure MessageBox()
        }

        private void button137_Click(object sender, EventArgs e)
        {
            Form US = new UpdateSkillPage();
            US.ShowDialog();
        }
    }
}
