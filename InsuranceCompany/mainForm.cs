using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace InsuranceCompany
{
    public partial class mainForm : Form
    {
        public static string tableName = "Users";
        SqlConnection connection;
        string connectionString;
        addUserForm form1;
        loginForm form2;
        //string userType = "public";

        public mainForm(string userType)
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["InsuranceCompany.Properties.Settings.InsuranceCompanyConnectionString"].ConnectionString;

            //string query;

            if (userType == "admin")
            {
                Console.WriteLine("pierwszy if");
                AddButton.Enabled = true;
                UpdateButton.Enabled = true;
                ShowButton.Enabled = true;
                applicationToolStripMenuItem.Enabled = true;
                applicationCriteriaDependenceToolStripMenuItem.Enabled = true;
                attributeToolStripMenuItem.Enabled = true;
                attributeValuesToolStripMenuItem.Enabled = true;
                categoryAttributeDependenceToolStripMenuItem.Enabled = true;
                categoryCriterionDepenceToolStripMenuItem.Enabled = true;
                compensationToolStripMenuItem.Enabled = true;
                criterionToolStripMenuItem.Enabled = true;
                criterionValuesToolStripMenuItem.Enabled = true;
                damageToolStripMenuItem.Enabled = true;
                policyToolStripMenuItem.Enabled = true;
                policyTypeToolStripMenuItem.Enabled = true;
                rateToolStripMenuItem.Enabled = true;
                usersToolStripMenuItem.Enabled = true;
                //query = "GRANT ALL PRIVILEGES TO USER";
            }
            else if (userType == "public")
            {
                Console.WriteLine("drugi if");
                AddButton.Enabled = false;
                UpdateButton.Enabled = false;
                ShowButton.Enabled = false;
                applicationToolStripMenuItem.Enabled = false;
                applicationCriteriaDependenceToolStripMenuItem.Enabled = false;
                attributeToolStripMenuItem.Enabled = false;
                attributeValuesToolStripMenuItem.Enabled = false;
                categoryAttributeDependenceToolStripMenuItem.Enabled = false;
                categoryCriterionDepenceToolStripMenuItem.Enabled = false;
                compensationToolStripMenuItem.Enabled = false;
                criterionToolStripMenuItem.Enabled = false;
                criterionValuesToolStripMenuItem.Enabled = false;
                damageToolStripMenuItem.Enabled = false;
                policyToolStripMenuItem.Enabled = false;
                policyTypeToolStripMenuItem.Enabled = false;
                rateToolStripMenuItem.Enabled = false;
                usersToolStripMenuItem.Enabled = false;
                //query = "REVOKE ALL PRIVILEGES FROM USER";
            }
            else Console.WriteLine("Jeb sie");

            //using (connection = new SqlConnection(connectionString))
            //using (SqlCommand command = new SqlCommand(query, connection))
            //{
            //    connection.Open();
            //    command.ExecuteNonQuery();
            //}
        }
        
        private void mainForm_Load(object sender, EventArgs e)
        {
            Categories();
            Apps();
            FillingGrid(tableName);
        }
        
        private void Apps()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Application", connection))
            {
                DataTable appTable = new DataTable();
                BindingSource bindingSource = new BindingSource();

                adapter.Fill(appTable);
                bindingSource.DataSource = appTable;
                //dgvApp.AutoResizeColumns(
                //DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                //dgvApp.DataSource = bindingSource;

                //listApps.ValueMember = "CustomerID";
                //listApps.DisplayMember = "ApplicationDate";
                //listApps.DisplayMember = "ApplicationName";
                //listApps.ValueMember = "ID";
                //listApps.DataSource = appTable;
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
                //dgvCategory.AutoResizeColumns(
                //DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                //dgvCategory.DataSource = bindingSource;
                
                //listCategory.DisplayMember = "CategoryType";
                //listCategory.ValueMember = "ID";
                //listCategory.DataSource = appTable;
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
                //dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                int i = 0;
                foreach (DataGridViewColumn c in dgv.Columns)
                {
                    i += c.Width;
                }
                dgv.Width = i + dgv.RowHeadersWidth + 2;
                //dgv.Height = dgv.GetRowDisplayRectangle(dgv.NewRowIndex, true).Bottom + dgv.GetRowDisplayRectangle(dgv.NewRowIndex, false).Height;
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
            string query = "INSERT INTO Category VALUES (@CategoryType, @CategorySubtype)";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                //connection.Open();

                //command.Parameters.AddWithValue("@CategoryType", textAddType.Text);
                //command.Parameters.AddWithValue("@CategorySubtype", textAddSubtype.Text);

                //command.ExecuteNonQuery();
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
                //connection.Open();

                //command.Parameters.AddWithValue("@CategoryType", textAddType.Text);
                //command.Parameters.AddWithValue("@CategoryID", listCategory.SelectedValue);

                //command.ExecuteNonQuery();
            }
            Categories();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form1 = new addUserForm();
            form1.Visible = true;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            FillingGrid(tableName);
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form2 = new loginForm();
            form2.Visible = true;
            this.Hide();
        }

        private void applicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableName = "Application";
            FillingGrid(tableName);
        }

        private void applicationCriteriaDependenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableName = "ApplicationCriteriaDependence";
            FillingGrid(tableName);
        }

        private void attributeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableName = "Attribute";
            FillingGrid(tableName);
        }

        private void attributeValuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableName = "AttributeValues";
            FillingGrid(tableName);
        }

        private void categoryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            tableName = "Category";
            FillingGrid(tableName);
        }

        private void categoryAttributeDependenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableName = "CategoryAttributeDependence";
            FillingGrid(tableName);
        }

        private void categoryCriterionDepenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableName = "CategoryCriterionDepence";
            FillingGrid(tableName);
        }

        private void compensationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableName = "Compensation";
            FillingGrid(tableName);
        }

        private void criterionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableName = "Criterion";
            FillingGrid(tableName);
        }

        private void criterionValuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableName = "CriterionValues";
            FillingGrid(tableName);
        }

        private void damageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableName = "Damage";
            FillingGrid(tableName);
        }

        private void policyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableName = "Policy";
            FillingGrid(tableName);
        }

        private void policyTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableName = "PolicyType";
            FillingGrid(tableName);
        }

        private void rateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableName = "Rate";
            FillingGrid(tableName);
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableName = "Users";
            FillingGrid(tableName);
        }
    }
}
