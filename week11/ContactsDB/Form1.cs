using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ContactsDB
{
    public partial class Form1 : Form
    {
        public int ID;
        // connection string
        private SQLiteConnection conn;
        // DataBase location
        private string dataSource;
        //private BindingSource bindingSource1 = new BindingSource();

        // corresponds to table in DataBase
        //DataTable dataTable;

        public Form1()
        {
            InitializeComponent();
            dataSource = "Data Source = databases/contacts.db";
            conn = new SQLiteConnection(dataSource);

            //dataTable = new DataTable();

            //dataGridView1.DataSource = bindingSource1;
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            //SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM Students", conn);

            // clear table for multiple LOAD use
            //dataTable.Clear();
            // fill data to Datatable
            //da.Fill(dataTable);

            // use data from DataTable in GridView
            //bindingSource1.DataSource = dataTable;
            SQLiteCommand CMD = conn.CreateCommand();
            CMD.CommandText = "SELECT * FROM Contacts WHERE ID = 0";
            //CMD.Parameters.Add("@Name", DbType.String).Value = nametextBox.Text.ToUpper();
            //CMD.Parameters.Add("@Number", DbType.String).Value = numbertextBox.Text.ToUpper();
            SQLiteDataReader SQL = CMD.ExecuteReader();
            nametextBox.Text += SQL["Name"];
            numbertextBox.Text += SQL["Number"];


        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            Form contactForm = new CreateContactForm(conn);
            contactForm.Show();
        }
    }
}
