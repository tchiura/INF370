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
    public partial class DeleteSupplierPage : Form
    {
        public DeleteSupplierPage()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to delete this supplier?", "Delete", MessageBoxButtons.YesNo);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            using (InsightEntities db = new InsightEntities())
            {
                var S = db.Suppliers.SingleOrDefault(x => x.SupplierID == 1);
                var CP = db.ContactPersons.SingleOrDefault(x => x.SupplierID == S.SupplierID); //Get Exact CP if more than one?
                //if CP still exist?? Delete all, we are deleting a whole supplier so I guess delete all CPs.
                db.ContactPersons.Remove(CP);
                db.Suppliers.Remove(S);
                db.SaveChanges();
            }
        }
    }
}
