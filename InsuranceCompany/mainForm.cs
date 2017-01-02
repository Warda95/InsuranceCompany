using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace InsuranceCompany
{
    public partial class mainForm : Form
    {
        SqlConnection connection;
        string connectionString;

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
            TypicalCategories();
            TypicalApps();
        }

        private void listApps_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TypicalApps()
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
        private void TypicalCategories()
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
            TypicalCategories();
        }

        private void button1_Click(object sender, EventArgs e)
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
            TypicalCategories();
        }
    }
}
