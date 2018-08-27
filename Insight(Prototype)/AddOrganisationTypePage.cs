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
    public partial class AddOrganisationTypePage : Form
    {
        string OrgType = "";
        public AddOrganisationTypePage()
        {
            InitializeComponent();
        }

        private void AOTNextBtn_Click(object sender, EventArgs e)
        {
            OrgType = AOTypeTb.Text;
            if (OrgType == "")
            {
                MessageBox.Show("Please enter a valid Organisation Type.");
            }
            else
            {
                AOTConfirmLbl.Text = OrgType;
                AddOrganisationTypeTab.SelectedIndex = 1;
            }
        }

        private void AOTCancelBtn_Click(object sender, EventArgs e)
        { 
            Form Home = new HomeScreen();
            Home.Show();
            this.Show();
        }

        private void AOTBackBtn_Click(object sender, EventArgs e)
        {
            AddOrganisationTypeTab.SelectedIndex = 0;
        }

        private void AOTConfirmBtn_Click(object sender, EventArgs e)
        {
            ClientType InsightOrgType = new ClientType();

            InsightOrgType.ClientTypeDescription = OrgType;

            using (InsightEntities db = new InsightEntities())
            {
                db.ClientTypes.Add(InsightOrgType);
                db.SaveChanges();
                AddOrganisationTypeTab.SelectedIndex = 2;
            }
        }
    }
}
