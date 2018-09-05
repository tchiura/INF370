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
    public partial class AddSupplierPage : Form
    {
        string CPTitle = "";
        string CPName = "";
        string CPEmail = "";
        string SupName = "";
        string CPNumber = "";
        string AddL1 = "";
        string AddL2 = "";
        string AddL3 = "";
        string City = "";
        string Country = "";

        public AddSupplierPage()
        {
            InitializeComponent();
        }

        private void button167_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            CPTitle = TitleCmb.Text;
            SupName = SupplierNameTb.Text;
            CPName = CPNameTb.Text;
            CPNumber = NumberTb.Text;
            CPEmail = EmailTb.Text;
            AddL1 = AddL1Tb.Text;
            AddL2 = AddL2Tb.Text;
            AddL3 = AddL3Tb.Text;
            City = CityCmb.Text;
            Country = CountryCmb.Text;

            if(CPTitle == null | SupName == null | CPName == null)
            {

            }
            else
            {
                Add1Lbl.Text = AddL1;

            }
        }
    }
}
