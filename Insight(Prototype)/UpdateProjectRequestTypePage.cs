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
    public partial class UpdateProjectRequestTypePage : Form
    {
        int PRID = 0;
        string P = "";
        public UpdateProjectRequestTypePage()
        {
            InitializeComponent();
        }

        private void UpdateProjectRequestTypePage_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            ProjectRequestTypeTab.SelectedIndex = 0;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            using (InsightEntities db = new InsightEntities())
            {
                var PR = db.ProjectRequestTypes.SingleOrDefault(x => x.ProjectRequestTypeID == PRID);
                PR.ProjectRequestDescription = P;
                db.SaveChanges();
            }
            ProjectRequestTypeTab.SelectedIndex = 2;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            P = PRTTb.Text;

            CPRTLbl.Text = P;
            ProjectRequestTypeTab.SelectedIndex = 1;
        }
    }
}
