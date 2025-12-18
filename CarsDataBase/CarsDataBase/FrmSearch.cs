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

namespace CarsDataBase
{
    public partial class FrmSearch : Form
    {

        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\User1\Downloads\Akhona Khanyile App Development Assignment\Akhona Khanyile App Development Assignment\cars\CarsDataBase\CarsDataBase\Hire.mdf"";Integrated Security=True";
        public FrmSearch()
        {
            InitializeComponent();
        }

        private void FrmSearch_Load(object sender, EventArgs e)
        {
         
            this.tblCarTableAdapter.Fill(this.hireDataSet.TblCar);

        }

        private void cboField_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Run_Click(object sender, EventArgs e)
        {
            if (cboField.SelectedIndex == -1 ||cboOperater.SelectedIndex == -1 || string.IsNullOrEmpty(txtValue.Text))
            {
                MessageBox.Show("Please fill in all search criteria.");
                return;
            }

            try
            {
                using(SqlConnection conn =new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = $"Select [Vehicle Registration Number], Make, EngineSize, DateRegistered, RentalPerDay, Available " +
                        $"From TblCar Where {cboField.SelectedItem} {cboOperater.SelectedItem} @SearchValue";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add(new SqlParameter("@SearchValue", SqlDbType.VarChar) { Value = txtValue.Text });

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        DataGridViewSearchResults.DataSource = dt;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
