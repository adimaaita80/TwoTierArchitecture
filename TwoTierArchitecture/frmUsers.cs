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

namespace TwoTierArchitecture
{
    public partial class frmUsers : Form
    {

        string connectionString = "Server=localhost; database=SoftwareArchitectureCourse; Integrated Security=true";

        SqlConnection connection;

        public frmUsers()
        {
            InitializeComponent();

            connection = new SqlConnection(connectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string command = "Select * from Users";

            SqlCommand sqlCommand = new SqlCommand(command, connection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable dt = new DataTable();

            sqlDataAdapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string userFullName = txtFullName.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            string command = $"Insert into Users values('{userFullName}','{username}' , '{password}')";
            SqlCommand sqlCommand = new SqlCommand(command, connection);
            
            if(connection.State != ConnectionState.Open)
                connection.Open();

            sqlCommand.ExecuteNonQuery();

            connection.Close();
        }
    }
}
