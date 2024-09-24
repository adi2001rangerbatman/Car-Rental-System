using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Car_Rental_System
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            this.timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            SplashProgressBar.Value = startpoint;
            if (SplashProgressBar.Value == 100) 
            {
                timer1.Stop();
                SplashProgressBar.Value = 0;

                this.Hide();
                Login login = new Login();
                login.Show();
                

            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
