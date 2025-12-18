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
    public partial class FrmCars : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\User1\Downloads\Akhona Khanyile App Development Assignment\cars\CarsDataBase\CarsDataBase\Hire.mdf"";Integrated Security=True";
        private Timer refreshTimer;
        public FrmCars()
        {
            InitializeComponent();
        }

        private void FrmCars_Load(object sender, EventArgs e)
        {
           
            this.tblCarTableAdapter.Fill(this.hireDataSet.TblCar);
            txt_Timer.Text = (tblCarBindingSource.Position)+1 + " of" + (tblCarBindingSource.Count);
            this.tblCarTableAdapter.Update(this.hireDataSet.TblCar);
        }

        private void btn_First_Click(object sender, EventArgs e)
        {
            {
                tblCarBindingSource.MoveFirst();
                txt_Timer.Text = (tblCarBindingSource.Position) + 1 + " of" + (tblCarBindingSource.Count);
            }

        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            {
                tblCarBindingSource.MovePrevious();
                txt_Timer.Text = (tblCarBindingSource.Position) + 1 + " of" + (tblCarBindingSource.Count);
            }

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            {
                tblCarBindingSource.MoveNext();
                txt_Timer.Text = (tblCarBindingSource.Position) + 1 + " of" + (tblCarBindingSource.Count);
            }

        }

        private void btn_Last_Click(object sender, EventArgs e)
        {
            {
                tblCarBindingSource.MoveLast();
                txt_Timer.Text = (tblCarBindingSource.Position) + 1 + " of" + (tblCarBindingSource.Count);
            }

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            {
                FrmSearch searchForm = new FrmSearch();
                searchForm.Show();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "Update TblCar Set Make = @Make, EngineSize = @EngineSize, DateRegistered = @DateRegistered, " +
                        "RentalPerDay = @RentalPerDay, Available = @Available Where [Vehicle Registration Number] = @VehicleRegNo";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add(new SqlParameter("@VehicleRegNo", SqlDbType.VarChar) { Value = txtReg.Text });
                        cmd.Parameters.Add(new SqlParameter("@Make", SqlDbType.VarChar) { Value = txtMake.Text });
                        cmd.Parameters.Add(new SqlParameter("@EngineSize", SqlDbType.VarChar) { Value = txtEngineSize.Text });
                        cmd.Parameters.Add(new SqlParameter("@DateRegistered", SqlDbType.VarChar) { Value = TxtDateReg.Text });
                        cmd.Parameters.Add(new SqlParameter("@RentalPerDay", SqlDbType.Decimal) { Value = decimal.Parse(txtRentalPerDay.Text) });
                        cmd.Parameters.Add(new SqlParameter("@Available", SqlDbType.Bit) { Value = chkbx1.Checked ? 1 : 0 });

                        cmd.ExecuteNonQuery();
                        this.tblCarTableAdapter.Update(this.hireDataSet.TblCar);

                    }
                }

                MessageBox.Show("Record updated successfully.");
                RefreshData();  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Record couldn't be updated. " + ex.Message);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO TblCar ([Vehicle Registration Number], Make, EngineSize, DateRegistered, RentalPerDay, Available) " +
                                   "VALUES (@VehicleRegNo, @Make, @EngineSize, @DateRegistered, @RentalPerDay, @Available)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add(new SqlParameter("@VehicleRegNo", SqlDbType.VarChar) { Value = txtReg.Text });
                        cmd.Parameters.Add(new SqlParameter("@Make", SqlDbType.VarChar) { Value = txtMake.Text });
                        cmd.Parameters.Add(new SqlParameter("@EngineSize", SqlDbType.VarChar) { Value = txtEngineSize.Text });
                        cmd.Parameters.Add(new SqlParameter("@DateRegistered", SqlDbType.VarChar) { Value = TxtDateReg.Text });
                        cmd.Parameters.Add(new SqlParameter("@RentalPerDay", SqlDbType.Decimal) { Value = decimal.Parse(txtRentalPerDay.Text) });
                        cmd.Parameters.Add(new SqlParameter("@Available", SqlDbType.Bit) { Value = chkbx1.Checked ? 1 : 0 });

                        cmd.ExecuteNonQuery();
                        this.tblCarTableAdapter.Update(this.hireDataSet.TblCar);
                    }
                }
                MessageBox.Show("Record added successfully.");
                RefreshData();  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Record couldn't be added. " + ex.Message);
            }
        }


        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txtReg.Clear();
            txtMake.Clear();
            txtEngineSize.Clear();
            TxtDateReg.Clear();
            txtRentalPerDay.Clear();
            chkbx1.Checked = false;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        string query = "Delete From TblCar Where [Vehicle Registration Number] = @VehicleRegNo";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.Add(new SqlParameter("@VehicleRegNo", SqlDbType.VarChar) { Value = txtReg.Text });

                            cmd.ExecuteNonQuery();
                            this.tblCarTableAdapter.Update(this.hireDataSet.TblCar);
                        }
                    }
                    MessageBox.Show("Record Deleted Successfully.");
                    RefreshData();  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Record couldn't be deleted. " + ex.Message);
                }
            }
        }



        private void txt_Timer_TextChanged_1(object sender, EventArgs e)
        {
            txt_Timer.Text = (tblCarBindingSource.Position)+1 + " of" + (tblCarBindingSource.Count);
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            toolTip1.SetToolTip(txtReg, "Enter the Vehicle Registration Number");
            toolTip1.SetToolTip(txtMake, "Enter the make of the vehicle");
            toolTip1.SetToolTip(txtEngineSize, "Enter the engine size of vehicle");
        }

        private void TxtDateReg_TextChanged(object sender, EventArgs e)
        {

        }

        private void RefreshData()
        {
            
            this.tblCarTableAdapter.Fill(this.hireDataSet.TblCar);

            
            tblCarBindingSource.ResetBindings(false);

            
            txt_Timer.Text = (tblCarBindingSource.Position + 1) + " of " + tblCarBindingSource.Count;
        }
    }
}
