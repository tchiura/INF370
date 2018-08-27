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
        string EType = "";
        public AddEmployeeTypePage()
        {
            InitializeComponent();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            EType = AETypeTb.Text;
            if(EType == "")
            {
                MessageBox.Show("Please enter a valid Employee Type.");
            }
            else
            {
                AETConfirmLbl.Text = EType;
                AddEmployeeTypeTab.SelectedIndex = 1;
            }
        }

        private void AETBackBtn_Click(object sender, EventArgs e)
        {
            AddEmployeeTypeTab.SelectedIndex = 0;
            AETypeTb.Focus();
            AETypeTb.Clear();
        }

        private void AETConfirmBtn_Click(object sender, EventArgs e)
        {
            EmployeeType InsightEmployeeType = new EmployeeType();

            InsightEmployeeType.EmployeeTypeDescription = EType;

            using (InsightEntities db = new InsightEntities())
            {
                db.EmployeeTypes.Add(InsightEmployeeType);
                db.SaveChanges();
                AddEmployeeTypeTab.SelectedIndex = 2;
            }
        }

        private void AETCancelBtn_Click(object sender, EventArgs e)
        {
            Form Home = new HomeScreen();
            Home.Show();
            this.Show();
        }
    }
}
