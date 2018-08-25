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
    public partial class HomeScreen : Form
    {
        Globals globalClass = new Globals();
        public HomeScreen()
        {
            InitializeComponent();

            AddClientDetailsTab.Appearance = TabAppearance.FlatButtons;
            AddVehiclePanel.Appearance = TabAppearance.FlatButtons;
            //AddVehiclePanel.
            //AddClientDetailsTab.c

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'insightDataSet.Country' table. You can move, or remove it, as needed.
            this.countryTableAdapter.Fill(this.insightDataSet.Country);
            // TODO: This line of code loads data into the 'insightDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.insightDataSet.City);
            // TODO: This line of code loads data into the 'insightDataSet.EmployeeType' table. You can move, or remove it, as needed.
            this.employeeTypeTableAdapter.Fill(this.insightDataSet.EmployeeType);
            List<string> skills = GetTagList().ToList();

            foreach (string x in skills)
            {
                SkillList.Items.Add(x);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            JobActionPanel.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MinimisePicBx_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CConfirmation_Click(object sender, EventArgs e)
        {

        }

        private void CDetails_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddClientDetailsTab.TabIndex = 1;
        }

        private void CComplete_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void EDetails_Click(object sender, EventArgs e)
        {

        }

        private void ESkills_Click(object sender, EventArgs e)
        {

        }

        private void label54_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            //ClientActionPanel.Visible = false;
            AddClientDetailsTab.Visible = true;
            AddClientDetailsTab.BringToFront();
        }

        private void InsightPicBx_Click(object sender, EventArgs e)
        {
            DashboardPanel.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ClientActionPanel.BringToFront();
        }

        private void ClientActionPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {

        }

        private void label53_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            EquipmentActionPanel.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EmployeeActionPanel.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SupplierActionPanel.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProductActionPanel.BringToFront();
        }

        private void ClientTLAPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProjectActionPanel.BringToFront();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            VehicleActionPanel.BringToFront();
        }

        private void ViewVehiclePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button54_Click(object sender, EventArgs e)
        {
            ViewVehiclePanel.BringToFront();
        }

        private void button66_Click(object sender, EventArgs e)
        {
            ViewSupplierPanel.BringToFront();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            ViewProjectPanel.BringToFront();
            ViewProjectPanel.Visible = true;
        }

        private void button45_Click(object sender, EventArgs e)
        {
            ViewProductPanel.BringToFront();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            AddProductPanel.BringToFront();
        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView13_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage18_Click(object sender, EventArgs e)
        {

        }

        private void label179_Click(object sender, EventArgs e)
        {

        }

        private void tabPage25_Click(object sender, EventArgs e)
        {

        }

        private void ViewClientAPBtn_Click(object sender, EventArgs e)
        {
            ViewClientPanel.BringToFront();
            ViewClientPanel.Visible = true;
        }

        private void ViewClientTypeAPBtn_Click(object sender, EventArgs e)
        {
            ViewClientTypePanel.BringToFront();
        }

        private void AddClienTypetAPBtn_Click(object sender, EventArgs e)
        {
            Form AO = new AddOrganisationTypePage();
            AO.ShowDialog();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {

        }

        private void button108_Click(object sender, EventArgs e)
        {
            //clientupdatelogindetailstab.bringtofront();
            Form U = new UpdateClientLoginDetailsPage();
            U.ShowDialog();
        }

        private void button109_Click(object sender, EventArgs e)
        {
            UpdatePersonalDetailsPanel.BringToFront();
        }

        private void button65_Click(object sender, EventArgs e)
        {
            AddSupplierPanel.BringToFront();
        }

        private void button58_Click(object sender, EventArgs e)
        {

        }

        private void button59_Click(object sender, EventArgs e)
        {
            ViewJobPanel.BringToFront();
        }

        private void button60_Click(object sender, EventArgs e)
        {
            Form JT = new AddJobTypePage();
            JT.ShowDialog();
        }

        private void button61_Click(object sender, EventArgs e)
        {
            ViewJobTypePanel.BringToFront();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            AddEmployeeDetailsTab.BringToFront();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            ViewEmployeePanel.BringToFront();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Form ET = new AddEmployeeTypePage();
            ET.ShowDialog();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            ViewEmployeeTypePanel.BringToFront();
        }

        private void button129_Click(object sender, EventArgs e)
        {
            AddSkillTab.BringToFront();
        }

        private void button130_Click(object sender, EventArgs e)
        {
            ViewSkillPanel.BringToFront();
        }

        private void button127_Click(object sender, EventArgs e)
        {
            SkillActionPanel.BringToFront();
        }

        private void tabPage26_Click(object sender, EventArgs e)
        {

        }

        private void button181_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Product already exists on the system. Would you like to increase it's quantity?");
        }

        private void button63_Click(object sender, EventArgs e)
        {

        }

        private void button64_Click(object sender, EventArgs e)
        {
            ViewPurchaseOrder.BringToFront();
        }

        private void button68_Click(object sender, EventArgs e)
        {

        }

        private void button38_Click(object sender, EventArgs e)
        {
            AddProjectPanel.BringToFront();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            InitiateProjectPanel.BringToFront();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            ViewProjectRequestPanel.BringToFront();
        }

        private void button42_Click(object sender, EventArgs e)
        {

        }

        private void button46_Click(object sender, EventArgs e)
        {
            Form APT = new AddProductTypePage();
            APT.ShowDialog();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            AddEquipmentTab.BringToFront();
        }

        private void button49_Click(object sender, EventArgs e)
        {
            ViewEquipmentPanel.BringToFront();
        }

        private void button50_Click(object sender, EventArgs e)
        {
            Form EQ = new AddEquipmentTypePage();
            EQ.ShowDialog();
        }

        private void button74_Click(object sender, EventArgs e)
        {
            //Form A = new DeleteClientPage();
            //this.Hide();
            //A.ShowDialog();
            //this.Show();
            UpdatePersonalDetailsPanel.BringToFront();
        }

        private void button72_Click(object sender, EventArgs e)
        {
            Form A = new ViewClientLoginPage();
            this.Hide();
            A.ShowDialog();
            this.Show();
        }

        private void button113_Click(object sender, EventArgs e)
        {
            Form A = new DeleteClientTypePage();
            this.Hide();
            A.ShowDialog();
            this.Show();
        }

        private void button114_Click(object sender, EventArgs e)
        {
            Form A = new UpdateClientTypePage();
            this.Hide();
            A.ShowDialog();
            this.Show();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Form A = new DeleteEmployeePage();
            this.Hide();
            A.ShowDialog();
            this.Show();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Form A = new UpdateEmployeeDetailsPage();
            this.Hide();
            A.ShowDialog();
            this.Show();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Form A = new ViewEmployeeLoginPage();
            this.Hide();
            A.ShowDialog();
            this.Show();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Form A = new ViewEmployeeSchedulePage();
            this.Hide();
            A.ShowDialog();
            this.Show();
        }

        private void button125_Click(object sender, EventArgs e)
        {
            //Form A = new ();
            //this.Hide();
            //A.ShowDialog();
            //this.Show();
        }

        private void button126_Click(object sender, EventArgs e)
        {
            Form A = new UpdateEmployeeTypePage();
            this.Hide();
            A.ShowDialog();
            this.Show();
        }

        private void button105_Click(object sender, EventArgs e)
        {
            Form A = new UpdateEquipmentPage();
            this.Hide();
            A.ShowDialog();
            this.Show();
        }

        private void button104_Click(object sender, EventArgs e)
        {
            Form A = new DeleteEquipmentPage();
            this.Hide();
            A.ShowDialog();
            this.Show();
        }

        private void button90_Click(object sender, EventArgs e)
        {
            Form A = new UpdateJobDetailsPage();
            this.Hide();
            A.ShowDialog();
            this.Show();
        }

        private void button89_Click(object sender, EventArgs e)
        {
            Form A = new DeleteJobPage();
            this.Hide();
            A.ShowDialog();
            this.Show();
        }

        private void button165_Click(object sender, EventArgs e)
        {
            //Form A = new D();
            //this.Hide();
            //A.ShowDialog();
            //this.Show();
        }

        private void button166_Click(object sender, EventArgs e)
        {
            Form A = new UpdateJobTypePage();
            this.Hide();
            A.ShowDialog();
            this.Show();
        }

        private void button145_Click(object sender, EventArgs e)
        {
            Form A = new AddProjectPage();
            this.Hide();
            A.ShowDialog();
            this.Show();
        }

        private void button173_Click(object sender, EventArgs e)
        {
            Form A = new DeleteSupplierPage();
            this.Hide();
            A.ShowDialog();
            this.Show();
        }

        private void button174_Click(object sender, EventArgs e)
        {
            Form A = new UpdateSupplierPage();
            this.Hide();
            A.ShowDialog();
            this.Show();
        }

        private void button80_Click(object sender, EventArgs e)
        {
            Form A = new UpdateProjectPage();
            this.Hide();
            A.ShowDialog();
            this.Show();
        }

        private void button79_Click(object sender, EventArgs e)
        {
            Form A = new UpdateProjectPhasePage();
            this.Hide();
            A.ShowDialog();
            this.Show();
        }

        private void button77_Click(object sender, EventArgs e)
        {

        }

        private void button81_Click(object sender, EventArgs e)
        {

        }

        private void button156_Click(object sender, EventArgs e)
        {
            AddProjectRequestPanel.BringToFront();
        }

        private void button157_Click(object sender, EventArgs e)
        {

            Form A = new ApproveQuotationPage();
            this.Hide();
            A.ShowDialog();
            this.Show();
        }

        private void button155_Click(object sender, EventArgs e)
        {
            ViewProjectPanel.BringToFront();
        }

        private void button158_Click(object sender, EventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {

        }

        private void button138_Click(object sender, EventArgs e)
        {
            Form A = new UpdateEmployeeDetailsPage();
            this.Hide();
            A.ShowDialog();
            this.Show();
        }

        private void tabPage30_Click(object sender, EventArgs e)
        {

        }

        private void label58_Click(object sender, EventArgs e)
        {

        }

        private void button196_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to initiate this project?", "Initiate", MessageBoxButtons.YesNo);
        }

        private void button207_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Are you sure you want to approve this cancellation", "Cancellation", MessageBoxButtons.YesNo);
        }

        private void button208_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to cancel this project?", "Cancellation", MessageBoxButtons.YesNo);
        }

        private void ViewQuotationPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Userlbl_Click(object sender, EventArgs e)
        {

        }

        private void ManagerDashboardPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ViewProductPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label61_Click(object sender, EventArgs e)
        {

        }

        private void button91_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button92_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button93_Click(object sender, EventArgs e)
        {

        }

        private void button94_Click(object sender, EventArgs e)
        {

        }

        private void button95_Click(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewEmployeePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewJobPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label59_Click(object sender, EventArgs e)
        {

        }

        private void button83_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button84_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewEquipmentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label76_Click(object sender, EventArgs e)
        {

        }

        private void button102_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button103_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button106_Click(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView8_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label75_Click(object sender, EventArgs e)
        {

        }

        private void button96_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button97_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button98_Click(object sender, EventArgs e)
        {

        }

        private void button99_Click(object sender, EventArgs e)
        {

        }

        private void button100_Click(object sender, EventArgs e)
        {

        }

        private void button101_Click(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewVehicleType_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label260_Click(object sender, EventArgs e)
        {

        }

        private void button191_Click(object sender, EventArgs e)
        {

        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button192_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel30_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button193_Click(object sender, EventArgs e)
        {

        }

        private void button194_Click(object sender, EventArgs e)
        {

        }

        private void textBox55_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView18_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewClientTypePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label102_Click(object sender, EventArgs e)
        {

        }

        private void button111_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button112_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView9_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddClientTypeDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void button21_Click_1(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void label81_Click(object sender, EventArgs e)
        {

        }

        private void label91_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label99_Click(object sender, EventArgs e)
        {

        }

        private void AddVehiclePanel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage32_Click(object sender, EventArgs e)
        {

        }

        private void label253_Click(object sender, EventArgs e)
        {

        }

        private void textBox54_TextChanged(object sender, EventArgs e)
        {

        }

        private void label252_Click(object sender, EventArgs e)
        {

        }

        private void textBox53_TextChanged(object sender, EventArgs e)
        {

        }

        private void label251_Click(object sender, EventArgs e)
        {

        }

        private void textBox52_TextChanged(object sender, EventArgs e)
        {

        }

        private void label85_Click(object sender, EventArgs e)
        {

        }

        private void textBox51_TextChanged(object sender, EventArgs e)
        {

        }

        //Add Vehicle
        private void button125_Click_1(object sender, EventArgs e)
        {
            VehicleActionPanel.BringToFront();

        }

        private void button188_Click(object sender, EventArgs e)
        {
            CVRegLbl.Text = VRegTb.Text;
            CVTypeLbl.Text = VTypeCmb.Text;
            CVMakeLbl.Text = VMakeTb.Text;
            CVModelLbl.Text = VModelTb.Text;
            CVYearLbl.Text = VYearTb.Text;
            CVPDateLbl.Text = VPDateDtp.Value.Date.ToString("dd/MM/yyyy");

            AddVehiclePanel.SelectedTab = AddVehiclePanel.TabPages[1];
        }

        private void label84_Click(object sender, EventArgs e)
        {

        }

        private void label89_Click(object sender, EventArgs e)
        {

        }

        private void comboBox25_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage33_Click(object sender, EventArgs e)
        {

        }

        private void label254_Click(object sender, EventArgs e)
        {

        }

        private void label255_Click(object sender, EventArgs e)
        {

        }

        private void label256_Click(object sender, EventArgs e)
        {

        }

        private void label257_Click(object sender, EventArgs e)
        {

        }

        private void label258_Click(object sender, EventArgs e)
        {

        }

        private void label259_Click(object sender, EventArgs e)
        {

        }

        private void label243_Click(object sender, EventArgs e)
        {

        }

        private void label245_Click(object sender, EventArgs e)
        {

        }

        private void label246_Click(object sender, EventArgs e)
        {

        }

        private void label247_Click(object sender, EventArgs e)
        {

        }

        private void label248_Click(object sender, EventArgs e)
        {

        }

        private void label249_Click(object sender, EventArgs e)
        {

        }

        private void button189_Click(object sender, EventArgs e)
        {
            AddVehiclePanel.SelectedTab = AddVehiclePanel.TabPages[0];
        }

        private void button190_Click(object sender, EventArgs e)
        {
            //AddVehiclePanel.SelectedTab = AddVehiclePanel.TabPages[3];

            //Vehicle InsightVehicle = new Vehicle();
            //InsightVehicle.VehicleMake = VMakeTb.Text;
            //InsightVehicle.VehicleModel = VModelTb.Text;
            //InsightVehicle.VehicleRegistration = VRegTb.Text;
            ////InsightVehicle.VehicleYear = ((DateTime)VYearTb.Text);
            //InsightVehicle.PurchaseDate = VPDateDtp.Value.Date;

            //using (InsightEntities db = new InsightEntities())
            //{
            //    db.Vehicles.Add(InsightVehicle);
            //    db.SaveChanges();
            //}
        }

        private void tabPage34_Click(object sender, EventArgs e)
        {

        }

        private void label250_Click(object sender, EventArgs e)
        {

        }

        private void AddProductPanel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button180_Click(object sender, EventArgs e)
        {

        }

        private void label218_Click(object sender, EventArgs e)
        {

        }

        private void label219_Click(object sender, EventArgs e)
        {

        }

        private void label221_Click(object sender, EventArgs e)
        {

        }

        private void comboBox22_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox49_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage27_Click(object sender, EventArgs e)
        {

        }

        private void label214_Click(object sender, EventArgs e)
        {

        }

        private void label215_Click(object sender, EventArgs e)
        {

        }

        private void label216_Click(object sender, EventArgs e)
        {

        }

        private void button182_Click(object sender, EventArgs e)
        {

        }

        private void button183_Click(object sender, EventArgs e)
        {

        }

        private void label236_Click(object sender, EventArgs e)
        {

        }

        private void label237_Click(object sender, EventArgs e)
        {

        }

        private void label238_Click(object sender, EventArgs e)
        {

        }

        private void tabPage28_Click(object sender, EventArgs e)
        {

        }

        private void label244_Click(object sender, EventArgs e)
        {

        }

        private void ViewEmployeeTypePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label146_Click(object sender, EventArgs e)
        {

        }

        private void button123_Click(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button124_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel20_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView10_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddEquipmentTab_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage29_Click(object sender, EventArgs e)
        {

        }

        private void label233_Click(object sender, EventArgs e)
        {

        }

        private void comboBox23_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button184_Click(object sender, EventArgs e)
        {

        }

        private void button185_Click(object sender, EventArgs e)
        {

        }

        private void label217_Click(object sender, EventArgs e)
        {

        }

        private void label220_Click(object sender, EventArgs e)
        {

        }

        private void label222_Click(object sender, EventArgs e)
        {

        }

        private void comboBox21_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox50_TextChanged(object sender, EventArgs e)
        {

        }

        private void label241_Click(object sender, EventArgs e)
        {

        }

        private void label234_Click(object sender, EventArgs e)
        {

        }

        private void label235_Click(object sender, EventArgs e)
        {

        }

        private void label239_Click(object sender, EventArgs e)
        {

        }

        private void label240_Click(object sender, EventArgs e)
        {

        }

        private void label226_Click(object sender, EventArgs e)
        {

        }

        private void label227_Click(object sender, EventArgs e)
        {

        }

        private void label228_Click(object sender, EventArgs e)
        {

        }

        private void button186_Click(object sender, EventArgs e)
        {

        }

        private void button187_Click(object sender, EventArgs e)
        {

        }

        private void label229_Click(object sender, EventArgs e)
        {

        }

        private void label230_Click(object sender, EventArgs e)
        {

        }

        private void label231_Click(object sender, EventArgs e)
        {

        }

        private void tabPage31_Click(object sender, EventArgs e)
        {

        }

        private void label232_Click(object sender, EventArgs e)
        {

        }

        private void AddJobType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage20_Click(object sender, EventArgs e)
        {

        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {

        }

        private void button150_Click(object sender, EventArgs e)
        {

        }

        private void button152_Click(object sender, EventArgs e)
        {

        }

        private void label182_Click(object sender, EventArgs e)
        {

        }

        private void tabPage21_Click(object sender, EventArgs e)
        {

        }

        private void button153_Click(object sender, EventArgs e)
        {

        }

        private void button154_Click(object sender, EventArgs e)
        {

        }

        private void label183_Click(object sender, EventArgs e)
        {

        }

        private void label184_Click(object sender, EventArgs e)
        {

        }

        private void tabPage22_Click(object sender, EventArgs e)
        {

        }

        private void label185_Click(object sender, EventArgs e)
        {

        }

        private void ViewProjectRequestPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label165_Click(object sender, EventArgs e)
        {

        }

        private void button78_Click(object sender, EventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button149_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel25_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button151_Click(object sender, EventArgs e)
        {

        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView14_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdateLoginDetailsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ClientUpdateLoginDetailsTab_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label106_Click(object sender, EventArgs e)
        {

        }

        private void label107_Click(object sender, EventArgs e)
        {

        }

        private void button115_Click(object sender, EventArgs e)
        {

        }

        private void button116_Click(object sender, EventArgs e)
        {

        }

        private void label148_Click(object sender, EventArgs e)
        {

        }

        private void label149_Click(object sender, EventArgs e)
        {

        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void label103_Click(object sender, EventArgs e)
        {

        }

        private void label104_Click(object sender, EventArgs e)
        {

        }

        private void label105_Click(object sender, EventArgs e)
        {

        }

        private void label108_Click(object sender, EventArgs e)
        {

        }

        private void button117_Click(object sender, EventArgs e)
        {

        }

        private void button118_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeProfilePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel23_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button139_Click(object sender, EventArgs e)
        {

        }

        private void SkillActionPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel21_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProjectActionPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ClientProjectActionPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel26_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UpdatePersonalDetailsPanel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel14_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label123_Click(object sender, EventArgs e)
        {

        }

        private void label124_Click(object sender, EventArgs e)
        {

        }

        private void label125_Click(object sender, EventArgs e)
        {

        }

        private void label126_Click(object sender, EventArgs e)
        {

        }

        private void label127_Click(object sender, EventArgs e)
        {

        }

        private void label128_Click(object sender, EventArgs e)
        {

        }

        private void label129_Click(object sender, EventArgs e)
        {

        }

        private void label130_Click(object sender, EventArgs e)
        {

        }

        private void label131_Click(object sender, EventArgs e)
        {

        }

        private void label132_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label86_Click(object sender, EventArgs e)
        {

        }

        private void label87_Click(object sender, EventArgs e)
        {

        }

        private void label88_Click(object sender, EventArgs e)
        {

        }

        private void button71_Click(object sender, EventArgs e)
        {

        }

        private void button73_Click(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void label90_Click(object sender, EventArgs e)
        {

        }

        private void label92_Click(object sender, EventArgs e)
        {

        }

        private void label93_Click(object sender, EventArgs e)
        {

        }

        private void label94_Click(object sender, EventArgs e)
        {

        }

        private void label95_Click(object sender, EventArgs e)
        {

        }

        private void label96_Click(object sender, EventArgs e)
        {

        }

        private void label97_Click(object sender, EventArgs e)
        {

        }

        private void label98_Click(object sender, EventArgs e)
        {

        }

        private void label100_Click(object sender, EventArgs e)
        {

        }

        private void label101_Click(object sender, EventArgs e)
        {

        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void label133_Click(object sender, EventArgs e)
        {

        }

        private void label134_Click(object sender, EventArgs e)
        {

        }

        private void label135_Click(object sender, EventArgs e)
        {

        }

        private void label136_Click(object sender, EventArgs e)
        {

        }

        private void label137_Click(object sender, EventArgs e)
        {

        }

        private void label138_Click(object sender, EventArgs e)
        {

        }

        private void label139_Click(object sender, EventArgs e)
        {

        }

        private void label140_Click(object sender, EventArgs e)
        {

        }

        private void label141_Click(object sender, EventArgs e)
        {

        }

        private void label142_Click(object sender, EventArgs e)
        {

        }

        private void button107_Click(object sender, EventArgs e)
        {

        }

        private void button110_Click(object sender, EventArgs e)
        {

        }

        private void label112_Click(object sender, EventArgs e)
        {

        }

        private void label113_Click(object sender, EventArgs e)
        {

        }

        private void label114_Click(object sender, EventArgs e)
        {

        }

        private void label115_Click(object sender, EventArgs e)
        {

        }

        private void label116_Click(object sender, EventArgs e)
        {

        }

        private void label117_Click(object sender, EventArgs e)
        {

        }

        private void label118_Click(object sender, EventArgs e)
        {

        }

        private void label119_Click(object sender, EventArgs e)
        {

        }

        private void label120_Click(object sender, EventArgs e)
        {

        }

        private void label121_Click(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void label122_Click(object sender, EventArgs e)
        {

        }

        private void ViewClientPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label242_Click(object sender, EventArgs e)
        {

        }

        private void comboBox24_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label56_Click(object sender, EventArgs e)
        {

        }

        private void button69_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button70_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddEmployeeDetailsTab_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EDetails_Click_1(object sender, EventArgs e)
        {

        }

        private void label63_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            EmployeeTypelbl.Text = EmployeeTypeCbx.Text;
            EmployeeNamelbl.Text = EmployeeName.Text;
            EmployeeSurnamelbl.Text = EmployeeSurname.Text;
            EmployeeNumberlbl.Text = EmployeeNum.Text;
            EmployeeEmaillbl.Text = EmployeeEmail.Text;
            EmployeeDOBlbl.Text = EmployeeDOB.Value.Date.ToString("dd/MM/yyyy");
            EmployeeAd1lbl.Text = EmployeeAd1.Text;
            EmployeeAd2lbl.Text = EmployeeAd2.Text;
            EmployeeAd3lbl.Text = EmployeeAd3.Text;
            EmployeeCitylbl.Text = EmployeeCity.Text;
            EmployeeCountrylbl.Text = EmployeeCountry.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void EConfirmation_Click(object sender, EventArgs e)
        {

        }

        private void label52_Click(object sender, EventArgs e)
        {

        }

        private void label64_Click(object sender, EventArgs e)
        {

        }

        private void label65_Click(object sender, EventArgs e)
        {

        }

        private void label66_Click(object sender, EventArgs e)
        {

        }

        private void label67_Click(object sender, EventArgs e)
        {

        }

        private void label68_Click(object sender, EventArgs e)
        {

        }

        private void label69_Click(object sender, EventArgs e)
        {

        }

        private void label70_Click(object sender, EventArgs e)
        {

        }

        private void label71_Click(object sender, EventArgs e)
        {

        }

        private void label72_Click(object sender, EventArgs e)
        {

        }

        private void label73_Click(object sender, EventArgs e)
        {

        }

        private void label74_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void label48_Click(object sender, EventArgs e)
        {

        }

        private void label49_Click(object sender, EventArgs e)
        {

        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void label51_Click(object sender, EventArgs e)
        {

        }

        private void ESkills_Click_1(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void label55_Click(object sender, EventArgs e)
        {

        }

        private void label54_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        public IEnumerable<string> GetTagList()
        {
            using (var connection = new SqlConnection(globalClass.myConn))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.CommandText = "SELECT SkillDescription from Skill"; // update select command accordingly
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        yield return reader.GetString(reader.GetOrdinal("SkillDescription"));
                    }
                }
            }
        }

        List<string> addedskill = new List<string>();

        private void button19_Click(object sender, EventArgs e)
        {
            string employeeAddress = EmployeeAd1lbl.Text + "," + EmployeeAd2lbl.Text + "," + EmployeeAd3lbl.Text;

            Employee InsightEmployee = new Employee();
            Address InsightAddress = new Address();
            EmployeeLogin InsightEmployeeLogin = new EmployeeLogin();
            //dataGridView1.DataSource= InsightEmployee.Skills.ToList();

            //Using Employee Table
            InsightEmployee.EmployeeName = EmployeeNamelbl.Text;
            InsightEmployee.EmployeeSurname = EmployeeSurnamelbl.Text;
            InsightEmployee.EmployeeDateOfBirth = EmployeeDOB.Value.Date;
            InsightEmployee.EmployeeEmailAddress = EmployeeEmaillbl.Text;
            //InsightEmployee.EmployeeNumber = Convert.ToInt32(EmployeeNumberlbl.Text);
            InsightEmployee.EmployeeGender = EmployeeGenderCbx.Text;
            InsightEmployee.EmployeeTypeID = Convert.ToInt32(EmployeeTypeCbx.SelectedValue);

            //Using Address Table
            InsightAddress.AddressDescription = employeeAddress;
            InsightAddress.CityID = Convert.ToInt32(EmployeeCity.SelectedValue);

            //using EmployeeLogin Table

            InsightEmployeeLogin.EmployeeUsername = "tempUsername";
            InsightEmployeeLogin.EmployeePassword = "tempPassword";
            InsightEmployeeLogin.AccessLevelID = 3;

            using (InsightEntities db = new InsightEntities())
            {
                db.Addresses.Add(InsightAddress);
                db.SaveChanges();
            }

            using (InsightEntities db = new InsightEntities())
            {
                db.EmployeeLogins.Add(InsightEmployeeLogin);
                db.SaveChanges();
            }

            //new primary keys
            int addressID = InsightAddress.AddressID;
            int employeeLoginID = InsightEmployeeLogin.EmployeeLoginID;
            int employeeID = InsightEmployee.EmployeeID;

            //Table carrying all foreign keys at the bottom
            using (InsightEntities db = new InsightEntities())
            {
                InsightEmployee.AddressID = addressID;
                InsightEmployee.EmployeeLoginID = employeeLoginID;
                db.Employees.Add(InsightEmployee);
                db.SaveChanges();
            }

            //Entity Framework not putting assossiatives as classes

            var addedskill = AddedSkillList.Items.Cast<String>().ToList();

            SqlConnection conn = new SqlConnection(globalClass.myConn);
            SqlCommand insertEmployeeSkill;
            SqlCommand getSkillID;
            SqlDataReader myReader;
            int skillID = 0; //default
            //Insert skills into db
            foreach (string skillDesc in addedskill)
            {
                //  DataSet ds = new DataSet();
                #region Retrieve skill id for specific skill description
                try
                {
                    insertEmployeeSkill = new SqlCommand("Insert into EmployeeSkill(EmployeeID, SkillID) Values(@EmployeeID, @SkillID)", conn);
                    insertEmployeeSkill.Parameters.AddWithValue("@EmployeeID", employeeID);
                    getSkillID = new SqlCommand("SELECT SkillID FROM Skill WHERE SkillDescription =" + "'" + skillDesc + "'", conn);
                    conn.Open();
                    myReader = getSkillID.ExecuteReader();

                    //Getting skillId from database
                    while (myReader.Read())
                    {
                        skillID = Convert.ToInt32(myReader["SkillID"]);
                    }
                    myReader.Close();
                    #region Insert skill id with employeeId into EmployeeSkill
                    insertEmployeeSkill.Parameters.AddWithValue("@SkillID", skillID);
                    insertEmployeeSkill.ExecuteNonQuery();
                    #endregion
                    conn.Close();
                }
                catch (Exception myEx)
                {
                    MessageBox.Show("Error: " + myEx.Message);
                }
                #endregion
            }
        }

            private void MoveListBoxItems(ListBox source, ListBox destination)
            {
                ListBox.SelectedObjectCollection sourceItems = source.SelectedItems;
                foreach (var item in sourceItems)
                {
                    destination.Items.Add(item);
                }
                while (source.SelectedItems.Count > 0)
                {
                    source.Items.Remove(source.SelectedItems[0]);
                }
            }

            private void EComplete_Click(object sender, EventArgs e)
            {

            }

            private void label62_Click(object sender, EventArgs e)
            {

            }

            private void ViewProjectPanel_Paint(object sender, PaintEventArgs e)
            {

            }

            private void label57_Click(object sender, EventArgs e)
            {

            }

            private void button75_Click(object sender, EventArgs e)
            {

            }

            private void panel4_Paint(object sender, PaintEventArgs e)
            {

            }

            private void button76_Click(object sender, EventArgs e)
            {

            }

            private void tableLayoutPanel12_Paint(object sender, PaintEventArgs e)
            {

            }

            private void textBox15_TextChanged(object sender, EventArgs e)
            {

            }

            private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void ViewSupplierPanel_Paint(object sender, PaintEventArgs e)
            {

            }

            private void label204_Click(object sender, EventArgs e)
            {

            }

            private void button171_Click(object sender, EventArgs e)
            {

            }

            private void panel16_Paint(object sender, PaintEventArgs e)
            {

            }

            private void button172_Click(object sender, EventArgs e)
            {

            }

            private void tableLayoutPanel28_Paint(object sender, PaintEventArgs e)
            {

            }

            private void textBox44_TextChanged(object sender, EventArgs e)
            {

            }

            private void dataGridView16_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void AddProjectPanel_Paint(object sender, PaintEventArgs e)
            {

            }

            private void panel2_Paint_1(object sender, PaintEventArgs e)
            {

            }

            private void button144_Click(object sender, EventArgs e)
            {

            }

            private void tableLayoutPanel24_Paint(object sender, PaintEventArgs e)
            {

            }

            private void dataGridView12_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void AddClientDetailsTab_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void CDetails_Click_1(object sender, EventArgs e)
            {

            }

            private void label77_Click(object sender, EventArgs e)
            {

            }

            private void label78_Click(object sender, EventArgs e)
            {

            }

            private void label79_Click(object sender, EventArgs e)
            {

            }

            private void label80_Click(object sender, EventArgs e)
            {

            }

            private void label82_Click(object sender, EventArgs e)
            {

            }

            private void label83_Click(object sender, EventArgs e)
            {

            }

            private void button11_Click(object sender, EventArgs e)
            {

            }

            private void button8_Click_1(object sender, EventArgs e)
            {

            }

            private void textBox10_TextChanged(object sender, EventArgs e)
            {

            }

            private void textBox9_TextChanged(object sender, EventArgs e)
            {

            }

            private void textBox8_TextChanged(object sender, EventArgs e)
            {

            }

            private void textBox7_TextChanged(object sender, EventArgs e)
            {

            }

            private void textBox6_TextChanged(object sender, EventArgs e)
            {

            }

            private void textBox5_TextChanged_1(object sender, EventArgs e)
            {

            }

            private void label10_Click(object sender, EventArgs e)
            {

            }

            private void label9_Click(object sender, EventArgs e)
            {

            }

            private void label8_Click(object sender, EventArgs e)
            {

            }

            private void label7_Click(object sender, EventArgs e)
            {

            }

            private void label6_Click(object sender, EventArgs e)
            {

            }

            private void label5_Click(object sender, EventArgs e)
            {

            }

            private void label4_Click(object sender, EventArgs e)
            {

            }

            private void label3_Click(object sender, EventArgs e)
            {

            }

            private void label2_Click(object sender, EventArgs e)
            {

            }

            private void label1_Click(object sender, EventArgs e)
            {

            }

            private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
            {

            }

            private void CConfirmation_Click_1(object sender, EventArgs e)
            {

            }

            private void button12_Click(object sender, EventArgs e)
            {

            }

            private void button13_Click(object sender, EventArgs e)
            {

            }

            private void label21_Click(object sender, EventArgs e)
            {

            }

            private void label22_Click(object sender, EventArgs e)
            {

            }

            private void label23_Click(object sender, EventArgs e)
            {

            }

            private void label24_Click(object sender, EventArgs e)
            {

            }

            private void label25_Click(object sender, EventArgs e)
            {

            }

            private void label26_Click(object sender, EventArgs e)
            {

            }

            private void label27_Click(object sender, EventArgs e)
            {

            }

            private void label28_Click(object sender, EventArgs e)
            {

            }

            private void label29_Click(object sender, EventArgs e)
            {

            }

            private void label30_Click(object sender, EventArgs e)
            {

            }

            private void label11_Click(object sender, EventArgs e)
            {

            }

            private void label12_Click(object sender, EventArgs e)
            {

            }

            private void label13_Click(object sender, EventArgs e)
            {

            }

            private void label14_Click(object sender, EventArgs e)
            {

            }

            private void label15_Click(object sender, EventArgs e)
            {

            }

            private void label16_Click(object sender, EventArgs e)
            {

            }

            private void label17_Click(object sender, EventArgs e)
            {

            }

            private void label18_Click(object sender, EventArgs e)
            {

            }

            private void label19_Click(object sender, EventArgs e)
            {

            }

            private void label20_Click(object sender, EventArgs e)
            {

            }

            private void CComplete_Click_1(object sender, EventArgs e)
            {

            }

            private void label31_Click(object sender, EventArgs e)
            {

            }

            private void ViewJobTypePanel_Paint(object sender, PaintEventArgs e)
            {

            }

            private void label186_Click(object sender, EventArgs e)
            {

            }

            private void button163_Click(object sender, EventArgs e)
            {

            }

            private void panel15_Paint(object sender, PaintEventArgs e)
            {

            }

            private void button164_Click(object sender, EventArgs e)
            {

            }

            private void tableLayoutPanel27_Paint(object sender, PaintEventArgs e)
            {

            }

            private void textBox41_TextChanged(object sender, EventArgs e)
            {

            }

            private void dataGridView15_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void AddSupplierPanel_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void tabPage23_Click(object sender, EventArgs e)
            {

            }

            private void label187_Click(object sender, EventArgs e)
            {

            }

            private void label191_Click(object sender, EventArgs e)
            {

            }

            //Add Supplier Page
            private void button167_Click(object sender, EventArgs e)
            {
                SupplierActionPanel.BringToFront();
            }

            private void button168_Click(object sender, EventArgs e)
            {
                //Attribute Mismatch with Database
                CSTitleLbl.Text = STitleCmb.Text;
                CSNameLbl.Text = SNameTb.Text;
                CSCPNamelbl.Text = CPNameTb.Text;
                CSCPNumberLbl.Text = CPNumberTb.Text;
                CSCPEmailLbl.Text = CPEmailTb.Text;
                CSCPALine1Lbl.Text = CPALine1Tb.Text;
                CSCPALine2Lbl.Text = CPALine2Tb.Text;
                CSCPALine3Lbl.Text = CPALine3Tb.Text;
                CSCPACityLbl.Text = CPACityCmb.Text;
                CSCPACountryLbl.Text = CPACountryCmb.Text;
            }

            private void textBox42_TextChanged(object sender, EventArgs e)
            {

            }

            private void textBox43_TextChanged(object sender, EventArgs e)
            {

            }

            private void textBox45_TextChanged(object sender, EventArgs e)
            {

            }

            private void textBox46_TextChanged(object sender, EventArgs e)
            {

            }

            private void textBox47_TextChanged(object sender, EventArgs e)
            {

            }

            private void label194_Click(object sender, EventArgs e)
            {

            }

            private void label195_Click(object sender, EventArgs e)
            {

            }

            private void label196_Click(object sender, EventArgs e)
            {

            }

            private void label197_Click(object sender, EventArgs e)
            {

            }

            private void label198_Click(object sender, EventArgs e)
            {

            }

            private void label199_Click(object sender, EventArgs e)
            {

            }

            private void label200_Click(object sender, EventArgs e)
            {

            }

            private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void comboBox19_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void comboBox20_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void tabPage24_Click(object sender, EventArgs e)
            {

            }

            private void label188_Click(object sender, EventArgs e)
            {

            }

            private void label189_Click(object sender, EventArgs e)
            {

            }

            private void label190_Click(object sender, EventArgs e)
            {

            }

            private void label192_Click(object sender, EventArgs e)
            {

            }

            private void label193_Click(object sender, EventArgs e)
            {

            }

            private void label201_Click(object sender, EventArgs e)
            {

            }

            private void label202_Click(object sender, EventArgs e)
            {

            }

            private void label224_Click(object sender, EventArgs e)
            {

            }

            private void label225_Click(object sender, EventArgs e)
            {

            }

            private void button169_Click(object sender, EventArgs e)
            {

            }

            private void button170_Click(object sender, EventArgs e)
            {

            }

            private void label203_Click(object sender, EventArgs e)
            {

            }

            private void label205_Click(object sender, EventArgs e)
            {

            }

            private void label206_Click(object sender, EventArgs e)
            {

            }

            private void label207_Click(object sender, EventArgs e)
            {

            }

            private void label208_Click(object sender, EventArgs e)
            {

            }

            private void label209_Click(object sender, EventArgs e)
            {

            }

            private void label210_Click(object sender, EventArgs e)
            {

            }

            private void label211_Click(object sender, EventArgs e)
            {

            }

            private void label212_Click(object sender, EventArgs e)
            {

            }

            private void label223_Click(object sender, EventArgs e)
            {

            }

            private void EquipmentActionPanel_Paint(object sender, PaintEventArgs e)
            {

            }

            private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
            {

            }

            private void button51_Click(object sender, EventArgs e)
            {

            }

            private void button52_Click(object sender, EventArgs e)
            {

            }

            private void ProductActionPanel_Paint(object sender, PaintEventArgs e)
            {

            }

            private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
            {

            }

            private void button47_Click(object sender, EventArgs e)
            {

            }

            private void button48_Click(object sender, EventArgs e)
            {

            }

            private void JobActionPanel_Paint(object sender, PaintEventArgs e)
            {

            }

            private void tableLayoutPanel7_Paint(object sender, PaintEventArgs e)
            {

            }

            private void button62_Click(object sender, EventArgs e)
            {

            }

            private void SupplierActionPanel_Paint(object sender, PaintEventArgs e)
            {

            }

            private void groupBox3_Enter(object sender, EventArgs e)
            {

            }

            private void tableLayoutPanel10_Paint(object sender, PaintEventArgs e)
            {

            }

            private void button67_Click(object sender, EventArgs e)
            {

            }

            private void groupBox2_Enter(object sender, EventArgs e)
            {

            }

            private void tableLayoutPanel9_Paint(object sender, PaintEventArgs e)
            {

            }

            private void groupBox1_Enter(object sender, EventArgs e)
            {

            }

            private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
            {

            }

            private void ViewPurchaseOrder_Paint(object sender, PaintEventArgs e)
            {

            }

            private void label213_Click(object sender, EventArgs e)
            {

            }

            private void button175_Click(object sender, EventArgs e)
            {

            }

            private void panel17_Paint(object sender, PaintEventArgs e)
            {

            }

            private void button176_Click(object sender, EventArgs e)
            {

            }

            private void tableLayoutPanel29_Paint(object sender, PaintEventArgs e)
            {

            }

            private void button177_Click(object sender, EventArgs e)
            {

            }

            private void button178_Click(object sender, EventArgs e)
            {

            }

            private void button179_Click(object sender, EventArgs e)
            {

            }

            private void textBox48_TextChanged(object sender, EventArgs e)
            {

            }

            private void dataGridView17_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void AddSkillTab_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void tabPage12_Click(object sender, EventArgs e)
            {

            }

            private void textBox32_TextChanged(object sender, EventArgs e)
            {

            }

            private void button128_Click(object sender, EventArgs e)
            {

            }

            private void button131_Click(object sender, EventArgs e)
            {

            }

            private void label147_Click(object sender, EventArgs e)
            {

            }

            private void tabPage13_Click(object sender, EventArgs e)
            {

            }

            private void label153_Click(object sender, EventArgs e)
            {

            }

            private void label154_Click(object sender, EventArgs e)
            {

            }

            private void button132_Click(object sender, EventArgs e)
            {

            }

            private void button133_Click(object sender, EventArgs e)
            {

            }

            private void label150_Click(object sender, EventArgs e)
            {

            }

            private void label151_Click(object sender, EventArgs e)
            {

            }

            private void tabPage14_Click(object sender, EventArgs e)
            {

            }

            private void label152_Click(object sender, EventArgs e)
            {

            }

            private void DuplicateViewSupplierPanel_Paint(object sender, PaintEventArgs e)
            {

            }

            private void label60_Click(object sender, EventArgs e)
            {

            }

            private void button85_Click(object sender, EventArgs e)
            {

            }

            private void panel6_Paint(object sender, PaintEventArgs e)
            {

            }

            private void button86_Click(object sender, EventArgs e)
            {

            }

            private void tableLayoutPanel14_Paint(object sender, PaintEventArgs e)
            {

            }

            private void button87_Click(object sender, EventArgs e)
            {

            }

            private void button88_Click(object sender, EventArgs e)
            {

            }

            private void textBox17_TextChanged(object sender, EventArgs e)
            {

            }

            private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void EmployeeActionPanel_Paint(object sender, PaintEventArgs e)
            {

            }

            private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
            {

            }

            private void button32_Click(object sender, EventArgs e)
            {

            }

            private void ProfileActionPanel_Paint(object sender, PaintEventArgs e)
            {

            }

            private void tableLayoutPanel18_Paint(object sender, PaintEventArgs e)
            {

            }

            private void AddProjectRequestPanel_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void tabPage17_Click(object sender, EventArgs e)
            {

            }

            private void label171_Click(object sender, EventArgs e)
            {

            }

            private void label172_Click(object sender, EventArgs e)
            {

            }

            private void label173_Click(object sender, EventArgs e)
            {

            }

            private void comboBox14_SelectedIndexChanged_1(object sender, EventArgs e)
            {

            }

            private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void textBox39_TextChanged(object sender, EventArgs e)
            {

            }

            private void label170_Click(object sender, EventArgs e)
            {

            }

            private void textBox38_TextChanged(object sender, EventArgs e)
            {

            }

            private void button159_Click(object sender, EventArgs e)
            {

            }

            private void button160_Click(object sender, EventArgs e)
            {

            }

            private void label166_Click(object sender, EventArgs e)
            {

            }

            private void label177_Click(object sender, EventArgs e)
            {

            }

            private void label178_Click(object sender, EventArgs e)
            {

            }

            private void label180_Click(object sender, EventArgs e)
            {

            }

            private void label181_Click(object sender, EventArgs e)
            {

            }

            private void label167_Click(object sender, EventArgs e)
            {

            }

            private void label168_Click(object sender, EventArgs e)
            {

            }

            private void label174_Click(object sender, EventArgs e)
            {

            }

            private void label175_Click(object sender, EventArgs e)
            {

            }

            private void label176_Click(object sender, EventArgs e)
            {

            }

            private void button161_Click(object sender, EventArgs e)
            {

            }

            private void button162_Click(object sender, EventArgs e)
            {

            }

            private void tabPage19_Click(object sender, EventArgs e)
            {

            }

            private void label169_Click(object sender, EventArgs e)
            {

            }

            private void AddEmployeeTypeTab_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void tabPage9_Click(object sender, EventArgs e)
            {

            }

            private void textBox30_TextChanged(object sender, EventArgs e)
            {

            }

            private void button119_Click(object sender, EventArgs e)
            {

            }

            private void button120_Click(object sender, EventArgs e)
            {

            }

            private void label109_Click(object sender, EventArgs e)
            {

            }

            private void tabPage10_Click(object sender, EventArgs e)
            {

            }

            private void label144_Click(object sender, EventArgs e)
            {

            }

            private void label145_Click(object sender, EventArgs e)
            {

            }

            private void button121_Click(object sender, EventArgs e)
            {

            }

            private void button122_Click(object sender, EventArgs e)
            {

            }

            private void label110_Click(object sender, EventArgs e)
            {

            }

            private void label111_Click(object sender, EventArgs e)
            {

            }

            private void tabPage11_Click(object sender, EventArgs e)
            {

            }

            private void label143_Click(object sender, EventArgs e)
            {

            }

            private void InitiateProjectPanel_Paint(object sender, PaintEventArgs e)
            {

            }

            private void button148_Click(object sender, EventArgs e)
            {

            }

            private void label164_Click(object sender, EventArgs e)
            {

            }

            private void button146_Click(object sender, EventArgs e)
            {

            }

            private void textBox36_TextChanged(object sender, EventArgs e)
            {

            }

            private void dataGridView13_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void EmployeeUpdateLoginPage_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void tabPage15_Click(object sender, EventArgs e)
            {

            }

            private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {

            }

            private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {

            }

            private void label156_Click(object sender, EventArgs e)
            {

            }

            private void label157_Click(object sender, EventArgs e)
            {

            }

            private void button140_Click(object sender, EventArgs e)
            {

            }

            private void button141_Click(object sender, EventArgs e)
            {

            }

            private void label158_Click(object sender, EventArgs e)
            {

            }

            private void label159_Click(object sender, EventArgs e)
            {

            }

            private void textBox34_TextChanged(object sender, EventArgs e)
            {

            }

            private void textBox35_TextChanged(object sender, EventArgs e)
            {

            }

            private void tabPage16_Click(object sender, EventArgs e)
            {

            }

            private void label160_Click(object sender, EventArgs e)
            {

            }

            private void label161_Click(object sender, EventArgs e)
            {

            }

            private void label162_Click(object sender, EventArgs e)
            {

            }

            private void label163_Click(object sender, EventArgs e)
            {

            }

            private void button142_Click(object sender, EventArgs e)
            {

            }

            private void button143_Click(object sender, EventArgs e)
            {

            }

            private void ViewSkillPanel_Paint(object sender, PaintEventArgs e)
            {

            }

            private void label155_Click(object sender, EventArgs e)
            {

            }

            private void button134_Click(object sender, EventArgs e)
            {

            }

            private void panel12_Paint(object sender, PaintEventArgs e)
            {

            }

            private void button135_Click(object sender, EventArgs e)
            {

            }

            private void tableLayoutPanel22_Paint(object sender, PaintEventArgs e)
            {

            }

            private void button136_Click(object sender, EventArgs e)
            {

            }

            private void button137_Click(object sender, EventArgs e)
            {

            }

            private void textBox33_TextChanged(object sender, EventArgs e)
            {

            }

            private void dataGridView11_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void VehicleActionPanel_Paint(object sender, PaintEventArgs e)
            {

            }

            private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
            {

            }

            private void button53_Click(object sender, EventArgs e)
            {
                AddVehiclePanel.BringToFront();
            }

            private void button55_Click(object sender, EventArgs e)
            {
                Form VT = new AddVehicleTypePage();
                VT.ShowDialog();
            }

            private void button56_Click(object sender, EventArgs e)
            {

            }

            private void button57_Click(object sender, EventArgs e)
            {

            }

            private void DashboardPanel_Paint(object sender, PaintEventArgs e)
            {

            }

            private void panel13_Paint(object sender, PaintEventArgs e)
            {

            }

            private void button195_Click(object sender, EventArgs e)
            {

            }

            private void tableLayoutPanel31_Paint(object sender, PaintEventArgs e)
            {

            }

            private void ClientQoutationApprovalPanel_Paint(object sender, PaintEventArgs e)
            {

            }

            private void label261_Click(object sender, EventArgs e)
            {

            }

            private void button147_Click(object sender, EventArgs e)
            {

            }

            private void panel20_Paint(object sender, PaintEventArgs e)
            {

            }

            private void button197_Click(object sender, EventArgs e)
            {

            }

            private void tableLayoutPanel32_Paint(object sender, PaintEventArgs e)
            {

            }

            private void button198_Click(object sender, EventArgs e)
            {

            }

            private void textBox56_TextChanged(object sender, EventArgs e)
            {

            }

            private void dataGridView19_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void button199_Click(object sender, EventArgs e)
            {

            }

            private void pictureBox6_Click(object sender, EventArgs e)
            {

            }

            private void pictureBox3_Click(object sender, EventArgs e)
            {

            }

            private void pictureBox12_Click(object sender, EventArgs e)
            {

            }

            private void pictureBox10_Click(object sender, EventArgs e)
            {

            }

            private void pictureBox11_Click(object sender, EventArgs e)
            {

            }

            private void pictureBox8_Click(object sender, EventArgs e)
            {

            }

            private void pictureBox4_Click(object sender, EventArgs e)
            {

            }

            private void pictureBox2_Click_1(object sender, EventArgs e)
            {

            }

            private void pictureBox1_Click_1(object sender, EventArgs e)
            {

            }

            private void pictureBox9_Click(object sender, EventArgs e)
            {

            }

            private void pictureBox7_Click(object sender, EventArgs e)
            {

            }

            private void pictureBox5_Click(object sender, EventArgs e)
            {

            }

            private void label262_Click(object sender, EventArgs e)
            {

            }

            private void button200_Click(object sender, EventArgs e)
            {

            }

            private void panel21_Paint(object sender, PaintEventArgs e)
            {

            }

            private void button201_Click(object sender, EventArgs e)
            {

            }

            private void tableLayoutPanel33_Paint(object sender, PaintEventArgs e)
            {

            }

            private void button202_Click(object sender, EventArgs e)
            {

            }

            private void button203_Click(object sender, EventArgs e)
            {

            }

            private void textBox57_TextChanged(object sender, EventArgs e)
            {

            }

            private void dataGridView20_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void button82_Click(object sender, EventArgs e)
            {

            }

            private void ProjectCancellationPanel_Paint(object sender, PaintEventArgs e)
            {

            }

            private void label263_Click(object sender, EventArgs e)
            {

            }

            private void button204_Click(object sender, EventArgs e)
            {

            }

            private void panel22_Paint(object sender, PaintEventArgs e)
            {

            }

            private void button205_Click(object sender, EventArgs e)
            {

            }

            private void tableLayoutPanel34_Paint(object sender, PaintEventArgs e)
            {

            }

            private void button206_Click(object sender, EventArgs e)
            {

            }

            private void textBox58_TextChanged(object sender, EventArgs e)
            {

            }

            private void dataGridView21_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void panel2_Paint_2(object sender, PaintEventArgs e)
            {

            }

            private void button145_Click_1(object sender, EventArgs e)
            {
                Form m = new AddProjectPage();
                m.ShowDialog();
                this.Hide();
            }

            private void pictureBox14_Click(object sender, EventArgs e)
            {

                this.WindowState = FormWindowState.Maximized;
            }

            private void dataGridView12_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void groupBox5_Enter(object sender, EventArgs e)
            {

            }

            private void button116_Click_1(object sender, EventArgs e)
            {

            }

            private void button115_Click_1(object sender, EventArgs e)
            {

            }

            private void button145_Click_2(object sender, EventArgs e)
            {
                Form APP = new AddProjectPage();
                this.Hide();
                APP.ShowDialog();
                this.Show();
            }

            private void button144_Click_1(object sender, EventArgs e)
            {
                ProjectActionPanel.BringToFront();
            }

            private void button20_Click_1(object sender, EventArgs e)
            {
                MoveListBoxItems(SkillList, AddedSkillList);
            }

            private void button21_Click_2(object sender, EventArgs e)
            {
                MoveListBoxItems(AddedSkillList, SkillList);
            }
        }
    }
