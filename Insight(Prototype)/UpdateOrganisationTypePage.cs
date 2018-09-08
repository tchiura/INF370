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
    public partial class UpdateOrganisationTypePage : Form
    {
        int OTID = 0;
        string OType = "";
        public UpdateOrganisationTypePage()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OrgTypeTb.Visible = true;
            OrgTypeLbl.Visible = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            UpdateOrgTypeTab.SelectedIndex = 1;
            OType = OrgTypeTb.Text;
        }

        private void button23_Click(object sender, EventArgs e)
        {

            UpdateOrgTypeTab.SelectedIndex = 0;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            using (InsightEntities db = new InsightEntities())
            {
                var OT = db.OrganisationTypes.SingleOrDefault(x => x.OrganisationTypeID == OTID);
                if(OT != null)
                {
                    OT.OrganisationTypeDescription = OType;
                    db.SaveChanges();
                }
            }

            UpdateOrgTypeTab.SelectedIndex = 2;
        }
    }
}
