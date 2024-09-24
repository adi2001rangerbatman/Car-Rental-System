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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\CarRentaldb.mdf;Integrated Security=True;Connect Timeout=30;");
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //car count
            string quary_car = "select Count(*) from CarTbl";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(quary_car,conn);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            carLable.Text = dt.Rows[0][0].ToString();

            //customer count
            string quary_cus = "select Count(*) from CustomerTbl";
            SqlDataAdapter sqlDataAdapterCustomres = new SqlDataAdapter(quary_cus, conn);
            DataTable dtCus = new DataTable();
            sqlDataAdapterCustomres.Fill(dtCus);
            customerLbl.Text = dtCus.Rows[0][0].ToString();

            //user count
            string quary_user = "select Count(*) from UserTbl";
            SqlDataAdapter sqlDataAdapterUser = new SqlDataAdapter(quary_user, conn);
            DataTable dt_user = new DataTable();
            sqlDataAdapterUser.Fill(dt_user);
            userLbl.Text = dt_user.Rows[0][0].ToString();
        }

        private void userLbl_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_car_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }
    }
}
