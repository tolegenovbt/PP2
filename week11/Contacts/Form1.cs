using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Employees
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
            dataSource = "Data Source = databases/employees.db";
            conn = new SQLiteConnection(dataSource);
            
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            nametextBox.Text = "";
            surnametextBox.Text = "";
            emailtxtbox.Text = "";
            agetxtbox.Text = "";
            ID = 1;
            idlbl.Text = ID.ToString();
            SQLiteCommand CMD = conn.CreateCommand();
            CMD.CommandText = "SELECT * FROM Employees WHERE ID = 1";
            //CMD.Parameters.Add("@Name", DbType.String).Value = nametextBox.Text.ToUpper();
            //CMD.Parameters.Add("@Number", DbType.String).Value = numbertextBox.Text.ToUpper();
            SQLiteDataReader SQL = CMD.ExecuteReader();
            if (SQL.HasRows)
                while (SQL.Read())
                {
                    nametextBox.Text += SQL["Name"];
                    surnametextBox.Text += SQL["Surname"];
                    emailtxtbox.Text += SQL["Email"];
                    agetxtbox.Text += SQL["Age"].ToString();
                }

            conn.Close();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            Form contactForm = new CreateContactForm(conn);
            contactForm.Show();
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            nametextBox.Text = "";
            surnametextBox.Text = "";
            emailtxtbox.Text = "";
            agetxtbox.Text = "";
            SQLiteCommand CMD = conn.CreateCommand();
            CMD.CommandText = "SELECT * FROM Employees WHERE ID = "+ ++ID;
            idlbl.Text = ID.ToString();
            //CMD.Parameters.Add("@Name", DbType.String).Value = nametextBox.Text.ToUpper();
            //CMD.Parameters.Add("@Number", DbType.String).Value = numbertextBox.Text.ToUpper();
            SQLiteDataReader SQL = CMD.ExecuteReader();
            if (SQL.HasRows)
                while (SQL.Read())
                {
                    nametextBox.Text += SQL["Name"];
                    surnametextBox.Text += SQL["Surname"];
                    emailtxtbox.Text += SQL["Email"];
                    agetxtbox.Text += SQL["Age"].ToString();
                }
            conn.Close();
        }

        private void prebtn_Click(object sender, EventArgs e)
        {   
            conn.Open();
            nametextBox.Text = "";
            surnametextBox.Text = "";
            emailtxtbox.Text = "";
            agetxtbox.Text = "";
            if (ID > 1)
            {
                SQLiteCommand CMD = conn.CreateCommand();
                CMD.CommandText = "SELECT * FROM Employees WHERE ID = " + --ID;
                idlbl.Text = ID.ToString();
                //CMD.Parameters.Add("@Name", DbType.String).Value = nametextBox.Text.ToUpper();
                //CMD.Parameters.Add("@Number", DbType.String).Value = numbertextBox.Text.ToUpper();
                SQLiteDataReader SQL = CMD.ExecuteReader();
                if (SQL.HasRows)
                    while (SQL.Read())
                    {
                        nametextBox.Text += SQL["Name"];
                        surnametextBox.Text += SQL["Surname"];
                        emailtxtbox.Text += SQL["Email"];
                        agetxtbox.Text += SQL["Age"].ToString();
                    }
            }
            conn.Close();
        }

        
    }
}
