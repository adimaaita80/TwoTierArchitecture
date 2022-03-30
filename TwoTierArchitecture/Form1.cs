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
        public frmUsers()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost; database=SoftwareArchitectureCourse; Integrated Security=true";
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            connection.Close();
        }
    }
}
