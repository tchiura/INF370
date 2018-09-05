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

        Globals globalClass = new Globals();
        string JT;
        public AddJobTypePage()
        {
            InitializeComponent();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            string JT = AJTypeTb.Text;
            if(JT == "")
            {
                MessageBox.Show("Please enter a valid Job Type.");
            }
            else
            {
                AddJobTypeTab.SelectedIndex = 1;
                AJTConfirmLbl.Text = JT;
            }
        }

        private void AJTCancelBtn_Click(object sender, EventArgs e)
        {
            Form Home = new HomeScreen();
            Home.Show();
            this.Close();
        }

        private void AJTBackBtn_Click(object sender, EventArgs e)
        {
            AddJobTypeTab.SelectedIndex = 0;
            AJTypeTb.Focus();
            AJTypeTb.Clear();
        }

        private void AJTConfirmBtn_Click(object sender, EventArgs e)
        {
            JobType InsightJobType = new JobType();

            InsightJobType.JobTypeDescription = JT;

            using (InsightEntities db = new InsightEntities())
            {
                db.JobTypes.Add(InsightJobType);
                db.SaveChanges();
            }
        }
    }
}
