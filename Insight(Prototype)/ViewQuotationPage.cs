using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Insight_Prototype_
{
    public partial class ViewQuotationPage : Form
    {
        public ViewQuotationPage()
        {
            InitializeComponent();
        }

        Globals globalClass = new Globals();

        private void ViewQuotationPage_Load(object sender, EventArgs e)
        {
            SqlConnection myConn = new SqlConnection(globalClass.myConn);
            SqlCommand myCmd = new SqlCommand();
            SqlDataAdapter myAdapter = new SqlDataAdapter();
            DataSet projectRequest = new DataSet();

            int clientID = 2;//change to logged in client

            string viewProjectRequest = "Select ((SELECT SUM(JobTypePrice.JobTypePriceAmount) FROM JobTypePrice inner join JobType on JobType.JobTypeID = JobTypePrice.JobTypeID inner join JobTypeQuotationLine on JobTypeQuotationLine.JobTypeID = JobType.JobTypeID inner join ClientQuotation on JobTypeQuotationLine.ClientQuotationID = ClientQuotation.ClientQuotationID inner join ProjectRequest on ProjectRequest.ProjectRequestID = ClientQuotation.ProjectRequestID where ClientID = " + "'" + clientID.ToString() + "'" + " and ProjectRequestStatusID = 2) +(SELECT SUM(ProductPrice.ProductPriceAmount) FROM ProductPrice inner join Product on Product.ProductID = ProductPrice.ProductID inner join ProductClientQuotationLine on ProductClientQuotationLine.ProductID = Product.ProductID inner join ClientQuotation on ProductClientQuotationLine.ClientQuotationID = ClientQuotation.ClientQuotationID inner join ProjectRequest on ProjectRequest.ProjectRequestID = ClientQuotation.ProjectRequestID where ClientID = " + "'" + clientID.ToString() + "'" + " and ProjectRequestStatusID = 2)) as [Total Amount],  ProjectRequestDate as [Request Date], ProjectRequestDescription as [Request Description], AddressDescription as [Project Address], Name as [City], CountryName as [Country], ProjectRequestTypeDescription as [Request Type] From ProjectRequest inner Join Client on ProjectRequest.ClientID = Client.ClientID inner Join ProjectRequestType on ProjectRequest.ProjectRequestTypeID = ProjectRequestType.ProjectRequestTypeID inner Join[Address] on ProjectRequest.AddressID = [Address].AddressID inner Join City on City.CityID = [Address].CityID inner Join Country on Country.CountryID = City.CountryID where Client.ClientID = " + "'" + clientID.ToString() + "'";
            myCmd.Connection = myConn;
            myCmd.CommandText = viewProjectRequest;

            myConn.Open();
            myAdapter.SelectCommand = myCmd;

            myAdapter.Fill(projectRequest, "ProjectRequestTable");
            dgvProjectRequest.DataSource = projectRequest;
            dgvProjectRequest.DataMember = "ProjectRequestTable";

            myConn.Close();
        }
    }
}
