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
    public partial class UpdateProductPage : Form
    {
        string ProdDesc = "";
        string ProdType = "";
        int ProdID = 0;
        public UpdateProductPage()
        {
            InitializeComponent();
        }

        private void label58_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            ProdDesc = DescTb.Text;
            ProdType = TypeTb.Text;

            CDescLbl.Text = ProdDesc;
            CTypeLbl.Text = ProdType;
            UpdateProductTab.SelectedIndex = 1;
        }

        private void BBtn_Click(object sender, EventArgs e)
        {
            UpdateProductTab.SelectedIndex = 0;
        }

        private void ConBtn_Click(object sender, EventArgs e)
        {
            
            using (InsightEntities db = new InsightEntities())
            {
                var P = db.Products.SingleOrDefault(x => x.ProductID == ProdID);
                P.ProductDescription = ProdDesc;
                P.ProductType = db.ProductTypes.SingleOrDefault(x => x.ProductTypeDescription == ProdType);
                db.SaveChanges();
            }
            UpdateProductTab.SelectedIndex = 2;
        }
    }
}
