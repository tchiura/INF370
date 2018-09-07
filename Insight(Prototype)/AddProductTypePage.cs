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
        string ProdType = "";
        public AddProductTypePage()
        {
            InitializeComponent();
        }

        private void AProdTCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AProdTNextBtn_Click(object sender, EventArgs e)
        {
            ProdType = AProdTypeTb.Text;
            if (ProdType == "")
            {
                MessageBox.Show("Please enter a valid Employee Type.");
            }
            else
            {
                AProdTConftimLbl.Text = ProdType;
                AddProductTypeTab.SelectedIndex = 1;
            }

        }

        private void AProdTBackBtn_Click(object sender, EventArgs e)
        { 
            AddProductTypeTab.SelectedIndex = 0;
        }

        private void AProdTConfirmBtn_Click(object sender, EventArgs e)
        {
            ProductType InsightProdType = new ProductType();

            InsightProdType.ProductTypeDescription = ProdType;

            using (InsightEntities db = new InsightEntities())
            {
                db.ProductTypes.Add(InsightProdType);
                db.SaveChanges();
            }
                AddProductTypeTab.SelectedIndex = 2;
        }
    }
}
