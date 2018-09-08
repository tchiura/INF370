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
    public partial class UpdateSupplierPage : Form
    {
        int SupID = 0;
        int CPID = 0;
        public UpdateSupplierPage()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            UpdateSupplierTab.SelectedIndex = 0;
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            UpdateSupplierTab.SelectedIndex = 1;
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            using (InsightEntities db = new InsightEntities())
            {
                var S = db.Suppliers.SingleOrDefault(x => x.SupplierID == SupID);
                //var CP = db.ContactPersons.SingleOrDefault(x => x.ContactPersonID == CPID);
                //Properly Search CP
                db.SaveChanges();
            }
            UpdateSupplierTab.SelectedIndex = 2;
        }
    }
}
