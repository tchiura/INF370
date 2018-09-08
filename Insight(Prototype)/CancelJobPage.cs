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
    public partial class CancelJobPage : Form
    {
        public CancelJobPage()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to delete this job?", "Delete", MessageBoxButtons.YesNo);
            //if(MessageBoxButtons.YesNo == "Yes")
            {
                using (InsightEntities db = new InsightEntities())
                {
                    var job = db.Jobs.SingleOrDefault(x => x.JobID == 2);

                    db.Jobs.Remove(job);
                    db.SaveChanges();
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
