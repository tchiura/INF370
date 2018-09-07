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
    public partial class AddProjectRequestTypePage : Form
    {
        string ProReq = "";
        public AddProjectRequestTypePage()
        {
            InitializeComponent();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            ProReq = PReqTypeTb.Text;

            if(ProReq == "")
            {
                MessageBox.Show("Please enter a valid Project Request Type");
            }
            else
            {
                PReqConfirmLbl.Text = ProReq;
                AddProjectRequestTypeTab.SelectedIndex = 1;
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            AddProjectRequestTypeTab.SelectedIndex = 0;
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            ProjectRequestType InsightProReqType = new ProjectRequestType();

            InsightProReqType.ProjectRequestDescription = ProReq;

            using (InsightEntities db = new InsightEntities())
            {
                db.ProjectRequestTypes.Add(InsightProReqType);
                db.SaveChanges();
            }
                AddProjectRequestTypeTab.SelectedIndex = 2;
        }
    }
}
