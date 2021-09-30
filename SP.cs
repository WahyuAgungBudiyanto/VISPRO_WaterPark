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

    public partial class SP : Form
    {
        public SP()
        {
            InitializeComponent();
        }
        private void Form_Dashboard_Load(object sender, EventArgs e)
        {
           
        }

        private void timer_splash_Tick(object sender, EventArgs e)
        {
        //Jika timer interval telah selesai, form ini akan ditutup dan form AfterSplash1 akan muncul
            timer_splash.Stop();
            AfterSplash1 form = new AfterSplash1();
            form.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
