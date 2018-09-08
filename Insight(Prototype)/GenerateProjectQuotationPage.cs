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
using System.Data.Entity;

namespace Insight_Prototype_
{
    public partial class GenerateProjectQuotationPage : Form
    {
        public GenerateProjectQuotationPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        InsightEntities db = new InsightEntities();

        private void GenerateProjectQuotationPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'insightDataSet.JobTypePrice' table. You can move, or remove it, as needed.
            this.jobTypePriceTableAdapter.Fill(this.insightDataSet.JobTypePrice);
            // TODO: This line of code loads data into the 'insightDataSet.Job' table. You can move, or remove it, as needed.
            this.jobTableAdapter.Fill(this.insightDataSet.Job);
            // TODO: This line of code loads data into the 'insightDataSet.JobType' table. You can move, or remove it, as needed.
            this.jobTypeTableAdapter.Fill(this.insightDataSet.JobType);
            // TODO: This line of code loads data into the 'insightDataSet.JobType' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'insightDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.insightDataSet.Product);
            // TODO: This line of code loads data into the 'insightDataSet.ProductType' table. You can move, or remove it, as needed.
            this.productTypeTableAdapter.Fill(this.insightDataSet.ProductType);
        }

        private void ClosePicBx_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimisePicBx_Click(object sender, EventArgs e)
        {

        }

        private void LastColumnComboSelectionChanged(object sender, EventArgs e)
        {
            var currentcell = dgvJobType.CurrentCellAddress;
            var sendingCB = sender as DataGridViewComboBoxEditingControl;
            DataGridViewComboBoxCell cel = (DataGridViewComboBoxCell)dgvJobType.Rows[currentcell.Y].Cells[0];
            cel.Value = sendingCB.EditingControlFormattedValue.ToString();
        }

        private void dgvJobType_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            /* if (dgvJobType.CurrentCell.ColumnIndex == 1 && e.Control is ComboBox)
            {
                ComboBox comboBox = e.Control as ComboBox;
                comboBox.SelectedIndexChanged -= LastColumnComboSelectionChanged;
                comboBox.SelectedIndexChanged += LastColumnComboSelectionChanged;
            }*/
        }

        string a;
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(a);
        }

        Globals globalClass = new Globals();
        List<int> jtID = new List<int>();
        private void dgvJobType_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvJobType.SelectedCells.Count > 0)
            {
                int id = 0;
                int selectedrowindex = dgvJobType.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvJobType.Rows[selectedrowindex];
                //if (selectedrowindex!=null)
                SqlDataReader myReader;
                SqlConnection myConn = new SqlConnection(globalClass.myConn);
                string jobTypeD = selectedRow.Cells["JobType"].Value.ToString();

                SqlCommand getJobTypeID = new SqlCommand("Select JobTypeID from JobType Where JobTypeDescription =" + "'" + jobTypeD + "'", myConn);
                myConn.Open();

                myReader = getJobTypeID.ExecuteReader();

                while (myReader.Read())
                {
                    id = Convert.ToInt32(myReader["JobTypeID"]);
                }
                myReader.Close();
                //}
                if (id != 0)
                {
                    //int id=Convert.ToInt32(a.ToString());
                    var q = db.JobTypePrices.Where(jtp => jtp.JobTypeID == id).First();
                    //  var x = db.JobTypes.Where(jt => jt.JobTypeID == id)
                    //store in other column
                    dgvJobType[1, selectedrowindex].Value = q.JobTypePriceAmount.ToString();
                    jtID.Add(id);
                    dgvJobType.Refresh();
                }
            }
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*   
      DataGridViewComboBoxColumn cmbColumn = (DataGridViewComboBoxColumn)dgvProduct.Columns["ProductType"];
      string sItem = "";
      sItem = dgvProduct.CurrentCell.EditedFormattedValue.ToString();
      cmbColumn.Items.Remove(sItem);
      dgvProduct.Refresh(); */
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DataTable product = new DataTable();
            DataTable jobtable = new DataTable();

            foreach (DataGridViewColumn col in dgvJobType.Columns)
            {
                jobtable.Columns.Add(col.Name);
            }


            foreach (DataGridViewColumn col in dgvProduct.Columns)
            {
                product.Columns.Add(col.Name);
            }

            foreach (DataGridViewRow row in dgvJobType.Rows)
            {
                DataRow dRow = jobtable.NewRow();

                foreach (DataGridViewCell cell in row.Cells)
                {
                    //dgvProduct.CurrentRow.Cells["JobType"].Value.ToString();
                    dRow[cell.ColumnIndex] = cell.Value;
                }

                /*foreach (DataGridViewCell cell in row.Cells)
                {
                    //dgvProduct.CurrentRow.Cells["JobType"].Value.ToString();
                    dRow[cell.ColumnIndex] = cell.Value;
                }*/

                jobtable.Rows.Add(dRow);
            }

            foreach (DataGridViewRow row in dgvProduct.Rows)
            {
                DataRow dRow = product.NewRow();

                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                product.Rows.Add(dRow);
            }

            dgvcProduct.DataSource = product;
            dgvcJobType.DataSource = jobtable;
            dgvcProduct.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvcProduct.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvcProduct.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvcJobType.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvcJobType.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        List<int> pID = new List<int>();
        private void button2_Click(object sender, EventArgs e)
        {
            ClientQuotation InsightQuotation = new ClientQuotation();
            ProjectRequest InsightProjectRequest = new ProjectRequest();
            string today = DateTime.Today.ToString("yyyy/MM/dd");
            int projectRequestID = 1006;

            //store in ClientQuotationTable
            InsightQuotation.ClientQuotationDate = Convert.ToDateTime(today);
            InsightQuotation.ProjectRequestID = projectRequestID;//use from selectedProjectRequest
            InsightQuotation.ClientQuotationStatusID = 1;



            using (InsightEntities db = new InsightEntities())
            {
                db.ClientQuotations.Add(InsightQuotation);
                db.SaveChanges();
            }

            int quotationID = InsightQuotation.ClientQuotationID;

            SqlConnection myConn = new SqlConnection(globalClass.myConn);
            #region Store JobTypeQuotationLine
            // string StrQueryJT;

            foreach (int j in jtID.Distinct().ToList())
            {
                try
                {
                    SqlCommand insertJobType = new SqlCommand("Insert into JobTypeQuotationLine(ClientQuotationID, JobTypeID) VALUES(@ClientQuotationID, @JobTypeID)", myConn);
                    insertJobType.Parameters.AddWithValue("@ClientQuotationID", quotationID);
                    insertJobType.Parameters.AddWithValue("@JobTypeID", j);
                    myConn.Open();
                    insertJobType.ExecuteNonQuery();
                    myConn.Close();
                }
                catch (Exception myEx)
                {
                    MessageBox.Show("Error: " + myEx.Message);
                }
            }
            #endregion
            SqlDataReader myReader;

            int productID = 0;
            #region store ProductQuotationLine
           // string StrQueryP;
            try
            {
                #region get ProductID
                for (int i = 0; i < dgvcProduct.Rows.Count; i++)
                {
                    SqlCommand getProductID = new SqlCommand("Select ProductID From Product Where ProductDescription =" + "'" + dgvcProduct.Rows[i].Cells["Product"].Value + "'", myConn);
                    myConn.Open();
                    myReader = getProductID.ExecuteReader();

                    while (myReader.Read())
                    {
                        productID = Convert.ToInt32(myReader["ProductID"]);
                    }
                    pID.Add(productID);
                    myReader.Close();
                    myConn.Close();
                }
                #endregion

                int x = 0;
                foreach(int i in pID.Distinct().ToList())
                {
                    try
                    {
                        SqlCommand insertProduct = new SqlCommand("Insert into ProductClientQuotationLine(ClientQuotationID, ProductID, Quantity) Values (@ClientQuotationID, @ProductID, @Quantity)", myConn);
                        myConn.Open();
                        insertProduct.Parameters.AddWithValue("@ClientQuotationID", quotationID);
                        insertProduct.Parameters.AddWithValue("@ProductID", i);
                        insertProduct.Parameters.AddWithValue("@Quantity", dgvProduct.Rows[x].Cells[2].Value.ToString());
                        insertProduct.ExecuteNonQuery();
                        myConn.Close();
                        x++;
                            //increment value to hold for Quantity in Datagridview
                    }
                    catch (Exception myEx)
                    {
                        MessageBox.Show("Error: " + myEx.Message);
                    }
                }
            }
            catch (Exception myEx)
            {
                MessageBox.Show("Error: " + myEx.Message);
            }
            #endregion

            InsightProjectRequest.ProjectRequestID = projectRequestID;
            using (InsightEntities db = new InsightEntities())
            {
                InsightProjectRequest = db.ProjectRequests.Where(x => x.ProjectRequestID == InsightProjectRequest.ProjectRequestID).FirstOrDefault();
                InsightProjectRequest.ProjectRequestStatusID = 2;
                db.Entry(InsightProjectRequest).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}