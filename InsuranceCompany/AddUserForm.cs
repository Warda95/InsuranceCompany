using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InsuranceCompany
{
    public partial class AddUserForm : Form
    {
        mainForm form = new mainForm();
        SqlConnection connection;
        string connectionString;

        public AddUserForm()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["InsuranceCompany.Properties.Settings.InsuranceCompanyConnectionString"].ConnectionString;
        }
        
        private void okButton_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToShortDateString();
            string query = string.Format("INSERT INTO {0} VALUES (@Name, @SecondName, @Birthdate, @MaritalStatus, @Job)", mainForm.tableName);

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@Name", nameBox.Text);
                command.Parameters.AddWithValue("@SecondName", secondNameBox.Text);
                command.Parameters.AddWithValue("@Birthdate", birthDatePicker.Value.ToShortDateString());
                command.Parameters.AddWithValue("@MaritalStatus", maritalStatusBox.Text);
                command.Parameters.AddWithValue("@Job", jobBox.Text);

                if (nameBox.Text == "" | secondNameBox.Text == "" | maritalStatusBox.Text == "" | jobBox.Text == "")
                    MessageBox.Show("You need to insert all the values");
                else
                    command.ExecuteNonQuery();
            }
            if (nameBox.Text != "" & secondNameBox.Text != "" & maritalStatusBox.Text != "" & jobBox.Text != "")
                Close();
        }
    }
}
