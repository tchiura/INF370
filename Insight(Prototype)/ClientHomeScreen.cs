﻿using System;
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
    public partial class ClientHomeScreen : Form
    {
        public ClientHomeScreen()
        {
            InitializeComponent();
        }

        private void ClientHomeScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'insightDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.insightDataSet.City);
            // TODO: This line of code loads data into the 'insightDataSet.Country' table. You can move, or remove it, as needed.
            this.countryTableAdapter.Fill(this.insightDataSet.Country);
            // TODO: This line of code loads data into the 'insightDataSet.ProjectRequestType' table. You can move, or remove it, as needed.
            this.projectRequestTypeTableAdapter.Fill(this.insightDataSet.ProjectRequestType);

        }

        private void button160_Click(object sender, EventArgs e)
        {
            PRlbl.Text = PRcbx.Text;
            PRconfirmtxt.Text = PRtext.Text;
            addressline1lbl.Text = addressline1txt.Text;
            addressline2lbl.Text = addressline2txt.Text;
            addressline3lbl.Text = addressline3txt.Text;
            citylbl.Text = citycbx.Text;
            countrylbl.Text = countrycbx.Text;
        }

        private void button162_Click(object sender, EventArgs e)
        {
            string today = DateTime.Today.ToString("yyyy/MM/dd");
            ProjectRequest InsightProjectRequest = new ProjectRequest();
            Address ProjectRequestAd = new Address();

            InsightProjectRequest.ProjectRequestDescription = PRconfirmtxt.Text;
            InsightProjectRequest.ProjectRequestTypeID = Convert.ToInt32(PRcbx.SelectedValue);
            InsightProjectRequest.ProjectRequestDate = Convert.ToDateTime(today);

            ProjectRequestAd.CityID = Convert.ToInt32(citycbx.SelectedValue);

            string projectRequestAddress = addressline1lbl.Text + ", " + addressline2lbl.Text + ", " + addressline3lbl.Text;

            ProjectRequestAd.AddressDescription = projectRequestAddress;

            using (InsightEntities db = new InsightEntities())
            {
                db.Addresses.Add(ProjectRequestAd);
                db.SaveChanges();
            }

            int addressID = ProjectRequestAd.AddressID;

            using (InsightEntities db = new InsightEntities())
            {
                InsightProjectRequest.AddressID = addressID;
                InsightProjectRequest.ProjectRequestStatusID = 1;
                InsightProjectRequest.ClientID = 2; //temporary: needs to be replaced with logged in clientID
                db.ProjectRequests.Add(InsightProjectRequest);
                db.SaveChanges();
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void Userlbl_Click(object sender, EventArgs e)
        {

        }

        private void MinimisePicBx_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button42_Click(object sender, EventArgs e)
        {

        }

        private void button38_Click(object sender, EventArgs e)
        {

        }

        private void button39_Click(object sender, EventArgs e)
        {

        }

        private void button40_Click(object sender, EventArgs e)
        {

        }

        private void button41_Click(object sender, EventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {

        }
    }
}
