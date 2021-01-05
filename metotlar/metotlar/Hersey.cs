using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace metotlar
{
    public class Hersey
    {
       private int sayı = 100; //alan, field

        public int topla(int a, byte b)
        {
            return a + b;
        }

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
        public double KDVliFiyat(double fiyat, double kdv)
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

        //Metin kutusundaki metni farenin kliklendiği noktadan sonrasını seçen metot.
        public void MetniOrtadanSec(TextBox txt)
        {
            txt.SelectionLength = txt.TextLength;
        }

        //Bir metindeki istenilen karakterin kaç adet olduğunu bulan metot.
        public int KarakterBul(string metin, char c)
        {
            int adet = 0;
            for (int i = 0; i < metin.Length; i++)
            {
                if (metin[i] == c)
                {
                    adet++;
                }
            }
            return adet;
        }

        //toplanacak sayının belli olmadığı rakamları toplayan metot.
       public int Topla(params int[] sayılar)
        {
            int toplam = 0;
            foreach (var item in sayılar)
            {
                toplam += item;
            }

            return toplam;
        }

        //Bir fiyata birden çok indirim uygulayabilen metot
      public  decimal iskontoluFiyat(decimal fiyat, params decimal[] indirimler)
        {
            foreach (var item in indirimler)
            {
                fiyat -= fiyat / 100 * item;
            }
            return fiyat;
        }

        //Kendisine verilen sayıları küçükten büyüğe doğru sıralayan metot
       public string sirala(params int[] sayılar)
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
      public  Color RenkSec()
        {
            ColorDialog RenkDiyalog = new ColorDialog();
            RenkDiyalog.ShowDialog();
            Color renk = RenkDiyalog.Color;
            return renk;
        }

        //form üzerinde bulunan metin kutularını temizleyen metot.
        public void MetinTemizle(Form frm)
        {
            foreach (Control c in frm.Controls)
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

        //Bir metin kutusuna sadece sayı girişine izin veren metot
        public void SadeceRakam(KeyPressEventArgs tus)
        {
            if (char.IsNumber(tus.KeyChar))
            {
                //bir şey yapma
            }
            else
            {
                tus.Handled = true;
            }
        }

        //Bir metin içerisindeki nümerik değerleri silen metot
        public string RakamlariSil(string metin)
        {
            string sonMetin = "";
            foreach (var harf in metin)
            {
                if (!char.IsNumber(harf))
                {
                    sonMetin += harf;
                }
            }
            return sonMetin;
        }
    }
}
