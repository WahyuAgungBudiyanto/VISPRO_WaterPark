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
   
   
    public partial class Invoice : Form
    {
        public int totalAll;
        public int totalAll_wdis;
        public int totalAll2;
        public Dashboard dashboardReference = new Dashboard();
        public AfterSplash2 afterSplashReference = new AfterSplash2();
        public Invoice()
        {
            InitializeComponent();
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            label_disJumTiket.Text = dashboardReference.ifjumlahtiket.ToString();
            label_disTotalHarga.Text = dashboardReference.displaytotal;
            label_disBayuRenang.Text = dashboardReference.totalBR.ToString();
            label_disMakanan.Text = dashboardReference.totalMK.ToString();
            label_displayLoker.Text = dashboardReference.totalLoker.ToString();
            totalAll = Convert.ToInt32(dashboardReference.displaytotal) + dashboardReference.totalBR + dashboardReference.totalMK + dashboardReference.totalLoker;
            if (dashboardReference.ifjumlahtiket > 20)
            {
                label_discount.Visible = true;

                totalAll_wdis = totalAll - (totalAll * 10 / 100);


                label_totalAll.Text = totalAll_wdis.ToString();

            }
            else
            {
                label_totalAll.Text = totalAll.ToString();
            }
            
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Minimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void groupBox_reciept_Enter(object sender, EventArgs e)
        {

        }
    }
}
