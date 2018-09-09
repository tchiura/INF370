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
    public partial class ViewPurchaseOrderPage : Form
    {
        int POI = 0;
        public ViewPurchaseOrderPage()
        {
            InitializeComponent();
        }

        private void button177_Click(object sender, EventArgs e)
        {
            //MessageBox
            using (InsightEntities db = new InsightEntities())
            {
                var CPO = db.PurchaseOrders.SingleOrDefault(x => x.PurchaseOrderID == POI);
                CPO.PurchaseOrderStatusID = 3;
                db.SaveChanges();
            }
        }

        private void button178_Click(object sender, EventArgs e)
        {
            Form RecProd = new ReceiveProductsPage();
            RecProd.ShowDialog();
        }

        private void button179_Click(object sender, EventArgs e)
        {
            Form Ret = new ReturnsPage();
            Ret.ShowDialog();
        }

        private void button176_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
