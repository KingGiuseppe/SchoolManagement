﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement.Views
{
    public partial class StudentTableViewForm : Form
    {
        public StudentTableViewForm()
        {
            InitializeComponent();
            LoadStudentInfo();
        }

        private void StudentTableViewForm_Load(object sender, EventArgs e)
        {
          
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadStudentInfoBtn_Click(object sender, EventArgs e)
        {            
            
        }

        private void LoadStudentInfo()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" +
                "C:\\Users\\Giuseppe\\Documents\\SchoolManagement\\SchoolManagementSolution\\SchoolServer2\\DatabaseForSchool.mdf;Integrated Security=True";
            string sql = "SELECT * FROM Students";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "Student_table");
            connection.Close();
            StudentTableGrid.DataSource = ds;
            StudentTableGrid.DataMember = "Student_table";
        }
    }
}
