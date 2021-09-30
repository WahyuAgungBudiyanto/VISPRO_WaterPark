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
    public partial class AfterSplash2 : Form
    {
    
        public int TotalHargaTiket = 0;
        public int indexKe = 0;
        public string[] AllTickets;
        public int amount = 0;
        
        public int savediscount;
        public AfterSplash2()
        {
            InitializeComponent();
        }
        private void AfterSplash2_Load(object sender, EventArgs e)
        {
            groupBox_banyakOrang.Show();
            groupBox_tinggi.Hide();
            groupBox_priceDesc.Hide();
            groupBox_totalHarga.Hide();
            btn_lanjut1.Show();
            btn_lanjut2.Hide();
            btn_save.Hide();
            
        }

        private void btn_lanjut1_Click(object sender, EventArgs e)
        {
            if (NumericUpDown_pemesan.Value < 1 || NumericUpDown_pemesan.Value > 30)
            {
                resetData();
                MessageBox.Show("Masukan jumlah tiket mulai dari 1 - 30", "Submit Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                groupBox_banyakOrang.Hide();
                groupBox_tinggi.Show();
                btn_save.Show();
                groupBox_priceDesc.Show();
                btn_lanjut1.Hide();


                label_pemesan.Font = new Font(label_pemesan.Font, FontStyle.Regular);
                label_harga.Font = new Font(label_harga.Font, FontStyle.Bold);

                amount = Convert.ToInt32(NumericUpDown_pemesan.Value);
                AllTickets = new string[amount];
                label_orangke.Text = Convert.ToString(indexKe + 1);
            }
            
            
        }
        










        private void btn_save_Click(object sender, EventArgs e)
        {
            if (NumericUpDown_tinggi.Value < 1)
            {
                MessageBox.Show("Mohon masukan tinggi orang dengan benar!", "Submit Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                
                AllTickets[indexKe] = Convert.ToString(NumericUpDown_tinggi.Value);
                TotalHargaTiket += GetPrice((int)NumericUpDown_tinggi.Value); // Add new price to old
                NumericUpDown_tinggi.Value = 0;
                indexKe++;

                if (indexKe > AllTickets.Length - 1)
                {
                    groupBox_banyakOrang.Hide();
                    groupBox_priceDesc.Show();
                    groupBox_tinggi.Show();
                    btn_lanjut1.Hide();
                    btn_lanjut2.Show();
                    btn_save.Show();
                    btn_kembali.Hide();
                    

                    label_harga.Font = new Font(label_harga.Font, FontStyle.Bold);
                    label_pemesan.Cursor = Cursors.Default;

                    label_displayTiket.Show();
                    label_displayTiket.Text = Convert.ToString(TotalHargaTiket);
                    groupBox_totalHarga.Show();
                    
                    if(NumericUpDown_pemesan.Value > 20)
                    {
                        label_discount.Visible = true;
                        guna2HtmlLabel9.Visible = true;


                        label_displayTiket.Text = TotalHargaTiket.ToString();
                    }
                    else
                    {

                        label_displayTiket.Text = TotalHargaTiket.ToString();
                    }

                    btn_save.Enabled = false;

                    return;
                }
                
                label_orangke.Text = Convert.ToString(indexKe + 1);
            }

            }

            public int GetPrice(int height)
        {
            if (height >= 0 && height <= 80)
            {
                return 0;
            }
            else if (height >= 81 && height <= 120)
            {
                return 25000;
            }
            else if (height >= 121 && height <= 140)
            {
                return 30000;
            }
            else if (height >= 141)
            {
                return 50000;
            }
            return 0;
        }
        void resetData()
        {
            AllTickets = new string[0];
            indexKe = 0;
            TotalHargaTiket = 0;
            NumericUpDown_pemesan.Value = 0;
            NumericUpDown_tinggi.Value = 0;
            btn_save.Enabled = true;
        }
        private void label_pemesan_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Apakah kamu yakin untuk kembali (Data mu akan di hapus).", "Reset Data", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                AfterSplash2_Load(sender, e);
                resetData();

                label_discount.Visible = false;
                guna2HtmlLabel9.Visible = false;


                label_pemesan.Font = new Font(label_pemesan.Font, FontStyle.Bold);
                label_harga.Font = new Font(label_harga.Font, FontStyle.Regular);
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
            
            
        }

        private void label_pemesan_MouseHover(object sender, EventArgs e)
        {
            label_pemesan.Cursor = Cursors.Hand;
        }

       
        private void btn_close_Click(object sender, EventArgs e)
        {
            //Jika klik tombol paling kanan, akan menghentikan aplikasi
            Application.Exit();
        }

        private void btn_Minimized_Click(object sender, EventArgs e)
        {
            // Untuk mengecilkan form
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_kembali_Click(object sender, EventArgs e)
        {
            AfterSplash1 form = new AfterSplash1();
            this.Hide();
            form.Show();
        }

        private void btn_lanjut2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Apakah anda yakin untuk melanjutkan?", "WARNING", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Dashboard form = new Dashboard();
                
                form.afterSplashReference = this;
                
                this.Hide();
                form.Show();

               
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
        
        /*private void btn_next_Click(object sender, EventArgs e)
        {
            btn_save.Enabled = true;
            if (indexKe < AllTickets.Length - 1)
            {
                indexKe++;

            }
            else
            {
                btn_save.Enabled = false;
                MessageBox.Show("Ini adalah orang terakhir!", "Next Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            label_orangke.Text = Convert.ToString(AllTickets[indexKe]);
            NumericUpDown_tinggi.Value = Convert.ToInt32(AllTickets[indexKe]);


        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            btn_save.Enabled = true;
            if (indexKe > 0)
            {
                indexKe--;
            }
            else
            {
                MessageBox.Show("Ini adalah orang Pertama!", "Prev Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            label_orangke.Text = Convert.ToString(AllTickets[indexKe]);
            NumericUpDown_tinggi.Value = Convert.ToInt32(AllTickets[indexKe]);

        }*/
    }
}
