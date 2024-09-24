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

namespace Car_Rental_System
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\CarRentaldb.mdf;Integrated Security=True;Connect Timeout=30;");


        private void btn_customerr_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void Populate()
        {
            conn.Open();
            string quary = "select * from CustomerTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(quary, conn);
            SqlCommandBuilder command = new SqlCommandBuilder(adapter);

            var userDataSet = new DataSet();
            adapter.Fill(userDataSet);

            customerDGV.DataSource = userDataSet.Tables[0];
            conn.Close();
        }

        private void btn_customer_add_Click(object sender, EventArgs e)
        {
            if (custID.Text == "" || custName.Text == "" || custAddress.Text == "" || custPhone.Text == "")
            {
                MessageBox.Show("Missing Customer Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    conn.Open();

                    string quaery = "insert into CustomerTbl values(" + custID.Text + ",'" + custName.Text + "','" + custAddress.Text + "','" + custPhone.Text + "')";
                    SqlCommand cmd = new SqlCommand(quaery, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Successfully Added!");

                    custID.Clear();
                    custName.Clear();
                    custAddress.Clear();
                    custPhone.Clear();

                    conn.Close();
                    Populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }


        private void customerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (customerDGV.SelectedRows.Count > 0)

            {
                var SelectedRow = customerDGV.SelectedRows[0];

                if (SelectedRow.Cells.Count > 3)
                {

                    custID.Text = SelectedRow.Cells[0].Value.ToString();
                    custName.Text = SelectedRow.Cells[1].Value.ToString();
                    custAddress.Text = SelectedRow.Cells[2].Value.ToString();
                    custPhone.Text = SelectedRow.Cells[3].Value.ToString();

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
            if (custID.Text == ""|| custAddress.Text==""|| custPhone.Text=="")
            {
                MessageBox.Show("Missing Customer Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    conn.Open();
                    string quaery = "update CustomerTbl set Cus_Add = '" + custAddress.Text + "',Cus_Phone = '" + custPhone.Text + "'where Cus_ID = '" + custID.Text + "';";
                    SqlCommand cmd = new SqlCommand(quaery, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Details Successfully Updated!");

                    custID.Clear();
                    custAddress.Clear();
                    custPhone.Clear();

                    conn.Close();
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
            if (custID.Text == "")
            {
                MessageBox.Show("Missing Customer Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    conn.Open();
                    string quaery = "delete from CustomerTbl where Cus_ID = " + custID.Text + ";";
                    SqlCommand cmd = new SqlCommand(quaery, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Deleted Successfully!");

                    custID.Clear();
                    

                    conn.Close();
                    Populate();

                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            Populate();
        }
    }
}
