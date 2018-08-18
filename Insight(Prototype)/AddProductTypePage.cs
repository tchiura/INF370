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
    public partial class AddProductTypePage : Form
    {
        public AddProductTypePage()
        {
            InitializeComponent();
        }

        string ProdDescr = "";
        private void ClosePicBx_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AProdNextBtn_Click(object sender, EventArgs e)
        {
            
            ProdDescr = ProdTypeTb.Text;
            if (ProdDescr == "")
            {
                MessageBox.Show("Please Enter an Product Type");
            }
            else
            {
                ProdTConfirmLbl.Text = ProdDescr;
                AddProductTypeTC.SelectedTab = AddProductTypeTC.TabPages[1];
            }
        }

        private void ProdTBackBtn_Click(object sender, EventArgs e)
        {
            AddProductTypeTC.SelectedTab = AddProductTypeTC.TabPages[0];
        }

        private void ProbTConfirmBtn_Click(object sender, EventArgs e)
        {
            ProductType InsightProductType = new ProductType();
            InsightProductType.ProductTypeDescription = ProdDescr;

            using (InsightEntities db = new InsightEntities())
            {
                db.ProductTypes.Add(InsightProductType);
                db.SaveChanges();
            }

            AddProductTypeTC.SelectedTab = AddProductTypeTC.TabPages[2];
        }

        private void AProdCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
