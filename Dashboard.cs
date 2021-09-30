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
    public partial class Dashboard : Form
    {
        public int totalnumeric;
        public int totalAll;
        public int ifjumlahtiket;
        public int totalBR = 0;
        public string displaytotal;
        public int totalMK = 0;
        public int ambilTotal;
        public AfterSplash2 afterSplashReference = new AfterSplash2();
        public Dashboard()
        {
            InitializeComponent();

        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            groupBox_BR.Height = 144;
            groupBox_MK.Hide();
            groupBox_LK.Hide();
            total_Allbtn.Hide();
            btn_restartMore.Hide();

            ifjumlahtiket = afterSplashReference.amount;
            if (ifjumlahtiket > 20)
            {
                label_disTotalHarga.Text = afterSplashReference.savediscount.ToString();

            }
            else
            {
                label_disTotalHarga.Text = afterSplashReference.TotalHargaTiket.ToString();
            }
            label_disJumTiket.Text = ifjumlahtiket.ToString();
            displaytotal = afterSplashReference.TotalHargaTiket.ToString();
            label_disTotalHarga.Text = displaytotal;
        }


        private void btn_BRyes_Click(object sender, EventArgs e)
        {
            btn_BRclear.Enabled = true;
            groupBox_BR.Height = 426;
            groupBox_MK.Hide();
            groupBox_LK.Hide();

            NumericUpDown_anak.Value = 0;
            NumericUpDown_remaja.Value = 0;
            NumericUpDown_dewasa.Value = 0;
            label_bajuRenang.Text = "...";
            label_disBayuRenang.Text = "...";
        }
        private void btn_BRno_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("               Apakah anda yakin untuk melanjutkan?\n\n" + "   🔴Diingatkan bahwa anda harus membawa baju renang🔴", "WARNING", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                totalBR = 0;
                groupBox_BR.Height = 144;
                label_disBayuRenang.Text = "0";
                label_disMakanan.Text = "...";
                groupBox_MK.Show();
                groupBox_LK.Hide();
                groupBox_MK.Height = 144;
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
        private void btn_addBR_Click(object sender, EventArgs e)
        {
            if(NumericUpDown_anak.Value <1 && NumericUpDown_remaja.Value < 1 && NumericUpDown_dewasa.Value < 1)
            {
                DialogResult dialogResult = MessageBox.Show("               Apakah anda yakin untuk melanjutkan?\n\n" + "   🔴Diingatkan bahwa anda harus membawa baju renang🔴", "WARNING", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    groupBox_MK.Show();
                    groupBox_MK.Height = 144;

                    totalBR = Convert.ToInt32(NumericUpDown_anak.Value * 10000) + Convert.ToInt32(NumericUpDown_remaja.Value * 15000) + Convert.ToInt32(NumericUpDown_dewasa.Value * 20000);
                    label_bajuRenang.Text = totalBR.ToString();
                    label_disBayuRenang.Text = totalBR.ToString();

                    totalnumeric = Convert.ToInt32(NumericUpDown_anak.Value + NumericUpDown_remaja.Value + NumericUpDown_dewasa.Value);
                }
                else if (dialogResult == DialogResult.No)
                {
                }
            }
            else
            {
                groupBox_MK.Show();
                groupBox_MK.Height = 144;

                totalBR = Convert.ToInt32(NumericUpDown_anak.Value * 10000) + Convert.ToInt32(NumericUpDown_remaja.Value * 15000) + Convert.ToInt32(NumericUpDown_dewasa.Value * 20000);
                label_bajuRenang.Text = totalBR.ToString();
                label_disBayuRenang.Text = totalBR.ToString();

                totalnumeric = Convert.ToInt32(NumericUpDown_anak.Value + NumericUpDown_remaja.Value + NumericUpDown_dewasa.Value);
            }
            
           
        }
        private void btn_BRclear_Click(object sender, EventArgs e)
        {
            groupBox_MK.Hide();
            groupBox_LK.Hide();
            NumericUpDown_anak.Value = 0;
            NumericUpDown_dewasa.Value = 0;
            NumericUpDown_remaja.Value = 0;
            label_disMakanan.Text = "...";
            label_bajuRenang.Text = "...";
            label_disBayuRenang.Text = "...";
        }

        
        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            totalMK += 10000;
            label_totalMakanan.Text = Convert.ToString(totalMK);
        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            totalMK += 15000;
            label_totalMakanan.Text = Convert.ToString(totalMK);
        }

        private void guna2CirclePictureBox3_Click(object sender, EventArgs e)
        {
            totalMK += 20000;
            label_totalMakanan.Text = Convert.ToString(totalMK);
        }
        private void btn_addMK_Click(object sender, EventArgs e)
        {
            label_totalMakanan.Text = totalMK.ToString();
            label_disMakanan.Text = totalMK.ToString();
            btn_BRyes.Enabled = false;
            groupBox_LK.Show();
            groupBox_LK.Height = 144;
        }
        private void btn_clearMK_Click(object sender, EventArgs e)
        {
            groupBox_LK.Hide();
            btn_BRyes.Enabled = false;
            btn_BRno.Enabled = false;
            btn_BRclear.Enabled = false;
            btn_addBR.Enabled = false;
            totalMK = 0;
            label_disMakanan.Text = "...";
            label_totalMakanan.Text = "...";
        }
        private void btn_MKya_Click(object sender, EventArgs e)
        {
            groupBox_MK.Show();
            groupBox_LK.Hide();
            groupBox_MK.Height = 426;
            label_disMakanan.Text = "...";
            label_totalMakanan.Text = "...";
            btn_BRyes.Enabled = false;
            btn_BRno.Enabled = false;
            btn_BRclear.Enabled = false;
            btn_addBR.Enabled = false;
        }

        private void btn_MKno_Click(object sender, EventArgs e)
        {
            totalMK = 0;
            label_disMakanan.Text = "0";
            groupBox_MK.Height = 144;
            btn_BRyes.Enabled = false;
            btn_BRno.Enabled = false;
            btn_BRclear.Enabled = false;
            btn_addBR.Enabled = false;
            groupBox_LK.Show();
            groupBox_LK.Height = 144;
        }


        public int totalLoker;
        private void btn_LKyes_Click(object sender, EventArgs e)
        {
            groupBox_LK.Height = 426;
            label_displayLoker.Text = "...";
            btn_BRyes.Enabled = false;
            btn_BRno.Enabled = false;
            btn_BRclear.Enabled = false;
            btn_addBR.Enabled = false;
            btn_MKya.Enabled = false;
            btn_MKno.Enabled = false;
            guna2CirclePictureBox1.Enabled = false;
            guna2CirclePictureBox2.Enabled = false;
            guna2CirclePictureBox3.Enabled = false;
            btn_clearMK.Enabled = false;
            btn_addMK.Enabled = false;
            total_Allbtn.Hide();
        }
        private void btn_LKno_Click(object sender, EventArgs e)
        {
            total_Allbtn.Show();
            btn_BRyes.Enabled = false;
            btn_BRno.Enabled = false;
            btn_BRclear.Enabled = false;
            btn_addBR.Enabled = false;
            btn_MKya.Enabled = false;
            btn_MKno.Enabled = false;
            guna2CirclePictureBox1.Enabled = false;
            guna2CirclePictureBox2.Enabled = false;
            guna2CirclePictureBox3.Enabled = false;
            btn_clearMK.Enabled = false;
            btn_addMK.Enabled = false;
            groupBox_LK.Height = 144;
            totalLoker = 0;
            label_displayLoker.Text = "0";
        }
        private void btn_addLK_Click(object sender, EventArgs e)
        {
            total_Allbtn.Show();

            totalLoker = Convert.ToInt32((num_kecil.Value * 5000) + (num_besar.Value * 10000));
            label_loker.Text = Convert.ToString(totalLoker);
            label_displayLoker.Text = totalLoker.ToString();
        }

        private void btn_clearLK_Click(object sender, EventArgs e)
        {
            total_Allbtn.Hide();
            num_kecil.Value = 0;
            num_besar.Value = 0;
            label_loker.Text = "...";
            label_displayLoker.Text = "...";
        }

        private void total_Allbtn_Click(object sender, EventArgs e)
        {
            guna2Button1.Hide();
            total_Allbtn.Hide();
            btn_restartMore.Show();
            Invoice form = new Invoice();
            form.dashboardReference = this;
            this.Show();
            form.Show();
            

            ambilTotal = Convert.ToInt32(displaytotal) + totalBR + totalMK + totalLoker;

            label_totalAll.Text = ambilTotal.ToString();
        }
        private void btn_restartMore_Click(object sender, EventArgs e)
        {
            Invoice form = new Invoice();
            form.Hide();
            
            this.Dispose(false);
            AfterSplash2 form_reset = new AfterSplash2();
            form_reset.Show();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("               Apakah anda yakin untuk melanjutkan?\n\n" + "   🔴Diingatkan bahwa semua data anda akan hilang🔴", "WARNING", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Invoice form = new Invoice();
                form.Hide();

                this.Dispose(false);
                AfterSplash2 form_reset = new AfterSplash2();
                form_reset.Show();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
            
        }








        private void guna2Button5_Click(object sender, EventArgs e)
        {



        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {



        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            




        }

        private void label_loker_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        

        private void groupBox_BR_Enter(object sender, EventArgs e)
        {

        }

        
    }
}
