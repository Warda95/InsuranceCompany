using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InsuranceCompany
{
    public partial class addForm : Form
    {
        mainForm form;
        SqlConnection connection;
        string connectionString;
        List<string> list;
        string query;
        string tableName;

        public addForm(List<string> inList, string inquery)
        {
            list = inList;
            query = inquery;
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["InsuranceCompany.Properties.Settings.InsuranceCompanyConnectionString"].ConnectionString;
            if (query.StartsWith("UPDATE"))
            {
                textBox1.Enabled = true;
            }
        }

        public addForm(List<string> inList, string inquery, string intableName)
        {
            list = inList;
            query = inquery;
            tableName = intableName;
            InitializeComponent();
            textBox6.Visible = true;
            birthDatePicker.Visible = false;
            connectionString = ConfigurationManager.ConnectionStrings["InsuranceCompany.Properties.Settings.InsuranceCompanyConnectionString"].ConnectionString;
            if (query.StartsWith("UPDATE"))
            {
                textBox1.Enabled = true;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                if (query.StartsWith("INSERT"))
                {
                    try
                    {
                        command.Parameters.AddWithValue(string.Format("{0}", list[1]), textBox2.Text);
                    }
                    catch (Exception)
                    {
                        
                    }
                    try
                    {
                        command.Parameters.AddWithValue(string.Format("{0}", list[2]), textBox3.Text);
                    }
                    catch (Exception)
                    {
                        
                    }
                    try
                    {
                        command.Parameters.AddWithValue(string.Format("{0}", list[3]), textBox4.Text);
                    }
                    catch (Exception)
                    {
                        
                    }
                    try
                    {
                        command.Parameters.AddWithValue(string.Format("{0}", list[4]), textBox5.Text);
                    }
                    catch (Exception)
                    {
                        
                    }

                    if (tableName == "Policy")
                    {
                        try
                        {
                            command.Parameters.AddWithValue(string.Format("{0}", list[5]), textBox6.Text);
                        }
                        catch (Exception)
                        {

                        }
                    }
                    else
                    {
                        try
                        {
                            command.Parameters.AddWithValue(string.Format("{0}", list[5]), birthDatePicker.Value.ToShortDateString());
                        }
                        catch (Exception)
                        {

                        }
                    }
                    
                    try
                    {
                        command.Parameters.AddWithValue(string.Format("{0}", list[6]), textBox7.Text);
                    }
                    catch (Exception)
                    {
                        
                    }
                    try
                    {
                        command.Parameters.AddWithValue(string.Format("{0}", list[7]), textBox8.Text);
                    }
                    catch (Exception)
                    {
                        
                    }
                    try
                    {
                        command.Parameters.AddWithValue(string.Format("{0}", list[8]), "client");
                    }
                    catch (Exception)
                    {
                        
                    }

                }
                else if (query.StartsWith("UPDATE"))
                {
                    try
                    {
                        command.Parameters.AddWithValue(string.Format("@{0}", list[0]), textBox1.Text);
                    }
                    catch (Exception)
                    {

                    }
                    try
                    {
                        command.Parameters.AddWithValue(string.Format("@{0}", list[1]), textBox2.Text);
                    }
                    catch (Exception)
                    {

                    }
                    try
                    {
                        command.Parameters.AddWithValue(string.Format("@{0}", list[2]), textBox3.Text);
                    }
                    catch (Exception)
                    {
                        
                    }
                    try
                    {
                        command.Parameters.AddWithValue(string.Format("@{0}", list[3]), textBox4.Text);
                    }
                    catch (Exception)
                    {

                    }
                    try
                    {
                        command.Parameters.AddWithValue(string.Format("@{0}", list[4]), textBox5.Text);
                    }
                    catch (Exception)
                    {
                        
                    }

                    if (tableName == "Policy")
                    {
                        try
                        {
                            command.Parameters.AddWithValue(string.Format("{0}", list[5]), textBox6.Text);
                        }
                        catch (Exception)
                        {

                        }
                    }
                    else
                    {
                        try
                        {
                            command.Parameters.AddWithValue(string.Format("{0}", list[5]), birthDatePicker.Value.ToShortDateString());
                        }
                        catch (Exception)
                        {

                        }
                    }

                    try
                    {
                        command.Parameters.AddWithValue(string.Format("@{0}", list[6]), textBox7.Text);
                    }
                    catch (Exception)
                    {

                    }
                    try
                    {
                        command.Parameters.AddWithValue(string.Format("@{0}", list[7]), textBox8.Text);
                    }
                    catch (Exception)
                    {
                        
                    }
                    try
                    {
                        command.Parameters.AddWithValue(string.Format("@{0}", list[8]), "client");
                    }
                    catch (Exception)
                    {

                    }
                }

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
                Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            form = new mainForm("public", "");
            form.Show();
            Close();
        }
    }
}