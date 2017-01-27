using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InsuranceCompany
{
    public partial class addUserForm : Form
    {
        mainForm form;
        SqlConnection connection;
        string connectionString;
        string userType;
        string createUserType;

        public addUserForm(string inUserType, string increateUserType)
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["InsuranceCompany.Properties.Settings.InsuranceCompanyConnectionString"].ConnectionString;
            userType = inUserType;
            createUserType = increateUserType;
        }
        
        private void okButton_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToShortDateString();
            string query = "INSERT INTO Users VALUES (@UserLogin, @UserPassword, @UserFirstName, @UserLastName, @UserBirthdate, @UserMaritalStatus, @UserJob, @UserRole)";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                try
                {
                    command.Parameters.AddWithValue("@UserLogin", usernameBox.Text);
                    command.Parameters.AddWithValue("@UserPassword", passwordBox.Text);
                    command.Parameters.AddWithValue("@UserFirstName", nameBox.Text);
                    command.Parameters.AddWithValue("@UserLastName", secondNameBox.Text);
                    command.Parameters.AddWithValue("@UserBirthdate", birthDatePicker.Value.ToShortDateString());
                    command.Parameters.AddWithValue("@UserMaritalStatus", maritalStatusBox.Text);
                    command.Parameters.AddWithValue("@UserJob", jobBox.Text);
                    command.Parameters.AddWithValue("@UserRole", createUserType);
                }
                catch (Exception)
                {

                }

                if (usernameBox.Text == "" || passwordBox.Text == "" || nameBox.Text == "" || secondNameBox.Text == "" ||
                    maritalStatusBox.Text == "" || jobBox.Text == "")
                    MessageBox.Show("You need to insert all the values");
                else
                {
                    try
                    {
                        command.ExecuteNonQuery();
                        Close();
                        if (createUserType == "client")
                        {
                            form = new mainForm("public", "");
                            mainForm.tableName = "Category";
                            form.Show();
                        }
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            form = new mainForm(userType, "");
            form.Show();
            Close();
        }
    }
}
