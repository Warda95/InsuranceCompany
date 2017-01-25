using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace InsuranceCompany
{
    public partial class mainForm : Form
    {
        public static string tableName = "Category";
        SqlConnection connection;
        string connectionString;
        addUserForm form1;
        loginForm form2;
        
        addUsersForm form3;
        addApplicationCriteriaDependenceForm form4;
        addApplicationForm form5;
        addAttributeForm form6;
        addAttributeValuesForm form7;
        addCategoryAttributeDependenceForm form8;
        addCategoryCriterionDependenceForm form9;
        addCategoryForm form10;
        addCompensationForm form11;
        addCriterionForm form12;
        addCriterionValuesForm form13;
        addDamageForm form14;
        addPolicyForm form15;
        addPolicyTypeForm form16;
        addRateForm form17;

        List<string> list;
        string query;

        public mainForm(string userType)
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["InsuranceCompany.Properties.Settings.InsuranceCompanyConnectionString"].ConnectionString;

            if (userType == "admin")
            {
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
            else if (userType == "agent")
            {
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
            }
            else if (userType == "client")
            {
                AddButton.Enabled = false;
                UpdateButton.Enabled = false;
                ShowButton.Enabled = true;
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
            }
            else if (userType == "public")
            {
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
            if (tableName == "Application")
            {
                list = new List<string>();
                list.Add("@ID");
                list.Add("@UserID");
                list.Add("@CategoryID");
                list.Add("@ApplicationName");
                list.Add("@ApplicationDate");

                query = string.Format("INSERT INTO {0} VALUES ({1}, {2}, {3}, {4})", mainForm.tableName,
                    list[1], list[2], list[3], list[4]);
                form5 = new addApplicationForm(list, query);
                form5.Visible = true;
            }
            else if (tableName == "ApplicationCriteriaDependence")
            {
                list = new List<string>();
                list.Add("@ID");
                list.Add("@DependenceName");
                list.Add("@ApplicationID");
                list.Add("@CriterionID");

                query = string.Format("INSERT INTO {0} VALUES ({1}, {2}, {3})", mainForm.tableName,
                    list[1], list[2], list[3]);
                form4 = new addApplicationCriteriaDependenceForm(list, query);
                form4.Visible = true;
            }
            else if (tableName == "Attribute")
            {
                list = new List<string>();
                list.Add("@ID");
                list.Add("@AttributeName");
                
                query = string.Format("INSERT INTO {0} VALUES ({1})", mainForm.tableName,
                    list[1]);
                form6 = new addAttributeForm(list, query);
                form6.Visible = true;
            }
            else if (tableName == "AttributeValues")
            {
                list = new List<string>();
                list.Add("@ID");
                list.Add("@AttributeValue1");
                list.Add("@AttributeValue2");
                list.Add("@CategoryID");
                list.Add("@AttributeID");

                query = string.Format("INSERT INTO {0} VALUES ({1}, {2}, {3}, {4})", mainForm.tableName,
                    list[1], list[2], list[3], list[4]);
                form7 = new addAttributeValuesForm(list, query);
                form7.Visible = true;
            }
            else if (tableName == "Category")
            {
                list = new List<string>();
                list.Add("@ID");
                list.Add("@Type");
                list.Add("@Subtype");

                query = string.Format("INSERT INTO {0} VALUES ({1}, {2})", mainForm.tableName,
                    list[1], list[2]);
                form10 = new addCategoryForm(list, query);
                form10.Visible = true;
            }
            else if (tableName == "CategoryAttributeDependence")
            {
                list = new List<string>();
                list.Add("@ID");
                list.Add("@DependenceName");
                list.Add("@CategoryID");
                list.Add("@AttributeID");

                query = string.Format("INSERT INTO {0} VALUES ({1}, {2}, {3})", mainForm.tableName,
                    list[1], list[2], list[3]);
                form8 = new addCategoryAttributeDependenceForm(list, query);
                form8.Visible = true;
            }
            else if (tableName == "CategoryCriterionDependence")
            {
                list = new List<string>();
                list.Add("@ID");
                list.Add("@DependenceName");
                list.Add("@CategoryID");
                list.Add("@CriterionID");

                query = string.Format("INSERT INTO {0} VALUES ({1}, {2}, {3})", mainForm.tableName,
                    list[1], list[2], list[3]);
                form9 = new addCategoryCriterionDependenceForm(list, query);
                form9.Visible = true;
            }
            else if (tableName == "Compensation")
            {
                list = new List<string>();
                list.Add("@ID");
                list.Add("@DamageID");
                list.Add("@CompensationName");
                list.Add("@CompensationDate");

                query = string.Format("INSERT INTO {0} VALUES ({1}, {2}, {3})", mainForm.tableName,
                    list[1], list[2], list[3]);
                form11 = new addCompensationForm(list, query);
                form11.Visible = true;
            }
            else if (tableName == "Criterion")
            {
                list = new List<string>();
                list.Add("@ID");
                list.Add("@CriterionName");

                query = string.Format("INSERT INTO {0} VALUES ({1})", mainForm.tableName,
                    list[1]);
                form12 = new addCriterionForm(list, query);
                form12.Visible = true;
            }
            else if (tableName == "CriterionValues")
            {
                list = new List<string>();
                list.Add("@ID");
                list.Add("@Value1");
                list.Add("@Value2");
                list.Add("@CategoryID");
                list.Add("@CriterionID");

                query = string.Format("INSERT INTO {0} VALUES ({1}, {2}, {3}, {4})", mainForm.tableName,
                    list[1], list[2], list[3], list[4]);
                form13 = new addCriterionValuesForm(list, query);
                form13.Visible = true;
            }
            else if (tableName == "Damage")
            {
                list = new List<string>();
                list.Add("@ID");
                list.Add("@PolicyID");
                list.Add("@Type");
                list.Add("@Rate");
                list.Add("@Cost");

                query = string.Format("INSERT INTO {0} VALUES ({1}, {2}, {3}, {4})", mainForm.tableName,
                    list[1], list[2], list[3], list[4]);
                form14 = new addDamageForm(list, query);
                form14.Visible = true;
            }
            else if (tableName == "Policy")
            {
                list = new List<string>();
                list.Add("@ID");
                list.Add("@PolicyTypeID");
                list.Add("@ApplicationID");
                list.Add("@Name");
                list.Add("@FromDate");
                list.Add("@ToDate");

                query = string.Format("INSERT INTO {0} VALUES ({1}, {2}, {3}, {4}, {5})", mainForm.tableName,
                    list[1], list[2], list[3], list[4], list[5]);
                form15 = new addPolicyForm(list, query);
                form15.Visible = true;
            }
            else if (tableName == "PolicyType")
            {
                list = new List<string>();
                list.Add("@ID");
                list.Add("@RateID");
                list.Add("@CategoryID");
                list.Add("@PolicyTypeName");

                query = string.Format("INSERT INTO {0} VALUES ({1}, {2}, {3})", mainForm.tableName,
                    list[1], list[2], list[3]);
                form16 = new addPolicyTypeForm(list, query);
                form16.Visible = true;
            }
            else if (tableName == "Rate")
            {
                list = new List<string>();
                list.Add("@ID");
                list.Add("@CriterionID");
                list.Add("@RateName");

                query = string.Format("INSERT INTO {0} VALUES ({1}, {2})", mainForm.tableName,
                    list[1], list[2]);
                form17 = new addRateForm(list, query);
                form17.Visible = true;
            }
            else if (tableName == "Users")
            {
                list = new List<string>();
                list.Add("@ID");
                list.Add("@UserLogin");
                list.Add("@UserPassword");
                list.Add("@UserFirstName");
                list.Add("@UserLastName");
                list.Add("@UserBirthDate");
                list.Add("@UserMaritalStatus");
                list.Add("@UserJob");
                list.Add("@UserRole");

                query = string.Format("INSERT INTO {0} VALUES ({1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", mainForm.tableName,
                    list[1], list[2], list[3], list[4], list[5], list[6], list[7], list[8]);
                form3 = new addUsersForm(list, query);
                form3.Visible = true;
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (tableName == "Application")
            {
                list = new List<string>();
                list.Add("ID");
                list.Add("UserID");
                list.Add("CategoryID");
                list.Add("ApplicationName");
                list.Add("ApplicationDate");

                query = string.Format("INSERT INTO {0} VALUES ({1}, {2}, {3}, {4})", mainForm.tableName,
                    list[1], list[2], list[3], list[4]);
                form5 = new addApplicationForm(list, query);
                form5.Visible = true;
            }
            else if (tableName == "ApplicationCriteriaDependence")
            {
                list = new List<string>();
                list.Add("ID");
                list.Add("DependenceName");
                list.Add("ApplicationID");
                list.Add("CriterionID");

                query = string.Format("INSERT INTO {0} VALUES ({1}, {2}, {3})", mainForm.tableName,
                    list[1], list[2], list[3]);
                form4 = new addApplicationCriteriaDependenceForm(list, query);
                form4.Visible = true;
            }
            else if (tableName == "Attribute")
            {
                list = new List<string>();
                list.Add("ID");
                list.Add("AttributeName");

                query = string.Format("INSERT INTO {0} VALUES ({1})", mainForm.tableName,
                    list[1]);
                form6 = new addAttributeForm(list, query);
                form6.Visible = true;
            }
            else if (tableName == "AttributeValues")
            {
                list = new List<string>();
                list.Add("ID");
                list.Add("AttributeValue1");
                list.Add("AttributeValue2");
                list.Add("CategoryID");
                list.Add("AttributeID");

                query = string.Format("INSERT INTO {0} VALUES ({1}, {2}, {3}, {4})", mainForm.tableName,
                    list[1], list[2], list[3], list[4]);
                form7 = new addAttributeValuesForm(list, query);
                form7.Visible = true;
            }
            else if (tableName == "Category")
            {
                list = new List<string>();
                list.Add("ID");
                list.Add("Type");
                list.Add("Subtype");

                query = string.Format("INSERT INTO {0} VALUES ({1}, {2})", mainForm.tableName,
                    list[1], list[2]);
                form10 = new addCategoryForm(list, query);
                form10.Visible = true;
            }
            else if (tableName == "CategoryAttributeDependence")
            {
                list = new List<string>();
                list.Add("ID");
                list.Add("DependenceName");
                list.Add("CategoryID");
                list.Add("AttributeID");

                query = string.Format("INSERT INTO {0} VALUES ({1}, {2}, {3})", mainForm.tableName,
                    list[1], list[2], list[3]);
                form8 = new addCategoryAttributeDependenceForm(list, query);
                form8.Visible = true;
            }
            else if (tableName == "CategoryCriterionDependence")
            {
                list = new List<string>();
                list.Add("ID");
                list.Add("DependenceName");
                list.Add("CategoryID");
                list.Add("CriterionID");

                query = string.Format("INSERT INTO {0} VALUES ({1}, {2}, {3})", mainForm.tableName,
                    list[1], list[2], list[3]);
                form9 = new addCategoryCriterionDependenceForm(list, query);
                form9.Visible = true;
            }
            else if (tableName == "Compensation")
            {
                list = new List<string>();
                list.Add("ID");
                list.Add("DamageID");
                list.Add("CompensationName");
                list.Add("CompensationDate");

                query = string.Format("INSERT INTO {0} VALUES ({1}, {2}, {3})", mainForm.tableName,
                    list[1], list[2], list[3]);
                form11 = new addCompensationForm(list, query);
                form11.Visible = true;
            }
            else if (tableName == "Criterion")
            {
                list = new List<string>();
                list.Add("ID");
                list.Add("CriterionName");

                query = string.Format("INSERT INTO {0} VALUES ({1})", mainForm.tableName,
                    list[1]);
                form12 = new addCriterionForm(list, query);
                form12.Visible = true;
            }
            else if (tableName == "CriterionValues")
            {
                list = new List<string>();
                list.Add("ID");
                list.Add("Value1");
                list.Add("Value2");
                list.Add("CategoryID");
                list.Add("CriterionID");

                query = string.Format("INSERT INTO {0} VALUES ({1}, {2}, {3}, {4})", mainForm.tableName,
                    list[1], list[2], list[3], list[4]);
                form13 = new addCriterionValuesForm(list, query);
                form13.Visible = true;
            }
            else if (tableName == "Damage")
            {
                list = new List<string>();
                list.Add("ID");
                list.Add("PolicyID");
                list.Add("Type");
                list.Add("Rate");
                list.Add("Cost");

                query = string.Format("INSERT INTO {0} VALUES ({1}, {2}, {3}, {4})", mainForm.tableName,
                    list[1], list[2], list[3], list[4]);
                form14 = new addDamageForm(list, query);
                form14.Visible = true;
            }
            else if (tableName == "Policy")
            {
                list = new List<string>();
                list.Add("ID");
                list.Add("PolicyTypeID");
                list.Add("ApplicationID");
                list.Add("Name");
                list.Add("FromDate");
                list.Add("ToDate");

                query = string.Format("INSERT INTO {0} VALUES ({1}, {2}, {3}, {4}, {5})", mainForm.tableName,
                    list[1], list[2], list[3], list[4], list[5]);
                form15 = new addPolicyForm(list, query);
                form15.Visible = true;
            }
            else if (tableName == "PolicyType")
            {
                list = new List<string>();
                list.Add("ID");
                list.Add("RateID");
                list.Add("CategoryID");
                list.Add("PolicyTypeName");

                query = string.Format("INSERT INTO {0} VALUES ({1}, {2}, {3})", mainForm.tableName,
                    list[1], list[2], list[3]);
                form16 = new addPolicyTypeForm(list, query);
                form16.Visible = true;
            }
            else if (tableName == "Rate")
            {
                list = new List<string>();
                list.Add("ID");
                list.Add("CriterionID");
                list.Add("RateName");

                query = string.Format("INSERT INTO {0} VALUES ({1}, {2})", mainForm.tableName,
                    list[1], list[2]);
                form17 = new addRateForm(list, query);
                form17.Visible = true;
            }
            else if (tableName == "Users")
            {
                list = new List<string>();
                list.Add("ID");
                list.Add("UserLogin");
                list.Add("UserPassword");
                list.Add("UserFirstName");
                list.Add("UserLastName");
                list.Add("UserBirthDate");
                list.Add("UserMaritalStatus");
                list.Add("UserJob");
                list.Add("UserRole");

                query = string.Format("UPDATE {0} SET {1}=@{1}, {2}=@{2}, {3}=@{3}, {4}=@{4}, {5}=@{5}, {6}=@{6}, {7}=@{7}, {8}=@{8} WHERE {9}=@{9}", mainForm.tableName,
                    list[1], list[2], list[3], list[4], list[5], list[6], list[7], list[8], list[0]);
                form3 = new addUsersForm(list, query);
                form3.Visible = true;
            }
        }

                            //////////////////////
                            ////// BUTTONS ///////
                            //////////////////////

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

                                //////////////////////
                                ///// TOOLSTRIPS /////
                                //////////////////////
                                
        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form1 = new addUserForm();
            form1.Visible = true;
            this.Hide();
        }
        
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form2 = new loginForm();
            form2.Visible = true;
            this.Hide();
        }
        
        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form1 = new addUserForm();
            form1.Visible = true;
            this.Hide();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            FillingGrid(tableName);
        }
    }
}
