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
    public partial class UpdateEmployeeTypePage : Form
    {
        string ET = "";
        int EType = 0;
        public UpdateEmployeeTypePage()
        {
            InitializeComponent();
        }

        private void AddClientTypeDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TopBarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label58_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            ET = ETypeTb.Text;
            CETypeLbl.Text = ET;
            UpdateEmployeeTypeTab.SelectedIndex = 1;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            UpdateEmployeeTypeTab.SelectedIndex = 0;
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            using (InsightEntities db = new InsightEntities())
            {
                var ETObj = db.EmployeeTypes.SingleOrDefault(x => x.EmployeeTypeID == EType);

                ETObj.EmployeeTypeDescription = ET;
                db.SaveChanges();
                UpdateEmployeeTypeTab.SelectedIndex = 2;
            }
        }
    }
}
