using System;
using System.Windows.Forms;

namespace Insight_Prototype_
{
    public partial class AddOrganisationTypePage : Form
    {
        public AddOrganisationTypePage()
        {
            InitializeComponent();
        }

        string OrgDescr = "";
         private void ClosePicBx_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AGNextBtn_Click(object sender, EventArgs e)
        {

            OrgDescr = OrgTypeTb.Text;
            if (OrgDescr == "")
            {
                MessageBox.Show("Please Enter an Organisation Type");
            }
            else
            {
                OTConfirmLbl.Text = OrgDescr;
                AddOrganisationTypeTC.SelectedTab = AddOrganisationTypeTC.TabPages[1];
            }
        }

        private void AGCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AGBackBtn_Click(object sender, EventArgs e)
        {
            AddOrganisationTypeTC.SelectedTab = AddOrganisationTypeTC.TabPages[0];
        }

        private void AGConfirmBtn_Click(object sender, EventArgs e)
        {
            OrganisationType InsightOrganisationType = new OrganisationType();
            InsightOrganisationType.OrganisationTypeDescription = OrgDescr;

            using (InsightEntities db = new InsightEntities())
            {
                db.OrganisationTypes.Add(InsightOrganisationType);
                db.SaveChanges();
            }

            AddOrganisationTypeTC.SelectedTab = AddOrganisationTypeTC.TabPages[2];
        }
    }
}
