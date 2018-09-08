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
    public partial class DeleteEmployeePage : Form
    {
        public DeleteEmployeePage()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Are you sure you want to delete this employee?","Delete",MessageBoxButtons.YesNo);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DEmpDeleteBtn_Click(object sender, EventArgs e)
        {
            //Add deletion of Login and Address as well as getting ID Value from view form
            //Bind all labels to the ID

            using (InsightEntities db = new InsightEntities())
            {
                var Emp = db.Employees.SingleOrDefault(x => x.EmployeeID == 2);

                if (Emp != null)
                {
                    db.Employees.Remove(Emp);
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("We are unble to delete this employee");
                }
            }
        }

        private void EmployeeAd1lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
