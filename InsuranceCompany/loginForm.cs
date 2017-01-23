using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsuranceCompany
{
    public partial class loginForm : Form
    {
        SqlConnection connection;
        string connectionString;
        mainForm form;

        public loginForm()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["InsuranceCompany.Properties.Settings.InsuranceCompanyConnectionString"].ConnectionString;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string query = "Select * from Users where UserLogin='" + usernameBox.Text + "' and UserPassword='" + passwordBox.Text + "'";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                SqlDataReader reader;
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string userType = reader["UserRole"].ToString();
                    userType = userType.TrimEnd(" ".ToCharArray());
                    form = new mainForm(userType);
                    form.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Username or password are incorrect", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connection.Close();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            form = new mainForm("public");
            form.Show();
            Close();
        }
    }
}
