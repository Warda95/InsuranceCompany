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
        addForm form3;

        List<string> list;
        string query;
        string userType;
        string userLoginName;

        public mainForm(string inUserType, string inUserID)
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["InsuranceCompany.Properties.Settings.InsuranceCompanyConnectionString"].ConnectionString;
            userType = inUserType;
            userLoginName = inUserID;

            if (userType == "admin")
            {
                AddButton.Enabled = true;
                UpdateButton.Enabled = true;
                deleteButton.Enabled = true;
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
            else if (userType == "agent")
            {
                AddButton.Enabled = true;
                UpdateButton.Enabled = true;
                deleteButton.Enabled = true;
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
                addUserToolStripMenuItem.Enabled = false;
                deleteBox.Enabled = false;
                AddButton.Enabled = false;
                UpdateButton.Enabled = false;
                deleteButton.Enabled = false;
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
            else if (userType == "public")
            {
                addUserToolStripMenuItem.Enabled = false;
                deleteBox.Enabled = false;
                AddButton.Enabled = false;
                UpdateButton.Enabled = false;
                deleteButton.Enabled = false;
                applicationToolStripMenuItem.Enabled = false;
                applicationCriteriaDependenceToolStripMenuItem.Enabled = false;
                attributeToolStripMenuItem.Enabled = true;
                attributeValuesToolStripMenuItem.Enabled = false;
                categoryAttributeDependenceToolStripMenuItem.Enabled = false;
                categoryCriterionDepenceToolStripMenuItem.Enabled = false;
                compensationToolStripMenuItem.Enabled = false;
                criterionToolStripMenuItem.Enabled = true;
                criterionValuesToolStripMenuItem.Enabled = false;
                damageToolStripMenuItem.Enabled = false;
                policyToolStripMenuItem.Enabled = false;
                policyTypeToolStripMenuItem.Enabled = false;
                rateToolStripMenuItem.Enabled = false;
                usersToolStripMenuItem.Enabled = false;
            }
            FillingGrid(tableName);
        }
        
        private void mainForm_Load(object sender, EventArgs e)
        {
            FillingGrid(tableName);
        }
        
        public void FillingGrid(string tableName)
        {
            if (userType == "client" && tableName == "Users")
                query = string.Format("SELECT * FROM Users WHERE ID={0}", userLoginName);
            else if (userType == "client" && tableName == "Application")
                query = string.Format("SELECT * FROM Application WHERE UserID={0}", userLoginName);
            else if (userType == "client" && tableName == "Policy")
                query = string.Format("SELECT * FROM Policy WHERE ApplicationID IN (SELECT ID FROM Application WHERE UserID={0})", userLoginName);
            else if (userType == "client" && tableName == "Damage")
                query = string.Format("SELECT * FROM Damage WHERE PolicyID IN (Select ID FROM Policy WHERE ApplicationID IN (SELECT ID FROM Application WHERE UserID={0}))", userLoginName);
            else if (userType == "client" && tableName == "Compensation")
                query = string.Format("SELECT * FROM Compensation WHERE DamageID IN (SELECT ID FROM Damage WHERE PolicyID IN (Select ID FROM Policy WHERE ApplicationID IN (SELECT ID FROM Application WHERE UserID={0})))", userLoginName);
            else
                query = string.Format("SELECT * FROM {0}", tableName);

            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable appTable = new DataTable();
                BindingSource bindingSource = new BindingSource();

                adapter.Fill(appTable);
                bindingSource.DataSource = appTable;
                int i = 0;
                foreach (DataGridViewColumn c in dgv.Columns)
                {
                    i += c.Width;
                }
                dgv.Width = i + dgv.RowHeadersWidth + 2;
                dgv.DataSource = bindingSource;
            }
        }

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
                form3 = new addForm(list, query);
                form3.Visible = true;
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
                form3 = new addForm(list, query);
                form3.Visible = true;
            }
            else if (tableName == "Attribute")
            {
                list = new List<string>();
                list.Add("@ID");
                list.Add("@AttributeName");
                
                query = string.Format("INSERT INTO {0} VALUES ({1})", mainForm.tableName,
                    list[1]);
                form3 = new addForm(list, query);
                form3.Visible = true;
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
                form3 = new addForm(list, query);
                form3.Visible = true;
            }
            else if (tableName == "Category")
            {
                list = new List<string>();
                list.Add("@ID");
                list.Add("@Type");
                list.Add("@Subtype");

                query = string.Format("INSERT INTO {0} VALUES ({1}, {2})", mainForm.tableName,
                    list[1], list[2]);
                form3 = new addForm(list, query);
                form3.Visible = true;
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
                form3 = new addForm(list, query);
                form3.Visible = true;
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
                form3 = new addForm(list, query);
                form3.Visible = true;
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
                form3 = new addForm(list, query);
                form3.Visible = true;
            }
            else if (tableName == "Criterion")
            {
                list = new List<string>();
                list.Add("@ID");
                list.Add("@CriterionName");

                query = string.Format("INSERT INTO {0} VALUES ({1})", mainForm.tableName,
                    list[1]);
                form3 = new addForm(list, query);
                form3.Visible = true;
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
                form3 = new addForm(list, query);
                form3.Visible = true;
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
                form3 = new addForm(list, query);
                form3.Visible = true;
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
                form3 = new addForm(list, query, tableName);
                form3.Visible = true;
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
                form3 = new addForm(list, query);
                form3.Visible = true;
            }
            else if (tableName == "Rate")
            {
                list = new List<string>();
                list.Add("@ID");
                list.Add("@CriterionID");
                list.Add("@RateName");

                query = string.Format("INSERT INTO {0} VALUES ({1}, {2})", mainForm.tableName,
                    list[1], list[2]);
                form3 = new addForm(list, query);
                form3.Visible = true;
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
                form3 = new addForm(list, query);
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
                form3 = new addForm(list, query);
                form3.Visible = true;
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
                form3 = new addForm(list, query);
                form3.Visible = true;
            }
            else if (tableName == "Attribute")
            {
                list = new List<string>();
                list.Add("ID");
                list.Add("AttributeName");

                query = string.Format("INSERT INTO {0} VALUES ({1})", mainForm.tableName,
                    list[1]);
                form3 = new addForm(list, query);
                form3.Visible = true;
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
                form3 = new addForm(list, query);
                form3.Visible = true;
            }
            else if (tableName == "Category")
            {
                list = new List<string>();
                list.Add("ID");
                list.Add("Type");
                list.Add("Subtype");

                query = string.Format("INSERT INTO {0} VALUES ({1}, {2})", mainForm.tableName,
                    list[1], list[2]);
                form3 = new addForm(list, query);
                form3.Visible = true;
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
                form3 = new addForm(list, query);
                form3.Visible = true;
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
                form3 = new addForm(list, query);
                form3.Visible = true;
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
                form3 = new addForm(list, query);
                form3.Visible = true;
            }
            else if (tableName == "Criterion")
            {
                list = new List<string>();
                list.Add("ID");
                list.Add("CriterionName");

                query = string.Format("INSERT INTO {0} VALUES ({1})", mainForm.tableName,
                    list[1]);
                form3 = new addForm(list, query);
                form3.Visible = true;
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
                form3 = new addForm(list, query);
                form3.Visible = true;
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
                form3 = new addForm(list, query);
                form3.Visible = true;
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
                form3 = new addForm(list, query);
                form3.Visible = true;
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
                form3 = new addForm(list, query);
                form3.Visible = true;
            }
            else if (tableName == "Rate")
            {
                list = new List<string>();
                list.Add("ID");
                list.Add("CriterionID");
                list.Add("RateName");

                query = string.Format("INSERT INTO {0} VALUES ({1}, {2})", mainForm.tableName,
                    list[1], list[2]);
                form3 = new addForm(list, query);
                form3.Visible = true;
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
                form3 = new addForm(list, query);
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
            form1 = new addUserForm(userType);
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
            form1 = new addUserForm(userType);
            form1.Visible = true;
            this.Hide();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            FillingGrid(tableName);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(string.Format("DELETE FROM {0} WHERE ID=@ID", tableName), connection))
            {
                connection.Open();

                try
                {
                    command.Parameters.AddWithValue("@ID", int.Parse(deleteBox.Text));
                    if (command.CommandText.StartsWith("DELETE FROM Users") && deleteBox.Text == "1")
                        MessageBox.Show("You can't delete admin!");
                    else if (userType == "agent" && command.CommandText.StartsWith("DELETE FROM Users"))
                        MessageBox.Show("You can't delete any users!");
                    else
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                connection.Close();
            }

            FillingGrid(tableName);
        }
    }
}
