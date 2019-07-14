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
    public partial class CreateContactForm : Form
    {
        private SQLiteConnection conn;
        public CreateContactForm(SQLiteConnection sqliteConn)
        {
            InitializeComponent();
            conn = sqliteConn;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            // save to DB
            //conn.Open();
            SQLiteCommand sqlCommand = conn.CreateCommand();

            // SQL INJECTION
            //Daulet', 'Bolatovich', 'Kabdiyev'); INSERT INTO Students(FirstName, LastName) VALUES('TEST', 'TEST'); INSERT INTO Students(FirstName, MiddleName, LastName) VALUES('Another name
            
            //string[] l = lastnametxtbox.Text.Split();
            // Homework: finish this
            if (numbertxtbox.Text.Length != 0 && nametxtbox.Text.Length!=0 && emailtxtbox.Text.Length!=0 && agetxtbox.Text.Length != 0)
            {
                string[] f = nametxtbox.Text.Split();
                string[] s = numbertxtbox.Text.Split();
                string[] em = emailtxtbox.Text.Split();
                int a = int.Parse(agetxtbox.Text.Split()[0]);
                sqlCommand.CommandText = "INSERT INTO Employees (Name, Surname, Email, Age) Values('" + f[0] + "', '" + s[0] + "', '" + em[0] + "', '" + a + "')";
            }
            sqlCommand.ExecuteNonQuery();

            conn.Close();

            this.Close();
        }
    }
}
