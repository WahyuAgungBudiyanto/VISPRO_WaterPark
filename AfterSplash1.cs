using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Whoose_Water_Park__Lite_Software_Development_
{
    public partial class AfterSplash1 : Form
    {
        public AfterSplash1()
        {
            InitializeComponent();
        }

        private void guna2Button_continue_Click(object sender, EventArgs e)
        {
            //Jika tombol di tekan, maka form ini akan hilang dan AfterSplash2 akan di munculkan
            AfterSplash2 form = new AfterSplash2();
            this.Hide();
            form.Show();
        }

        private void guna2Button_learn_Click(object sender, EventArgs e)
        {
            //Disini untuk berpindah ke LearnMore Form tetapi form ini tidak di hilangkan
            LearnMore form = new LearnMore();
            form.Show();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            //Jika klik tombol paling kanan, akan menghentikan aplikasi
            Application.Exit();
        }

        private void btn_Maximize_Click(object sender, EventArgs e)
        {
            //Untuk membuat form full screen, dan akan menghilangkan picturebox yang di samping
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                pictureBox_waterDown.Hide();
                pictureBox_waterLeft.Hide();
                pictureBox_waterRight.Hide();
                pictureBox_waterUp.Hide();
            }
            else
            {
               //membuat form kembali normal dan memunculkan picturebox di samping
                this.WindowState = FormWindowState.Normal;
                pictureBox_waterDown.Show();
                pictureBox_waterLeft.Show();
                pictureBox_waterRight.Show();
                pictureBox_waterUp.Show();
            }
        }

        private void btn_Minimized_Click(object sender, EventArgs e)
        {
            //Untuk mengecilkan form
            this.WindowState = FormWindowState.Minimized;
        }

        
    }
}
