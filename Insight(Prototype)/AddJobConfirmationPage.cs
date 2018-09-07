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
    public partial class AddJobConfirmationPage : Form
    {

        string JobDescr = "";
        DateTime StartD;
        DateTime EndD;
        string JobType = "";
        string Stat = "";
        public AddJobConfirmationPage()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            /*
             *Get Data from Add Project Form 
             */
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Job InsightJob = new Job();

            InsightJob.JobDescription = JobDescr;
            InsightJob.JobStartDate = StartD;
            InsightJob.JobEndDate = EndD;

            using (InsightEntities db = new InsightEntities())
            {
                var Ty = db.JobTypes.SingleOrDefault(x => x.JobTypeDescription == JobType);
                var St = db.JobStatus.SingleOrDefault(x => x.JobStatusDescription == Stat);
                InsightJob.JobTypeID = Ty.JobTypeID;
                InsightJob.JobStatusID = St.JobStatusID;
                db.Jobs.Add(InsightJob);

            }

            this.Close();
        }
    }
}
