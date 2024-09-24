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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }
SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\CarRentaldb.mdf;Integrated Security=True;Connect Timeout=30;");
        private void Populate() 
        {
            conn.Open();
            string quary = "select * from UserTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(quary,conn);
            SqlCommandBuilder command = new SqlCommandBuilder(adapter);

            var userDataSet = new DataSet();
            adapter.Fill(userDataSet);

            UserDGV.DataSource = userDataSet.Tables[0];
            conn.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Uid.Text == "" || Uname.Text == "" || Pwd.Text == "")
            {
                MessageBox.Show("Missing User Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                try 
                {
                    conn.Open();
                    string quaery = "insert into UserTbl values("+Uid.Text+",'"+Uname.Text+"','"+Pwd.Text+"')";
                    SqlCommand cmd = new SqlCommand(quaery, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Successfully Added!");


                    Uid.Clear();
                    Uname.Clear();
                    Pwd.Clear();

                    conn.Close();
                    Populate();
                } 
                catch(Exception Myex) 
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UserDGV.SelectedRows.Count > 0)

            {
                var SelectedRow = UserDGV.SelectedRows[0];

                if (SelectedRow.Cells.Count > 2)
                {

                    Uid.Text = SelectedRow.Cells[0].Value.ToString();
                    Uname.Text = SelectedRow.Cells[1].Value.ToString();
                    //Pwd.Text = SelectedRow.Cells[2].Value.ToString();

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

        private void Users_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void btb_delete_Click(object sender, EventArgs e)
        {
            if (Uid.Text == "")
            {
                MessageBox.Show("Missing User Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                try
                {
                    conn.Open();
                    string quaery = "delete from UserTbl where Id = " + Uid.Text + ";";
                    SqlCommand cmd =new SqlCommand(quaery, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Deleted Successfully!");
                    

                    conn.Close();
                    Populate();

                }
                catch (Exception Myex) 
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (Uid.Text == "" || Uname.Text == "" || Pwd.Text == "")
            {
                MessageBox.Show("Missing User Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    conn.Open();
                    string quaery = "update UserTbl set username= '" + Uname.Text + "',password='" + Pwd.Text + "'where id = "+Uid.Text+"";
                    SqlCommand cmd = new SqlCommand(quaery, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Successfully Updated!");

                    Uid.Clear();
                    Uname.Clear();
                    Pwd.Clear();

                    conn.Close();
                    Populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
         
        }

        private void Pwd_TextChanged(object sender, EventArgs e)
        {
            Pwd.PasswordChar = '●'; 

        }
    }
}
