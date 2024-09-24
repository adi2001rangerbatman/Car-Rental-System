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
using System.Data.SqlClient;

namespace Car_Rental_System
{
    public partial class Return : Form
    {
        public Return()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\CarRentaldb.mdf;Integrated Security=True;Connect Timeout=30;");
        private void Populate()
        {
            conn.Open();
            string quary = "select * from RentalTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(quary, conn);
            SqlCommandBuilder command = new SqlCommandBuilder(adapter);

            var userDataSet = new DataSet();
            adapter.Fill(userDataSet);

            rentCarDGV.DataSource = userDataSet.Tables[0];
            conn.Close();
        }
        private void PopulateRet()
        {
            conn.Open();
            string quary = "select * from ReturnTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(quary, conn);
            SqlCommandBuilder command = new SqlCommandBuilder(adapter);

            var userDataSet = new DataSet();
            adapter.Fill(userDataSet);

            returnCarDGV.DataSource = userDataSet.Tables[0];
            conn.Close();
        }
        private void DeleteOnReturned() 
        {

            int rentID;
            rentID = Convert.ToInt32(rentCarDGV.SelectedRows[0].Cells[0].Value + String.Empty);

            conn.Open();
            string quaery = "delete from RentalTbl where Rent_Id = " + rentID + "";
            SqlCommand cmd = new SqlCommand(quaery, conn);
            cmd.ExecuteNonQuery();
            //MessageBox.Show("Rental Record Deleted Successfully!");

            returnID.Clear();
            conn.Close();
            Populate();
            //UpdateonRent();
        }
        private void Return_Load(object sender, EventArgs e)
        {
            Populate();
            PopulateRet();
        }

        private void rentCarDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rentCarDGV.SelectedRows.Count > 0)
            {
                var selectedRow = rentCarDGV.SelectedRows[0];

                if (selectedRow.Cells.Count > 4) // Ensure there are enough cells in the selected row
                {
                    returnID.Text = selectedRow.Cells[0].Value + String.Empty; 
                    returnCarRegNo.Text = selectedRow.Cells[1].Value + String.Empty;
                    returnCustomerName.Text = selectedRow.Cells[2].Value + String.Empty;
                    returnDate.Text = selectedRow.Cells[4].Value + String.Empty;

                    DateTime d1 = returnDate.Value.Date;
                    DateTime d2 = DateTime.Now;
                    TimeSpan time = d1 - d2;
                    int noOfDays =Convert.ToInt32(time.TotalDays);
                    if (noOfDays <= 0)
                    {
                        returnDelay.Text = "No Delay";
                        returnFine.Text = "0";
                    }
                    else 
                    {
                        returnDelay.Text = ""+noOfDays;
                        returnFine.Text = "" + (noOfDays * 1000);
                    }
                }
                else
                {
                    // Handle the case where there are not enough cells
                    MessageBox.Show("The selected row does not contain the expected number of cells.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Handle the case where no row is selected
                MessageBox.Show("No row is selected. Please select a row first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_return_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void btn_return_add_Click(object sender, EventArgs e)
        {
            if (returnID.Text == "" || returnCustomerName.Text=="" || returnDelay.Text=="" || returnFine.Text =="")
            {
                MessageBox.Show("Missing Some Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    conn.Open();

                    string quaery = "insert into ReturnTbl values(" + returnID.Text + ",'" + returnCarRegNo.Text + "','" + returnCustomerName.Text + "','" + returnDate.Value.ToString() + "','" + returnDelay.Text + "','" + returnFine.Text + "');";
                    SqlCommand cmd = new SqlCommand(quaery, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Successfully Returned !");

                    returnID.Clear();
                    returnCarRegNo.Clear();
                    returnCustomerName.Clear();
                    returnFine.Clear();

                    conn.Close();
                    //UpdateonRent();
  
                    DeleteOnReturned();
                    PopulateRet();
                   
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void returnDelay_TextChanged(object sender, EventArgs e)
        {

        }

        private void btb_return_delete_Click(object sender, EventArgs e)
        {
            if (returnID.Text == "")
            {
                MessageBox.Show("Missing Return ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {


                    conn.Open();


                    string quaery = "delete from ReturnTbl where Return_Id = " + returnID.Text + ";";
                    SqlCommand cmd = new SqlCommand(quaery, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Return Record Deleted Successfully!");

                    returnID.Clear();


                    conn.Close();
                    Populate();
                    PopulateRet();
                    //UpdateonRent();

                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void btn_return_edit_Click(object sender, EventArgs e)
        {

        }
    }
}
