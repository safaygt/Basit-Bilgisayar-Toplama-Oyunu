// SAFA YİĞİT
// B201200001
// BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ 1. SINIF 





using DönemÖdevi.Library.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DönemÖdevi
{
    public partial class AnaMenü : Form
    {


        
        public AnaMenü()
        {
            InitializeComponent();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AnaMenü_KeyDown(object sender, KeyEventArgs e)
        {




        }

        private void btn_basla_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btn_basla_Click(object sender, EventArgs e)
        {



            
        }

        private void btn_basla_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_adet_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {


                if ((txt_isim.Text == "") || (txt_soyisim.Text == "") || (txt_adet.Text == ""))
                {

                    MessageBox.Show("Lütfen her alanı doldurunuz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                else if (txt_isim.Text != "" && txt_soyisim.Text != "" && txt_adet.Text != "")
                {
                    
                    

                        BilgisayarToplama bilgisayar = new BilgisayarToplama();

                        bilgisayar.lbl_isim.Text = txt_isim.Text;
                        bilgisayar.lbl_soyisim.Text = txt_soyisim.Text;
                        bilgisayar.lbl_kalan.Text = txt_adet.Text;
                        bilgisayar.Show();
                        Hide();
                    bestScores best = new bestScores();

                    best.isim = txt_isim.Text;
                    best.soyisim = txt_soyisim.Text;
                    best.adet = txt_adet.Text;
                        
                    
                }

                


            }
            



        }

        private void txt_soyisim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {


                if ((txt_isim.Text == "") || (txt_soyisim.Text == "") || (txt_adet.Text == ""))
                {

                    MessageBox.Show("Lütfen her alanı doldurunuz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                else if (txt_isim.Text != "" && txt_soyisim.Text != "" && txt_adet.Text != "")
                {



                    BilgisayarToplama bilgisayar = new BilgisayarToplama();

                    bilgisayar.lbl_isim.Text = txt_isim.Text;
                    bilgisayar.lbl_soyisim.Text = txt_soyisim.Text;
                    bilgisayar.lbl_kalan.Text = txt_adet.Text;
                    bilgisayar.Show();
                    Hide();
                }




            }
        }

        private void txt_isim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {


                if ((txt_isim.Text == "") || (txt_soyisim.Text == "") || (txt_adet.Text == ""))
                {

                    MessageBox.Show("Lütfen her alanı doldurunuz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                else if (txt_isim.Text != "" && txt_soyisim.Text != "" && txt_adet.Text != "")
                {



                    BilgisayarToplama bilgisayar = new BilgisayarToplama();

                    bilgisayar.lbl_isim.Text = txt_isim.Text;
                    bilgisayar.lbl_soyisim.Text = txt_soyisim.Text;
                    bilgisayar.lbl_kalan.Text = txt_adet.Text;
                    bilgisayar.Show();
                   
                    
                    Hide();
                }




            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            oyunKlavye klavye = new oyunKlavye();

            klavye.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            bestScores best = new bestScores();
            best.Show();

            


        }

        private void AnaMenü_Load(object sender, EventArgs e)
        {

        }

        private void txt_adet_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
