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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\CarRentaldb.mdf;Integrated Security=True;Connect Timeout=30;");

        private void Auth() 
        {
            conn.Open();
            string query = "select Count(*) from UserTbl where username ='" + lgn_txt.Text + "' and password ='" + lgPwd.Text + "'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);

            conn.Close();

            if (lgn_txt.Text != "" || lgPwd.Text != "")
            {
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wrong Username Or Passsword !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Username or Password cannot be Empty !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Auth();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            lgPwd.PasswordChar = '●'; // Password masking for added security

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lgn_txt.Clear();
            lgPwd.Clear();
        }
    }
}
