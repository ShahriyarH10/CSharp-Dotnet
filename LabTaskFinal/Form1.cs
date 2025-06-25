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

namespace LabTaskFinal
{
    public partial class Form1 : Form
    {

        SqlConnection conn = new SqlConnection("Data Source=hp;Initial Catalog=SocialNetwork;Integrated Security=True;TrustServerCertificate=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string query = "select * from Student";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvStudentInfo.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            conn.Close();
        }

        private void dgvStudentInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
