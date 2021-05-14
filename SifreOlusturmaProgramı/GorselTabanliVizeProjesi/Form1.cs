using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselTabanliVizeProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int olusturlanSifreSayisi = 0; // olusturdugum sifre sayilarini tutmak icin bir degisken.
        private void button1_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = " "; //butona tiklandiginda textboxun icini temizlemek icin
            Random rastgele = new Random(); // rastgale sayi olusturmak icin random classini tanimladim.
            string sifre = ""; 


            //Ilk haneyi buyuk ya da kucuk harf ile yapmak icin.
            int sayiUreteci1 = rastgele.Next(1, 3); //1 ya da 2 sayilarindan rastgele birini olusturmak 

            if (sayiUreteci1 == 1) //olusan sayi 1 ise sifrenin ilk hanesi buyuk harf olacak
            {
                char harfUret = Convert.ToChar(rastgele.Next(65, 90)); //buyuk harf olusturmak icin
                sifre += harfUret.ToString();
            }
            else // olusan sayi 2 ise sifrenin ilk hanesi kucuk sayi olacak
            {
                char harfUret = Convert.ToChar(rastgele.Next(97, 123)); //kuck harf olusturmak icin
                sifre += harfUret.ToString();
            }


            //2-11 hanelerini rastgele harf,karakter ve sayi yapmak icin.
            //oncelikle 3 tane rastgele sayi urettim.
            int random = rastgele.Next(0, 3);
            int random2 = rastgele.Next(3, 6);
            int random3 = rastgele.Next(6, 9);

            for (int i = 0; i < 10; i++)
            {
                //bu if kisminda urettigim rastgele sayi bunlardan birine girdigi zaman o kosulu saglayacak
                //bunu yapma sebebim 2. ve 11. haneleri arasindan birinde mutlaka harf ve sayi yazdirmak.
                if (i == random)
                {
                    sifre += Convert.ToChar(rastgele.Next(65, 91)); // mutlaka bir buyuk harf uretip sifre stringine eklemek icin
                    continue;
                }
                
                if (i == random2)
                {
                    sifre += Convert.ToChar(rastgele.Next(97, 123)); //mutlaka bir kucuk uretip sifre stringine eklemek icin
                    continue;
                }
                
                if (i == random3)
                {
                    sifre += Convert.ToChar(rastgele.Next(48, 58)); //mutlaka bir rakam uretip sifre stringine eklemek icin
                    continue;

                }

                // ve bundan sonrasi rastgele sayi, harf ve ozel karakter uretip sifre stringime eklemek icin
                int sayi = rastgele.Next(0, 4); 

                if (sayi == 0)
                {
                    sifre += Convert.ToChar(rastgele.Next(65, 91)); //buyuk harf uretip sifre stringine eklemek icin

                }

                else if(sayi == 1)
                {
                    sifre += Convert.ToChar(rastgele.Next(97, 123)); //kucuk harf uretip sifre stringine eklemek icin

                }

                else if (sayi == 2 )
                { 
                    sifre += Convert.ToChar(rastgele.Next(48, 58)); //rakamlari uretip sifre stringine eklemek icin

                }

                else
                {
                    sifre += Convert.ToChar(rastgele.Next(33, 48)); //ozel karakterler uretip sifre stringine eklemek icin
                    
                }
            }

            
            //Son haneyi ozel karakter ile bitirmek icin.
            int sayiUreteci3 = rastgele.Next(1, 3);

            if (sayiUreteci3 == 1)
            {
                char ozelKarakterUret = Convert.ToChar(rastgele.Next(33, 48));
                sifre += ozelKarakterUret.ToString();
            }
            else
            {
                char ozelKarakterUret = Convert.ToChar(rastgele.Next(58, 65));
                sifre += ozelKarakterUret.ToString();

            }


            richTextBox1.Text += olusturlanSifreSayisi +  "- " + sifre +  "\n"; //textboxa olusan sifreleri sirasiyla ve kacinci sirada olduklarini yazdirma

            textBox1.Text += sifre; // textboxa sifreyi yazdirma
            
            label1.Text = "Sifre Uzunlugu :" + sifre.Length.ToString(); // label1 e sifre uzunlugunu yazdirma
           
            olusturlanSifreSayisi++; //sifre olustur butonuna her tiklandiginda olusturulan sifre sayisi degiskenimizi 1 arttiriyorum
            
            label3.Text = "Olusturulan sifre sayisi :" +  olusturlanSifreSayisi; // label3 e olusturulan sifre sayisini yazdirma


        }
    }
}
