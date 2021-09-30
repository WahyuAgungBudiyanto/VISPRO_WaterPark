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
    public partial class LearnMore : Form
    {
        public LearnMore()
        {
            InitializeComponent();
        }

        //membuat index untuk show imageList
        int tambah = 0;
        private void LearnMore_Load(object sender, EventArgs e)
        {
            //setiap form load, picturebox akan diisi index 0 yaitu foto pertama dari imageList
            pictureBox_imageList.Image = imageList1.Images[tambah];
        }

        private void guna2Button_back_Click(object sender, EventArgs e)
        {
            //Digunakan untuk menutup form LearnMore dan pindah ke AfterSplash1
            AfterSplash1 form = new AfterSplash1();
            this.Hide();
            
        }


        //Toggle Galery Next and Previous
        private void btn_next_Click(object sender, EventArgs e)
        {
            //Disini dibuat setiap klik Next index di tambah variabel akan berpindah mulai dari 1 - 5 foto
            if (tambah < 6)
            {
                tambah++;

            }
            //Jika sudah melewati akan muncul messageBox
            else
            {
                MessageBox.Show("There's no image left to show!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Disini akan memindahkan index nya ke pictureBox
            pictureBox_imageList.Image = imageList1.Images[tambah];

        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            //Disini untuk tombol kembali, jadi index akan berkurang dan akan ditampilkan di pictureBox
            if(tambah > 0)
            {
                tambah--;
            }
            else
            {
                MessageBox.Show("There's no image left to show!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            pictureBox_imageList.Image = imageList1.Images[tambah];
        }

        //Ini adalah di Ulasan Tab
        private void btn_submit_Click(object sender, EventArgs e)
        {
            //Membuat validation jika tidak diisi semua
            if(TextBox_nama.Text == "" || bunifuRating.Value == 0 || richTextBox_review.Text == "")
            {

                MessageBox.Show("Please fill all the input!", "Submit Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Disini membuat button nya hanya bisa ditekan 1 kali.
                btn_submit.Enabled = false;

                string review = richTextBox_review.Text;
                richTextBox_result.Text = review;

                string nama = TextBox_nama.Text;
                label_nama.Text = nama;

                //Disini untuk menangkap rating dari 1 - 5
                if (bunifuRating.Value == 1)
                {
                    bunifuRating_result.Value = 1;

                }
                if (bunifuRating.Value == 2)
                {
                    bunifuRating_result.Value = 2;

                }
                if (bunifuRating.Value == 3)
                {
                    bunifuRating_result.Value = 3;

                }
                if (bunifuRating.Value == 4)
                {
                    bunifuRating_result.Value = 4;

                }
                if (bunifuRating.Value == 5)
                {
                    bunifuRating_result.Value = 5;

                }

                //Update Star
                int star5 = 156; int star4 = 6; int star3 = 3; int star2 = 0; int star1 = 0;
                int totalstar = 165;
                if (bunifuRating.Value == 1)
                {
                    star1 += 1;
                    label_1star.Text = Convert.ToString(star1);
                    label_totalstar.Text = Convert.ToString(totalstar + 1);
                }
                if (bunifuRating.Value == 2)
                {
                    star2 += 1;
                    label_2star.Text = Convert.ToString(star2);
                    label_totalstar.Text = Convert.ToString(totalstar + 1);
                }
                if (bunifuRating.Value == 3)
                {
                    star3 += 1;
                    label_3star.Text = Convert.ToString(star3);
                    label_totalstar.Text = Convert.ToString(totalstar + 1);
                }
                if (bunifuRating.Value == 4)
                {
                    star4 += 1;
                    label_4star.Text = Convert.ToString(star4);
                    label_totalstar.Text = Convert.ToString(totalstar + 1);
                }
                if (bunifuRating.Value == 5)
                {
                    star5 += 1;
                    label_5star.Text = Convert.ToString(star5);
                    label_totalstar.Text = Convert.ToString(totalstar + 1);
                }
            }
            
            
        }

        //Disini jika star di tekan dari 1 - 5 akan muncul berbagai warna berdasarkan nomor star
        private void bunifuRating_onValueChanged(object sender, EventArgs e)
        {
            if (bunifuRating.Value == 1)
            {
                
                bunifuRating.ForeColor = Color.Red;
            }
            if (bunifuRating.Value == 2)
            {
                
                bunifuRating.ForeColor = Color.Red;
            }
            if (bunifuRating.Value == 3)
            {
                
                bunifuRating.ForeColor = Color.Orange;
            }
            if (bunifuRating.Value == 4)
            {

                bunifuRating.ForeColor = Color.Lime;
            }
            if (bunifuRating.Value == 5)
            {

                bunifuRating.ForeColor = Color.Lime;
            }
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
