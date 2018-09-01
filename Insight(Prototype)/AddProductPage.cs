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
    public partial class AddProductPage : Form
    {
        string Descr = "";
        string Type = "";
        int Quantity = 0;
        decimal Price = 0;
        public AddProductPage()
        {
            InitializeComponent();
        }

        private void label237_Click(object sender, EventArgs e)
        {

        }

        private void AProdCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AProdNextBtn_Click(object sender, EventArgs e)
        {
            if(Descr == "" | Type == "" | Quantity == 0 | Price == 0)
            {
                MessageBox.Show("Please enter all relevant values");
            }
            else
            {
                Descr = AProdDescrTb.Text;
                Type = AProdTypeCmb.Text;
                Quantity = Convert.ToInt32(AProdQuntityUD.Value);
                Price = Convert.ToDecimal(AProdPriceTb.Text);

                CAProdDescrLbl.Text = Descr;
                CAProdPriceLbl.Text = Convert.ToString(Price);
                CAProdQuantityLbl.Text = Convert.ToString(Quantity);
                CAProdTypeLbl.Text = Type;

                AddProductTab.SelectedIndex = 1;
            }

        }

        private void AProdBackBtn_Click(object sender, EventArgs e)
        {
            AddProductTab.SelectedIndex = 0;
        }

        private void AProdConfirmBtn_Click(object sender, EventArgs e)
        {
            Product InsightProduct = new Product();
            ProductPrice InsightProdPrice = new ProductPrice();

            InsightProduct.ProductDescription = Descr;
            InsightProduct.ProductQuantity = Quantity;
            //InsightProduct.ProductType = Type;
            //InsightProduct.ProductPrices = InsightProdPrice;

            InsightProdPrice.ProductPriceDate = DateTime.Now;
            InsightProdPrice.ProductPriceAmount = Price;
            //InsightProdPrice.ProductID = ?
            using (InsightEntities db = new InsightEntities())
            {
                db.Products.Add(InsightProduct);
                db.SaveChanges();
                //Selecting the ID to save into the Price Table
                //var ID = db.Products.Select(x => x.ProductDescription == InsightProduct.ProductDescription);
            }
        }
    }
}
