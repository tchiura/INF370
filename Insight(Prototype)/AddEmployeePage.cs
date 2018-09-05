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
using System.Security.Cryptography;

namespace Insight_Prototype_
{
    public partial class AddEmployeePage : Form
    {
        public AddEmployeePage()
        {
            InitializeComponent();
        }

        Globals globalClass = new Globals();
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

        private void AddEmployeePage_Load(object sender, EventArgs e)
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

            private void button20_Click(object sender, EventArgs e)
        {
            MoveListBoxItems(SkillList, AddedSkillList);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            MoveListBoxItems(AddedSkillList, SkillList);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(globalClass.myConn);
            SqlDataReader myReader;
            bool duplicate = false;
            String username = Char.ToUpper(EmployeeNamelbl.Text[0]) + "." + EmployeeSurnamelbl.Text;
            #region Check if user exists
            try
            {
                SqlCommand checkUser = new SqlCommand("SELECT EmployeeUsername FROM EmployeeLogin WHERE EmployeeUsername =" + "'" + username + "'", conn);
                conn.Open();
                myReader = checkUser.ExecuteReader();

                if (myReader.HasRows)
                {
                    duplicate = true;
                }
            
                myReader.Close();
                conn.Close();
            }
            catch (Exception myEx)
            {
                MessageBox.Show("Error: " + myEx.Message);
            }
            #endregion 

            //Proceed if user does not exist yet
            if (duplicate)
            {
                #region Adding employee details into database
                string employeeAddress = EmployeeAd1lbl.Text + "," + EmployeeAd2lbl.Text + "," + EmployeeAd3lbl.Text;

                Employee InsightEmployee = new Employee();
                Address InsightAddress = new Address();
                EmployeeLogin InsightEmployeeLogin = new EmployeeLogin();

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
                InsightEmployeeLogin.EmployeeUsername = username;
                #endregion

                #region Hashing and storing the password
                string pass = username + "#123";

                //Generate hash
                HashAlgorithm hashFunc = SHA256.Create();
                byte[] hold = hashFunc.ComputeHash(Encoding.UTF8.GetBytes(pass));

                //Get hash string
                StringBuilder hashString = new StringBuilder();
                foreach (byte b in hold)
                {
                    hashString.Append(b.ToString("X2"));
                }
                //Store hash string in database
                InsightEmployeeLogin.EmployeePassword = hashString.ToString();
                InsightEmployeeLogin.AccessLevelID = 3;
                #endregion

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

                SqlCommand insertEmployeeSkill;
                SqlCommand getSkillID;
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
            else
            {
                MessageBox.Show("User already exists. Please try again.");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {

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
    }
}
