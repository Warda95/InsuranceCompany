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

        public addUserForm(string inUserType)
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["InsuranceCompany.Properties.Settings.InsuranceCompanyConnectionString"].ConnectionString;
            userType = inUserType;
        }
        
        private void okButton_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToShortDateString();
            string query = string.Format("INSERT INTO {0} VALUES (@UserLogin, @UserPassword, @UserRole, @UserFirstName, @UserLastName, @UserBirthdate, @UserMaritalStatus, @UserJob)", mainForm.tableName);

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                try
                {
                    command.Parameters.AddWithValue("@UserLogin", usernameBox.Text);
                    command.Parameters.AddWithValue("@UserPassword", passwordBox.Text);
                    command.Parameters.AddWithValue("@UserRole", "client");
                    command.Parameters.AddWithValue("@UserFirstName", nameBox.Text);
                    command.Parameters.AddWithValue("@UserLastName", secondNameBox.Text);
                    command.Parameters.AddWithValue("@UserBirthdate", birthDatePicker.Value.ToShortDateString());
                    command.Parameters.AddWithValue("@UserMaritalStatus", maritalStatusBox.Text);
                    command.Parameters.AddWithValue("@UserJob", jobBox.Text);
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
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }                    
            }
            if (usernameBox.Text == "" || passwordBox.Text == "" || nameBox.Text == "" || secondNameBox.Text == "" ||
                maritalStatusBox.Text == "" || jobBox.Text == "")
                Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            form = new mainForm(userType, "");
            form.Show();
            Close();
        }
    }
}
