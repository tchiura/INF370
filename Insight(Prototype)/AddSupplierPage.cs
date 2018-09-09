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
        //string CPTitle = "";
        string CPName = "";
        string CPEmail = "";
        string SupName = "";
        string CPNumber = "";
        string AddL1 = "";
        string AddL2 = "";
        string AddL3 = "";
        string City = "";
        string Country = "";
        string JobD = "";

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
            //CPTitle = TitleCmb.Text;
            SupName = SupplierNameTb.Text;
            CPName = CPNameTb.Text;
            CPNumber = NumberTb.Text;
            CPEmail = EmailTb.Text;
            AddL1 = AddL1Tb.Text;
            AddL2 = AddL2Tb.Text;
            AddL3 = AddL3Tb.Text;
            City = CityCmb.Text;
            Country = CountryCmb.Text;
            JobD = JobDecrTb.Text;

            if(SupName == null | CPName == null)
            {

            }
            else
            {
                Add1Lbl.Text = AddL1;
                Add2Lbl.Text = AddL2;
                Add3Lbl.Text = AddL3;
                CityLbl.Text = City;
                CountryLbl.Text = Country;
                //TitleLbl.Text = CPTitle;
                NameLbl.Text = SupName;
                CPNameLbl.Text = CPName;
                NumberLbl.Text = CPNumber;
                EmailLbl.Text = CPEmail;
                JobDescrLbl.Text = JobD;
                AddSupplierTab.SelectedIndex = 1;
            }
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            Supplier InsightSupplier = new Supplier();
            ContactPerson InsightCP = new ContactPerson();
            Address InsightAddress = new Address();

            InsightSupplier.SupplierName = SupName;
            InsightAddress.AddressDescription = AddL1 + " " + AddL2 + " " + AddL3;
            //InsightAddress.City = City;
            //InsightAddress.County = Country;
            InsightCP.ContactPersonName = CPName;
            InsightCP.ContactPersonPhoneNumber = Convert.ToInt32(CPNumber);
            InsightCP.ContactPersonJobDescription = JobD;
            InsightCP.ContactPersonEmailAddress = CPEmail;

            InsightCP.SupplierID = InsightSupplier.SupplierID;
            InsightSupplier.AddressID = InsightAddress.AddressID;

            using (InsightEntities db = new InsightEntities())
            {

                db.Suppliers.Add(InsightSupplier);
                db.ContactPersons.Add(InsightCP);
                db.Addresses.Add(InsightAddress);
                db.SaveChanges();
            }

            
        }

        private void AddSupplierPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'insightDataSet.ContactPerson' table. You can move, or remove it, as needed.
            this.contactPersonTableAdapter.Fill(this.insightDataSet.ContactPerson);
            // TODO: This line of code loads data into the 'insightDataSet.Country' table. You can move, or remove it, as needed.
            this.countryTableAdapter.Fill(this.insightDataSet.Country);
            // TODO: This line of code loads data into the 'insightDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.insightDataSet.City);

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            AddSupplierTab.SelectedIndex = 0;
        }
    }
}
