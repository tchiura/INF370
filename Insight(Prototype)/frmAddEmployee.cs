using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Insight_Prototype_
{
    public partial class frmAddEmployee : Form
    {
        public frmAddEmployee()
        {
            InitializeComponent();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Globals myglobalclass = new Globals();
            SqlConnection conn = new SqlConnection(myglobalclass.myConn);
            SqlDataReader myReader;
            #region Check if user exists
            bool duplicate = false;
            int num = 2;
            SqlCommand checkUser;
            String username = Char.ToUpper(EmployeeNamelbl.Text[0]) + "." + EmployeeSurnamelbl.Text;
            while(duplicate)
            {
                try
                {
                    checkUser = new SqlCommand("SELECT EmployeeUsername FROM EmployeeLogin WHERE EmployeeUsername =" + "'" + username + "'", conn);
                    conn.Open();
                    myReader = checkUser.ExecuteReader();

                    if (myReader.HasRows)
                    {
                        duplicate = true;
                        //If duplicate, add identifier to name
                        username = Char.ToUpper(EmployeeNamelbl.Text[0]) + "." + EmployeeSurnamelbl.Text + num.ToString();
                        num++;
                    }
                    else
                    {
                        duplicate = false;
                    }
                    myReader.Close();
                    conn.Close();
                }
                catch (Exception myEx)
                {
                    MessageBox.Show("Error: " + myEx.Message);
                }
            }
            #endregion

            #region Adding employee details into database
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
    }
}
