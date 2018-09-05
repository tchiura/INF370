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
using System;

namespace Insight_Prototype_
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Globals myglobalclass = new Globals();
            bool validLogin = false;
            bool validUsername = false;

            SqlConnection conn = new SqlConnection(myglobalclass.myConn);
            SqlDataReader myReader;

            #region Checking if user exists first. If correct, check if password is correct
            try
            {
                SqlCommand checkUser = new SqlCommand("SELECT EmployeeUsername FROM EmployeeLogin WHERE EmployeeUsername =" + "'" + textBox1.Text + "'", conn);
                conn.Open();
                myReader = checkUser.ExecuteReader();

                if (myReader.HasRows)
                    validUsername = true;
                myReader.Close();
                conn.Close();
            }
            catch (Exception myEx)
            {
                MessageBox.Show("Error: " + myEx.Message);
            }
            #endregion
            #region Check if password is correct
            if (validUsername)
            {
                //Hash password and check for match in database
                string pass = textBox2.Text;

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
                try
                {
                    SqlCommand checkUser = new SqlCommand("SELECT EmployeePassword FROM EmployeeLogin WHERE EmployeeUsername ='" + textBox1.Text + "' AND EmployeePassword ='" + hashString.ToString() + "'", conn);
                    conn.Open();
                    myReader = checkUser.ExecuteReader();

                    if (myReader.HasRows)
                        validLogin = true;
                    myReader.Close();
                    conn.Close();
                }
                catch (Exception myEx)
                {
                    MessageBox.Show("Error: " + myEx.Message);
                }
            }
            #endregion

            if (validLogin)
            {
                Form f2 = new HomeScreen();
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid login details. Please try again.");
            }
        }
    }
}
