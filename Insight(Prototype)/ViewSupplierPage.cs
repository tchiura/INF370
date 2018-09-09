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
    public partial class ViewSupplierPage : Form
    {
        public ViewSupplierPage()
        {
            InitializeComponent();
        }

        private void ViewSupplierPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'insightDataSet.ContactPerson' table. You can move, or remove it, as needed.
            this.contactPersonTableAdapter.Fill(this.insightDataSet.ContactPerson);
            // TODO: This line of code loads data into the 'insightDataSet.Supplier' table. You can move, or remove it, as needed.
            //this.supplierTableAdapter.Fill(this.insightDataSet.Supplier);

        }

        private void button173_Click(object sender, EventArgs e)
        {
            
        }
    }
}
