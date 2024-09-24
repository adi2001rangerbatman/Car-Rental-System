using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace Car_Rental_System
{
    public partial class Car : Form
    {
        public Car()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\CarRentaldb.mdf;Integrated Security=True;Connect Timeout=30;");
        private void Populate()
        {
            conn.Open();
            string quary = "select * from CarTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(quary, conn);
            SqlCommandBuilder command = new SqlCommandBuilder(adapter);

            var userDataSet = new DataSet();
            adapter.Fill(userDataSet);

            CarDGV.DataSource = userDataSet.Tables[0];
            conn.Close();
        }
        private void btn_car_add_Click(object sender, EventArgs e)
        {
            if (carRegNo.Text == "" || carBrand.Text == "" || carModel.Text == "" || carPrize.Text =="")
            {
                MessageBox.Show("Missing Car  Information","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    conn.Open();

                    string quaery = "insert into CarTbl values(" + carRegNo.Text + ",'" + carBrand.Text + "','" + carModel.Text + "','"+availableCB.SelectedItem.ToString()+ "','"+carPrize.Text+"')";
                    SqlCommand cmd = new SqlCommand(quaery, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Successfully Added!");

                    carBrand.Clear();
                    carModel.Clear();
                    carRegNo.Clear();
                    carPrize.Clear();
                    availableCB.Items.Clear();


                    conn.Close();
                    Populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }
     
        private void Car_Load(object sender, EventArgs e)
        {
            Populate();
           
        }

        private void btb_car_delete_Click(object sender, EventArgs e)
        {
            if (carRegNo.Text == "")
            {
                MessageBox.Show("Missing Car  Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    conn.Open();
                    string quaery = "delete from CarTbl where RegNum = " + carRegNo.Text + ";";
                    SqlCommand cmd = new SqlCommand(quaery, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Deleted Successfully!");

                    carRegNo.Clear();
                    availableCB.Items.Clear();

                    conn.Close();
                    Populate();

                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void btn_car_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void btn_car_edit_Click(object sender, EventArgs e)
        {
            if (carRegNo.Text == "")
            {
                MessageBox.Show("Missing Car  Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    conn.Open();
                    string quaery = "update carTbl set Price = '" + carPrize.Text + "',Available = '"+ availableCB.Text +"'where RegNum = '"+ carRegNo.Text +"';";
                    SqlCommand cmd = new SqlCommand(quaery, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Details Successfully Updated!");

                    carRegNo.Clear();
                    carPrize.Clear();
                    
                    conn.Close();
                    Populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void CarDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CarDGV.SelectedRows.Count > 0)

            {
                var SelectedRow = CarDGV.SelectedRows[0];

                if (SelectedRow.Cells.Count > 4)
                {

                    carRegNo.Text = SelectedRow.Cells[0].Value + String.Empty;
                    carBrand.Text = SelectedRow.Cells[1].Value + String.Empty;
                    carModel.Text = SelectedRow.Cells[2].Value + String.Empty;
                    carPrize.Text = SelectedRow.Cells[4].Value + String.Empty;
                    availableCB.Text = SelectedRow.Cells[3].Value + String.Empty;

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

        private void availableCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Populate();
        }

        private void Search_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string flag = "";
            if (Search.SelectedItem.ToString() == "Available") 
            {
                flag = "Yes";
            }
            else 
            {
                flag = "No";
            }
            conn.Open();
            string quary = "select * from CarTbl where Available = '" + flag + "';";
            SqlDataAdapter adapter = new SqlDataAdapter(quary, conn);
            SqlCommandBuilder command = new SqlCommandBuilder(adapter);

            var userDataSet = new DataSet();
            adapter.Fill(userDataSet);

            CarDGV.DataSource = userDataSet.Tables[0];
            conn.Close();
        }

        private void Search_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
