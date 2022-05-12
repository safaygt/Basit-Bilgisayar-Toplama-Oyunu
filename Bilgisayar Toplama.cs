// SAFA YİĞİT
// B201200001
// BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ 1. SINIF 





using DönemÖdevi.Library.Concrete;
using DönemÖdevi.Library.Enum;
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
    public partial class BilgisayarToplama : Form
    {
        AnaMenü anamenü = new AnaMenü();
        private readonly ConcreteOyun concreteOyun;
        private static readonly Random Random = new Random();





        List<PictureBox> cisimler = new List<PictureBox>();

        public int ramTekrar = 0;

        public int cpuTekrar = 0;

        public int gpuTekrar = 0;

        public int kalan_adet;
        public int yapilan_adet = 0;
        public int sayac = 0;





        public BilgisayarToplama()
        {
            InitializeComponent();
            concreteOyun = new ConcreteOyun(panel1);
            concreteOyun.gecenSureDegisti += _OyunGecenSureDegisti;
            concreteOyun.baslat();





        }

        private void Form1_Load(object sender, EventArgs e)
        {


            pictureRam.Top = -550;
            pictureRam2.Top = -750;
            pictureCpu.Top = -600;
            pictureCpu2.Top = -800;

            pictureGpu.Top = -650;
            pictureGpu2.Top = -850;
            pictureQuestion.Top = -2000;


        }

        private void BilgisayarToplama_KeyDown(object sender, KeyEventArgs e)
        {
            int x = pic_kutu.Location.X;


            if (e.KeyCode == Keys.Right && pic_kutu.Location.X + pic_kutu.Width < 630)
            {
                x += 10;
            }
            if (e.KeyCode == Keys.Left && pic_kutu.Location.X > 0)
            {
                x -= 10;
            }
            pic_kutu.Location = new Point(x, 0);




            if (timer_hesap.Enabled == true && timer_oyun.Enabled == true)
            {
                if (e.KeyCode == Keys.P)
                {
                    timer_hesap.Enabled = false;
                    timer_oyun.Enabled = false;
                    concreteOyun.durdur();
                }


            }

            else if (timer_hesap.Enabled == false && timer_oyun.Enabled == false)
            {
                if (e.KeyCode == Keys.P)
                {
                    timer_hesap.Enabled = true;
                    timer_oyun.Enabled = true;
                    concreteOyun.baslat();
                }


            }




        }

        public void _OyunGecenSureDegisti(object sender, EventArgs e)
        {
            lbl_sure.Text = concreteOyun.gecenSure.TotalSeconds.ToString();
        }




        private void pic_ram_Click(object sender, EventArgs e)
        {

        }

        private void pic_gpu_Click(object sender, EventArgs e)
        {

        }


        private void pic_cpu_Click(object sender, EventArgs e)
        {

        }



        private void timer_oyun_Tick(object sender, EventArgs e)
        {



            sayac++;






            if (sayac <= 2150)
            {

                pictureRam.Top += 5;
                pictureRam2.Top += 5;
                pictureCpu.Top += 5;

                pictureCpu2.Top += 5;
                pictureGpu.Top += 5;
                pictureGpu2.Top += 5;



            }

            else if (sayac > 2150)
            {
                pictureRam.Top += 10;
                pictureRam2.Top += 10;
                pictureCpu.Top += 10;

                pictureCpu2.Top += 10;
                pictureGpu.Top += 10;
                pictureGpu2.Top += 10;


            }



            // RAM KODLARI



            if (pictureRam.Location.Y > 569 + pictureRam.Height)
            {
                pictureRam.Left = Random.Next(panel3.Width - panel2.Width - 40);
                pictureRam.Top = -50;
            }

            if ((pictureRam.Location.Y == 340) && !(pictureRam.Location.X + pictureRam.Width < pic_kutu.Location.X) && !(pic_kutu.Location.X + pic_kutu.Width < pictureRam.Location.X))
            {


                ramTekrar++;
                pictureRam.Top = -250;
                pictureRam.Left = Random.Next(panel3.Width - panel2.Width - 40);
                label6.Text = ramTekrar.ToString();



            }



            if (pictureRam2.Location.Y > 569 + pictureRam2.Height)
            {
                pictureRam2.Left = Random.Next(panel3.Width - panel2.Width - 40);
                pictureRam2.Top = -100;
            }

            if ((pictureRam2.Location.Y == 340) && !(pictureRam2.Location.X + pictureRam2.Width < pic_kutu.Location.X) && !(pic_kutu.Location.X + pic_kutu.Width < pictureRam2.Location.X))
            {


                ramTekrar++;
                pictureRam2.Top = -300;
                pictureRam2.Left = Random.Next(panel3.Width - panel2.Width - 40);
                label6.Text = ramTekrar.ToString();



            }



            // CPU KODLARI


            if (pictureCpu.Location.Y > 569 + pictureCpu.Height)
            {
                pictureCpu.Left = Random.Next(panel3.Width - panel2.Width - 40);
                pictureCpu.Top = -150;
            }

            if ((pictureCpu.Location.Y == 340) && !(pictureCpu.Location.X + pictureCpu.Width < pic_kutu.Location.X) && !(pic_kutu.Location.X + pic_kutu.Width < pictureCpu.Location.X))
            {


                cpuTekrar++;
                pictureCpu.Top = -350;
                pictureCpu.Left = Random.Next(panel3.Width - panel2.Width - 40);
                label4.Text = cpuTekrar.ToString();



            }


            if (pictureCpu2.Location.Y > 569 + pictureCpu2.Height)
            {
                pictureCpu2.Left = Random.Next(panel3.Width - panel2.Width - 40);
                pictureCpu2.Top = -200;
            }

            if ((pictureCpu2.Location.Y == 340) && !(pictureCpu2.Location.X + pictureCpu2.Width < pic_kutu.Location.X) && !(pic_kutu.Location.X + pic_kutu.Width < pictureCpu2.Location.X))
            {


                cpuTekrar++;
                pictureCpu2.Top = -400;
                pictureCpu2.Left = Random.Next(panel3.Width - panel2.Width - 40);
                label4.Text = cpuTekrar.ToString();



            }



            //GPU KODLARI

            if (pictureGpu.Location.Y > 569 + pictureGpu.Height)
            {
                pictureGpu.Left = Random.Next(panel3.Width - panel2.Width - 40);
                pictureGpu.Top = -250;
            }

            if ((pictureGpu.Location.Y == 340) && !(pictureGpu.Location.X + pictureGpu.Width < pic_kutu.Location.X) && !(pic_kutu.Location.X + pic_kutu.Width < pictureGpu.Location.X))
            {


                gpuTekrar++;
                pictureGpu.Top = -450;
                pictureGpu.Left = Random.Next(panel3.Width - panel2.Width - 40);
                label5.Text = gpuTekrar.ToString();



            }




            if (pictureGpu2.Location.Y > 569 + pictureGpu2.Height)
            {
                pictureGpu2.Left = Random.Next(panel3.Width - panel2.Width - 40);
                pictureGpu2.Top = -300;
            }

            if ((pictureGpu2.Location.Y == 340) && !(pictureGpu2.Location.X + pictureGpu2.Width < pic_kutu.Location.X) && !(pic_kutu.Location.X + pic_kutu.Width < pictureGpu2.Location.X))
            {


                gpuTekrar++;
                pictureGpu2.Top = -500;
                pictureGpu2.Left = Random.Next(panel3.Width - panel2.Width - 40);
                label5.Text = gpuTekrar.ToString();



            }


            pictureQuestion.Top += 5;

            if (pictureQuestion.Location.Y > 569 + pictureQuestion.Height)
            {

                pictureQuestion.Left = Random.Next(panel3.Width - panel2.Width - 40);
                pictureQuestion.Top = -2200;
            }

            if ((pictureQuestion.Location.Y == 340) && !(pictureQuestion.Location.X + pictureQuestion.Width < pic_kutu.Location.X) && !(pic_kutu.Location.X + pic_kutu.Width < pictureQuestion.Location.X))
            {

                int rnd = Random.Next(2);

                pictureQuestion.Top = -2100;
                pictureQuestion.Left = Random.Next(panel3.Width - panel2.Width - 40);

                if (rnd == 0)
                {
                    kalan_adet = Convert.ToInt32(lbl_kalan.Text);
                    if (yapilan_adet > 0)
                    {
                        yapilan_adet--;
                        kalan_adet++;
                        lbl_kalan.Text = kalan_adet.ToString();
                        lbl_yapilan.Text = yapilan_adet.ToString();
                    }
                    else
                    {
                        yapilan_adet = 0;
                        kalan_adet++;
                        lbl_kalan.Text = kalan_adet.ToString();
                        lbl_yapilan.Text = yapilan_adet.ToString();

                    }


                }
                else if (rnd == 1)
                {
                    kalan_adet = Convert.ToInt32(lbl_kalan.Text);
                    if (kalan_adet > 0)
                    {
                        kalan_adet--;
                        yapilan_adet++;
                        lbl_kalan.Text = kalan_adet.ToString();
                        lbl_yapilan.Text = yapilan_adet.ToString();
                    }
                    else
                    {
                        kalan_adet = 0;
                        yapilan_adet++;
                        lbl_kalan.Text = kalan_adet.ToString();
                        lbl_yapilan.Text = yapilan_adet.ToString();

                    }

                }




            }







        }

        private void timer_hesap_Tick(object sender, EventArgs e)
        {


            if (Convert.ToInt32(lbl_kalan.Text) > 0)
            {
                if (cpuTekrar >= 1 && gpuTekrar >= 2 && ramTekrar >= 3)
                {
                    if ((cpuTekrar % 1 == 0) && (gpuTekrar % 2 == 0 || gpuTekrar % 2 == 1) && (ramTekrar % 3 == 0 || (ramTekrar % 3 == 1 || ramTekrar % 3 == 2)))
                    {

                        timer_hesap.Enabled = true;

                        kalan_adet = Convert.ToInt32(lbl_kalan.Text);

                        kalan_adet -= 1;

                        lbl_kalan.Text = kalan_adet.ToString();


                        yapilan_adet += 1;
                        lbl_yapilan.Text = yapilan_adet.ToString();



                        ramTekrar = (ramTekrar - 3);
                        cpuTekrar -= 1;
                        gpuTekrar = (gpuTekrar - 2);

                        label4.Text = cpuTekrar.ToString();
                        label5.Text = gpuTekrar.ToString();
                        label6.Text = ramTekrar.ToString();

                    }
                }
            }

            if (Convert.ToInt32(lbl_kalan.Text) <= 0)
            {

                timer_hesap.Stop();
                concreteOyun.durdur();
                timer_oyun.Stop();


                MessageBox.Show("Tebrikler! Oyunu bitirdiniz. ", "CONGRATULATİONS!", MessageBoxButtons.OK, MessageBoxIcon.None);



            }


            






        }

        private void pictureGpu_Click(object sender, EventArgs e)
        {

        }

        private void pictureCpu2_Click(object sender, EventArgs e)
        {

        }
    }
}

