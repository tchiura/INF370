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
    public partial class DeleteOrganisationTypePage : Form
    {
        public DeleteOrganisationTypePage()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void DOTDeleteBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to delete this Organisation Type?");
            //OrganisationType InsightOrgType = new OrganisationType();

  
            using (InsightEntities db = new InsightEntities())
            {
                var OType = db.OrganisationTypes.SingleOrDefault(x => x.OrganisationTypeID == 2);
                //replace number with ID from the View OType Screen.
                if (OType != null)
                {
                    db.OrganisationTypes.Remove(OType);
                    db.SaveChanges();
                }
            }
        }
    }
}
