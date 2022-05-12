// SAFA YİĞİT
// B201200001
// BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ 1. SINIF 






using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DönemÖdevi
{
    public partial class bestScores : Form
    {
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string adet { get; set; }

        AnaMenü anamenü = new AnaMenü();



        
        public bestScores()
        {
            InitializeComponent();
        }

        private void lbl_bests_Click(object sender, EventArgs e)
        {





        }

        private void bestScores_Load(object sender, EventArgs e)
        {






        }

        private void btn_oku_Click(object sender, EventArgs e)
        {
            string dosyaYolu = @"C:\Users\user\OneDrive\Masaüstü\Enİyiler.txt";
            string okunan = "";
            StreamReader str = new StreamReader(dosyaYolu);


            if (File.Exists(dosyaYolu))
            {

                okunan = str.ReadToEnd();

                txt_enler.Text = okunan;

            }
            else
            {
                MessageBox.Show("Böyle bir veri bulunamadı!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.None);
            }

            str.Close();
        }

        



      
        private void btn_update_Click_1(object sender, EventArgs e)
        {
            string dosyaYolu = @"C:\Users\user\OneDrive\Masaüstü\Enİyiler.txt";
            string okunan = "";
            StreamReader str = new StreamReader(dosyaYolu);

            List<string> liste = new List<string>();

            if (File.Exists(dosyaYolu))
            {

                int i = 0;

                while (true)
                {

                    i++;
                    okunan = str.ReadLine();

                    if (okunan == null) break;

                    txt_enler.Text = i.ToString() + "- " + okunan + " \r\n";
                    liste.Add(okunan);

                }

            }

            else
            {
                MessageBox.Show("Böyle bir veri bulunamadı!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.None);
            }


            liste.Insert(4,isim+soyisim+adet);
            str.Close();
            StreamWriter sw = new StreamWriter(dosyaYolu);

            foreach (string satirlar in liste)
            {
                sw.WriteLine(satirlar);

            }

            sw.Close();
        
    }
    }
}
