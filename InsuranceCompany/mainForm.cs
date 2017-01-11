using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace InsuranceCompany
{
    public partial class mainForm : Form
    {
        public static string tableName = "Customer";
        SqlConnection connection;
        string connectionString;
        AddUserForm form;

        public mainForm()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["InsuranceCompany.Properties.Settings.InsuranceCompanyConnectionString"].ConnectionString;            
        }

        private void appBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            Categories();
            Apps();
            FillingGrid(tableName);
        }

        private void listApps_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Apps()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM App", connection))
            {
                DataTable appTable = new DataTable();
                BindingSource bindingSource = new BindingSource();

                adapter.Fill(appTable);
                bindingSource.DataSource = appTable;
                dgvApp.AutoResizeColumns(
                DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                dgvApp.DataSource = bindingSource;

                listApps.ValueMember = "CustomerID";
                listApps.DisplayMember = "Date";
                listApps.DisplayMember = "Name";
                listApps.ValueMember = "ID";
                listApps.DataSource = appTable;
            }            
        }
        private void Categories()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Category", connection))
            {
                DataTable appTable = new DataTable();
                BindingSource bindingSource = new BindingSource();
                
                adapter.Fill(appTable);
                bindingSource.DataSource = appTable;
                dgvCategory.AutoResizeColumns(
                DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                dgvCategory.DataSource = bindingSource;
                
                listCategory.DisplayMember = "Type";
                listCategory.ValueMember = "ID";
                listCategory.DataSource = appTable;
            }
        }
        
        public void FillingGrid(string tableName)
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(string.Format("SELECT * FROM {0}", tableName), connection))
            {
                DataTable appTable = new DataTable();
                BindingSource bindingSource = new BindingSource();

                adapter.Fill(appTable);
                bindingSource.DataSource = appTable;
                dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                dgv.DataSource = bindingSource;
            }
        }

        //private void AddButton_Click(object sender, EventArgs e)
        //{
        //    string date = DateTime.Now.ToShortDateString();
        //    string query = string.Format("INSERT INTO {0} VALUES (@Name, @SecondName, @Birthdate, @MaritalStatus, @Job)", tableName);

        //    using (connection = new SqlConnection(connectionString))
        //    using (SqlCommand command = new SqlCommand(query, connection))
        //    {
        //        connection.Open();

        //        command.Parameters.AddWithValue("@Name", "06-Jan-17");
        //        command.Parameters.AddWithValue("@SecondName", "06-Jan-17");
        //        command.Parameters.AddWithValue("@Birthdate", "06-Jan-17");
        //        command.Parameters.AddWithValue("@MaritalStatus", "06-Jan-17");
        //        command.Parameters.AddWithValue("@Job", "06-Jan-17");

        //        command.ExecuteNonQuery();
        //    }
        //    FillingGrid(tableName);
        //}

        private void AddButton_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToShortDateString();
            string query = "INSERT INTO Category VALUES (@Type, @Subtype)";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@Type", textAddType.Text);
                command.Parameters.AddWithValue("@Subtype", textAddSubtype.Text);

                command.ExecuteNonQuery();
            }
            Categories();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToShortDateString();
            string query = "UPDATE Category SET Type = @CategoryType WHERE Id = @CategoryID";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@CategoryType", textAddType.Text);
                command.Parameters.AddWithValue("@CategoryID", listCategory.SelectedValue);

                command.ExecuteNonQuery();
            }
            Categories();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form = new AddUserForm();
            form.Visible = true;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            FillingGrid(tableName);
        }
    }
}
