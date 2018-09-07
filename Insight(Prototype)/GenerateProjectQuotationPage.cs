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

        private void dgvJobType_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvJobType.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvJobType.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvJobType.Rows[selectedrowindex];
                //if (selectedrowindex!=null)

                int id = Convert.ToInt32(selectedRow.Cells["JobType"].Value);

                //}
                if (id != 0)
                {
                    //int id=Convert.ToInt32(a.ToString());
                    var q = db.JobTypePrices.Where(jtp => jtp.JobTypeID == id).First();
                  //  var x = db.JobTypes.Where(jt => jt.JobTypeID == id)
                  //store in other column
                    dgvJobType[1, selectedrowindex].Value = q.JobTypePriceAmount.ToString();
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
        }
    }
}