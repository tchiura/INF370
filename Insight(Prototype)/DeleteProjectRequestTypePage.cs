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
    public partial class DeleteProjectRequestTypePage : Form
    {
        public DeleteProjectRequestTypePage()
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
                var ProReqType = db.ProjectRequestTypes.SingleOrDefault(x => x.ProjectRequestTypeID == 2);

                if (ProReqType != null)
                {
                    db.ProjectRequestTypes.Remove(ProReqType);
                    db.SaveChanges();
                }

            }
        }
    }
}
