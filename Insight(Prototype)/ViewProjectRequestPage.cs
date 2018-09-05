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
    public partial class ViewProjectRequestPage : Form
    {
        public ViewProjectRequestPage()
        {
            InitializeComponent();
        }

        Globals globalclass = new Globals();
        
        private void ViewProjectRequestPage_Load(object sender, EventArgs e)
        {
            SqlConnection myConn = new SqlConnection(globalclass.myConn);
            SqlCommand myCmd = new SqlCommand();
            SqlDataAdapter myAdapter = new SqlDataAdapter();
            DataSet projectRequest = new DataSet();

            string viewProjectRequest = "Select ProjectRequestID, ProjectRequestDescription, ClientName, AddressDescription, Name, CountryName, ProjectRequestTypeDescription, ProjectRequestDate From((((ProjectRequest inner Join Client on ProjectRequest.ClientID = Client.ClientID) inner Join ProjectRequestType on ProjectRequest.ProjectRequestTypeID = ProjectRequestType.ProjectRequestTypeID) inner Join [Address] on ProjectRequest.AddressID = [Address].AddressID) inner Join City on City.CityID = [Address].CityID) inner Join Country on Country.CountryID = City.CountryID";
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
