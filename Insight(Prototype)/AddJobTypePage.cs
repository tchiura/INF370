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
    public partial class AddJobTypePage : Form
    {
        public AddJobTypePage()
        {
            InitializeComponent();
        }

        //Add Job Type Details
        string TypeDescr = "";
        private void Button22_Click(object sender, EventArgs e)
        {
            TypeDescr = tbJobType.Text;
            if(TypeDescr == "")
            {
                MessageBox.Show("Please Enter a Job Type");
            }
            else
            {
                JTConfirmLbl.Text = TypeDescr;
                AddJobTypeTC.SelectedTab = AddJobTypeTC.TabPages[1];
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            JobType InsightJobType = new JobType();
            InsightJobType.JobTypeDescription = TypeDescr;

            using (InsightEntities db = new InsightEntities())
            {
                db.JobTypes.Add(InsightJobType);
                db.SaveChanges();
            }

            AddJobTypeTC.SelectedTab = AddJobTypeTC.TabPages[2];
        }

        private void JTCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void JTBackBtn_Click(object sender, EventArgs e)
        {
            AddJobTypeTC.SelectedTab = AddJobTypeTC.TabPages[0];
        }

        private void ClosePicBx_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
