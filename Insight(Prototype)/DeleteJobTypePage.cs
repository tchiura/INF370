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
    public partial class DeleteJobTypePage : Form
    {
        public DeleteJobTypePage()
        {
            InitializeComponent();
        }

        private void DEqTCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DEqTDeleteBtn_Click(object sender, EventArgs e)
        {
            using (InsightEntities db = new InsightEntities())
            {
                var JobType = db.JobTypes.SingleOrDefault(x => x.JobTypeID == 2);

                if (JobType != null)
                {
                    db.JobTypes.Remove(JobType);
                    db.SaveChanges();
                }
            }
        }
    }
}
