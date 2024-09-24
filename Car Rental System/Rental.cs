using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace Car_Rental_System
{
    public partial class Rental : Form
    {
        public Rental()
        {
            InitializeComponent();
        }

        private void custName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\CarRentaldb.mdf;Integrated Security=True;Connect Timeout=30;");
        
        private void fillCombo() 
        {
            conn.Open();
            string quary = "select RegNum from CarTbl where Available ='" + "YES" + "'";
            SqlCommand sqlCommand = new SqlCommand(quary, conn);
            SqlDataReader reader = sqlCommand.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("RegNum", typeof(string));
            dt.Load(reader);

            carRegCB.ValueMember = "RegNum";
            carRegCB.DataSource = dt;
            conn.Close();
        }

        private void fillCustomer()
        {
            conn.Open();
            string quary = "select Cus_ID from CustomerTbl";
            SqlCommand sqlCommand = new SqlCommand(quary, conn);
            SqlDataReader reader = sqlCommand.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("Cus_ID", typeof(string));
            dt.Load(reader);

            rentCustID.ValueMember = "Cus_ID";
            rentCustID.DataSource = dt;
            conn.Close();
        }
        private void fetchCustomerName() 
        {
            conn.Open();
            string quary = "select * from CustomerTbl where Cus_ID = "+rentCustID.SelectedValue.ToString() +"";
            SqlCommand command = new SqlCommand(quary, conn);   
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            sqlDataAdapter.Fill(dt);

            foreach (DataRow dr in dt.Rows) 
            {
                rentCusName.Text = dr["Cus_Name"].ToString();
            }

            conn.Close();
        }
        private void Populate()
        {
            conn.Open();
            string quary = "select * from RentalTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(quary, conn);
            SqlCommandBuilder command = new SqlCommandBuilder(adapter);

            var userDataSet = new DataSet();
            adapter.Fill(userDataSet);

            rentalDGV.DataSource = userDataSet.Tables[0];
            conn.Close();
        }
        private void UpdateonRent() 
        {
            conn.Open();
            string quaery = "update carTbl set Available ='"  + "NO" +  "' where RegNum = '" + carRegCB.SelectedValue.ToString() + "';";
            SqlCommand cmd = new SqlCommand(quaery, conn);
            cmd.ExecuteNonQuery();
            //MessageBox.Show("Car Details Successfully Updated!");
            conn.Close();
        }
        private void Rental_Load(object sender, EventArgs e)
        {
            fillCombo();
            fillCustomer();
            Populate();
        }

        private void carRegCB_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void rentCustID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchCustomerName();
        }

        private void btn_customerr_back_Click(object sender, EventArgs e)
        {
    
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void btn_customer_add_Click(object sender, EventArgs e)
        {
            if (rentID.Text == "" || rentFee.Text == "")
            {
                MessageBox.Show("Missing Some Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
            else
            {
                try
                {
                    conn.Open();

                    string quaery = "insert into RentalTbl values(" + rentID.Text + ",'" + carRegCB.SelectedValue.ToString() + "','" + rentCusName.Text + "','" + rentalDate.Value.ToString() + "','" + returnDate.Value.ToString() + "'," + rentFee.Text + ")";
                    SqlCommand cmd = new SqlCommand(quaery, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Successfully Rented!","Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    rentID.Clear();
                    rentFee.Clear();

                    conn.Close();
                    UpdateonRent();
                    Populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void btb_customer_delete_Click(object sender, EventArgs e)
        {
            if (rentID.Text == "")
            {
                MessageBox.Show("Missing Rental ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {


                    conn.Open();
                 

                    string quaery = "delete from RentalTbl where Rent_Id = " + rentID.Text + ";";
                    SqlCommand cmd = new SqlCommand(quaery, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Rental Record Deleted Successfully!");

                    rentID.Clear();


                    conn.Close();
                    Populate();
                    UpdateonRent();

                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void rentalDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rentalDGV.SelectedRows.Count > 0)

            {
                var SelectedRow = rentalDGV.SelectedRows[0];

                if (SelectedRow.Cells.Count > 4)
                {

                    rentID.Text = SelectedRow.Cells[0].Value + String.Empty;
                    carRegCB.SelectedValue = SelectedRow.Cells[1].Value + String.Empty;
                    rentCusName.Text = SelectedRow.Cells[2].Value + String.Empty;
                    rentFee.Text = SelectedRow.Cells[5].Value + String.Empty;

                }
                else
                {

                    MessageBox.Show("The selected row does not contain the expected number of cells.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No row is selected. Please select a row first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_customer_edit_Click(object sender, EventArgs e)
        {
            if (rentID.Text == "" || rentCusName.Text == "" || rentFee.Text == "")
            {
                MessageBox.Show("Missing Some Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    conn.Open();
                    string quaery = "update RentalTbl set Rent_Fee = '" + rentFee.Text + "'where Rent_Id = '" + rentID.Text + "';";
                    SqlCommand cmd = new SqlCommand(quaery, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Rent Details Successfully Updated!","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    rentID.Clear();
                    rentFee.Clear();

                    conn.Close();
                    Populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }
    }
}
