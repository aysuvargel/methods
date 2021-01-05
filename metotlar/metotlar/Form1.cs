using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// İki sayıyı toplar
        /// </summary>
        /// <param name="a">int türde bir sayı</param>
        /// <param name="b">byte türde bir sayı</param>
        /// <returns>int türde bir bilgi döndürür</returns>
        public int topla(int a, byte b)
        {
            return a + b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Text = topla(5, 10).ToString(); 
            Text = Cıkartma(5, 33).ToString(); 
            Text = Carp(5, 33).ToString(); 
            Text = Bolme(33.9, 5.4).ToString("#,###.##");
            Text = DaireninAlani(5.7).ToString("#,###.##");
            Text = DaireninCevresi(5.7).ToString("#,###.##");
            Text = string.Format("{0:c}",IskontoluFiyat(100, 10));
            Text = string.Format("{0:c}", IndirmTutarı(439.97, 15.12));
            Text = KDVliFiyat(123, 8).ToString("#,###.##");
            Text = Gauss(10).ToString();
            int[] s = {23,56,12,89,45,67 };
            Text = DiziTopla(s).ToString();
            richTextBox2.Text = BuyukHarf(richTextBox1.Text);
        }

        /// <summary>
        /// ilk sayıdan ikinci sayıyı çıkartır, long türünde geriye değer döndürür
        /// </summary>
        /// <param name="s1">int türde bir sayı</param>
        /// <param name="s2">int türde ikinci sayı</param>
        /// <returns></returns>
        public long Cıkartma(int s1, int s2)
        {
            return s1 - s2;
        }

        public long Carp(int s1, int s2)
        {
            return s1 * s2;
        }

        public double Bolme(double s1, double s2)
        {
            return s1 / s2;
        }

        /// <summary>
        /// Dairenin alanını hesaplar
        /// </summary>
        /// <param name="r">Yarıçap bilgisi</param>
        /// <returns></returns>
        public double DaireninAlani(double r)
        {
            return Math.PI * r * r;
        }

        public double DaireninCevresi(double r)
        {
            return 2 * Math.PI * r;
        }

        //Bir ürün fiyatında istenilen oranda indirim yaparak iskontolu fiyatı veren metot
        public decimal IskontoluFiyat(decimal fiyat, decimal indirimOrani)
        {
            return fiyat - fiyat * indirimOrani / 100;
        }

        //Fiyatı verilen bir ürünün sadece indirim tutarını hesaplayan metot
        public double IndirmTutarı(double fiyat, double indirim)
        {
            return fiyat * indirim / 100;
        }

        //Fiyatı verilen bir ürünün üzerine KDV eklenmiş haliyle toplam fiyatı veren metot
       public  double KDVliFiyat(double fiyat, double kdv)
        {
            return fiyat + fiyat * kdv / 100;
        }

        //Gauss metodu
        public long Gauss(int sayı)
        {
            return (sayı + 1) * sayı / 2;
        }

        //Verilen dizinin elemanlarını toplayan metot
        public int DiziTopla(int[] sayılar)
        {
            int toplam = 0;
            for (int i = 0; i < sayılar.Length; i++)
            {
                toplam += sayılar[i];
            }
            return toplam;
        }

        //kendisine verilen küçük harfle yazılmış metni büyük harfe çeviren metot.
        public string BuyukHarf(string metin)
        {
            return metin.ToUpper();
        }

        //Bir metin kutusundaki metnin tamamını seçen metot
        public void MetinSec(TextBox txt)
        {
            txt.SelectionStart = 0;
            txt.SelectionLength = txt.TextLength;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            MetinSec(textBox1);       
        }

        //Metin kutusundaki metni farenin kliklendiği noktadan sonrasını seçen metot.
        public void MetniOrtadanSec(TextBox txt)
        {
            txt.SelectionLength = txt.TextLength;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            MetniOrtadanSec(textBox2);
        }

        //Bir metindeki istenilen karakterin kaç adet olduğunu bulan metot.
        public int KarakterBul(string metin, char c)
        {
            int adet = 0;
            for (int i = 0; i < metin.Length; i++)
            {
                if (metin[i]==c)
                {
                    adet++;
                }
            }
            return adet;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(KarakterBul(richTextBox1.Text,'a').ToString());
        }

        //toplanacak sayının belli olmadığı rakamları toplayan metot.
        int Topla(params int[] sayılar)
        {
            int toplam = 0;
            foreach (var item in sayılar)
            {
                toplam += item;
            }

            return toplam;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = Topla(12, 45, 67, 9, 65, 33, 2345, 3, 4,100,300,5).ToString();
            textBox2.Text = iskontoluFiyat(380, 9, 12, 20, 3, 8).ToString();
            richTextBox2.Text = sirala(12, 67, 3, 89, 30, 20, 16, 90, 1, 2, 8, 5, 100, 50);
            BackColor = RenkSec();
            button1.BackColor = RenkSec();

        }

        //Bir fiyata birden çok indirim uygulayabilen metot
        decimal iskontoluFiyat(decimal fiyat, params decimal[] indirimler)
        {
            foreach (var item in indirimler)
            {
                fiyat -= fiyat / 100 * item;
            }
            return fiyat;
        }

        //Kendisine verilen sayıları küçükten büyüğe doğru sıralayan metot
        string sirala(params int[] sayılar)
        {
            string s_lar = "";
            Array.Sort(sayılar);
            foreach (var item in sayılar)
            {
                s_lar += item + " ";
            }
            return s_lar;
        }

        //Renk diyalog penceresi açarak istediğimiz nesnenin rengini değiştirmeye yarayan metot.
        Color RenkSec()
        {
            ColorDialog RenkDiyalog = new ColorDialog();
            RenkDiyalog.ShowDialog();
            Color renk = RenkDiyalog.Color;
            return renk;
        }

        //form üzerinde bulunan metin kutularını temizleyen metot.
        public void MetinTemizle()
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    c.Text = string.Empty;
                }

                //diğer controller içerisinde bulunan metin kutularını da temizleyen kısım.
                foreach (Control altControl in c.Controls)
                {
                    if (altControl is TextBox)
                    {
                        altControl.Text = string.Empty;
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MetinTemizle();
        }

        Hersey hrs = new Hersey();

        private void button5_Click(object sender, EventArgs e)
        {
            hrs.MetinTemizle(this);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            hrs.SadeceRakam(e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
           textBox8.Text= hrs.RakamlariSil(textBox7.Text);
        }
    }
}
