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
    public partial class DeleteEmployeeTypePage : Form
    {
        public DeleteEmployeeTypePage()
        {
            InitializeComponent();
        }

        private void DETCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DETDeleteBtn_Click(object sender, EventArgs e)
        {
            using(InsightEntities db = new InsightEntities())
            {
                var EmpType = db.EmployeeTypes.SingleOrDefault(x => x.EmployeeTypeID == 5);

                if(EmpType != null)
                {
                    db.EmployeeTypes.Remove(EmpType);
                    db.SaveChanges();
                }
            }
        }
    }
}
