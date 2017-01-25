﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InsuranceCompany
{
    public partial class addUsersForm : Form
    {
        mainForm form;
        SqlConnection connection;
        string connectionString;
        List<string> list;
        string query;

        public addUsersForm(List<string> inList, string inquery)
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

        private void okButton_Click(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                try
                {
                    if (query.StartsWith("INSERT"))
                    {
                        command.Parameters.AddWithValue(string.Format("{0}", list[1]), textBox2.Text);
                        command.Parameters.AddWithValue(string.Format("{0}", list[2]), textBox3.Text);
                        command.Parameters.AddWithValue(string.Format("{0}", list[3]), textBox4.Text);
                        command.Parameters.AddWithValue(string.Format("{0}", list[4]), textBox5.Text);
                        command.Parameters.AddWithValue(string.Format("{0}", list[5]), birthDatePicker.Value.ToShortDateString());
                        command.Parameters.AddWithValue(string.Format("{0}", list[6]), textBox7.Text);
                        command.Parameters.AddWithValue(string.Format("{0}", list[7]), textBox8.Text);
                        command.Parameters.AddWithValue(string.Format("{0}", list[8]), "client");
                    }
                    else if (query.StartsWith("UPDATE"))
                    {
                        command.Parameters.AddWithValue(string.Format("@{0}", list[0]), textBox1.Text);
                        command.Parameters.AddWithValue(string.Format("@{0}", list[1]), textBox2.Text);
                        command.Parameters.AddWithValue(string.Format("@{0}", list[2]), textBox3.Text);
                        command.Parameters.AddWithValue(string.Format("@{0}", list[3]), textBox4.Text);
                        command.Parameters.AddWithValue(string.Format("@{0}", list[4]), textBox5.Text);
                        command.Parameters.AddWithValue(string.Format("@{0}", list[5]), birthDatePicker.Value.ToShortDateString());
                        command.Parameters.AddWithValue(string.Format("@{0}", list[6]), textBox7.Text);
                        command.Parameters.AddWithValue(string.Format("@{0}", list[7]), textBox8.Text);
                        command.Parameters.AddWithValue(string.Format("@{0}", list[8]), "client");
                    }

                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {

                }
                
                connection.Close();
                Close();
            }
        }
    }
}