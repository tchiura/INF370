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
    public partial class CreatePurchaseOrderPage : Form
    {
        public CreatePurchaseOrderPage()
        {
            InitializeComponent();
        }

        private void CreatePurchaseOrderPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'insightDataSet.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.insightDataSet.Supplier);
            // TODO: This line of code loads data into the 'insightDataSet.ProjectRequest' table. You can move, or remove it, as needed.
            this.projectRequestTableAdapter.Fill(this.insightDataSet.ProjectRequest);

        }
    }
}
