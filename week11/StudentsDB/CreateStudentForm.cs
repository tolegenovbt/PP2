﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentsDB
{
    public partial class CreateStudentForm : Form
    {
        private SQLiteConnection conn;
        public CreateStudentForm(SQLiteConnection sqliteConn)
        {
            InitializeComponent();
            conn = sqliteConn;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // save to DB
            conn.Open();
            SQLiteCommand sqlCommand = conn.CreateCommand();

            // SQL INJECTION
            //Daulet', 'Bolatovich', 'Kabdiyev'); INSERT INTO Students(FirstName, LastName) VALUES('TEST', 'TEST'); INSERT INTO Students(FirstName, MiddleName, LastName) VALUES('Another name
            string[] f = firstnametxtbox.Text.Split();
            string[] m = middlenametxtbox.Text.Split();
            string[] l = lastnametxtbox.Text.Split();
            // Homework: finish this
            if (middlenametxtbox.Text.Length == 0)
            {
                sqlCommand.CommandText = "INSERT INTO Students (FirstName, LastName) Values('" + f[0] + "', '" + l[0] + "')";
            }
            else
            {
                sqlCommand.CommandText = "INSERT INTO Students (FirstName, MiddleName, LastName) Values('" + f[0] + "', '" + m[0] + "', '" + l[0] + "')";
            }

            //sqlCommand.CommandText = "INSERT INTO Students (FirstName, MiddleName, LastName) Values()";
            sqlCommand.ExecuteNonQuery();

            conn.Close();

            this.Close();
        }
    }
}
