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
    public partial class AddEmployeeTypePage : Form
    {
        public AddEmployeeTypePage()
        {
            InitializeComponent();
        }

        private void ClosePicBx_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string EmpDescr = "";

        private void ETNextBtn_Click(object sender, EventArgs e)
        {
            EmpDescr = EmpTypetb.Text;
            if (EmpDescr == "")
            {
                MessageBox.Show("Please Enter an Employee Type");
            }
            else
            {
                ETConfirmLbl.Text = EmpDescr;
                AddEmployeeTypeTC.SelectedTab = AddEmployeeTypeTC.TabPages[1];
            }
        }

        private void ETConfirmBtn_Click(object sender, EventArgs e)
        {
            EmployeeType InsightEmployeeType = new EmployeeType();
            InsightEmployeeType.EmployeeTypeDescription = EmpDescr;

            using (InsightEntities db = new InsightEntities())
            {
                db.EmployeeTypes.Add(InsightEmployeeType);
                db.SaveChanges();
            }

            AddEmployeeTypeTC.SelectedTab = AddEmployeeTypeTC.TabPages[2];
        }

        private void ETBackBtn_Click(object sender, EventArgs e)
        {
            AddEmployeeTypeTC.SelectedTab = AddEmployeeTypeTC.TabPages[0];
        }

        private void ETCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
