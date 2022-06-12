using System;

namespace sinif_kavrami 
{
    class Program
    {
        static void Main(string[] args)
        {
            // Söz Dizimi
            // class SinifAdi
            //{
            //      [Erişim Belirleyici] [Veri Tipi] OzellikAdi;
            //      [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi([Parametre Listesi])
            //        {
                        //Metot Komutları
            //        }
            //}

            //Erişim Belirleyiciler
            // *Public > Her yerden erişim sağlanır.
            // *Private > Tanımlandığı sınıf içerisinde erişim sağlanır.
            // *Internal > Kendi bulunduğu proje içerisinde erişim sağlanır.
            // *Protected > Sadece tanımlandığı sınıfta ve/veya o sınıftan kalıtım alan diğer miraslarda kullanılabilir.

            Calisan calisan1 = new Calisan(); // Çalışan sınıfından bir instance oluşturuldu.
            calisan1.Ad="Ayşe";
            calisan1.Soyad="Kara";
            calisan1.No=23415634;
            calisan1.Departman="İnsan Kaynakları";

            calisan1.CalisanBilgileri(); // Üst satırdaki kodlarda atanan değerler bu kodda yazdırıldı.
            Console.WriteLine("****************");

            Calisan calisan2 = new Calisan(); // Çalışan sınıfından başka bir instance oluşturuldu.
            calisan2.Ad="Deniz";
            calisan2.Soyad="Arda";
            calisan2.No=25646789;
            calisan2.Departman="Satın Alma";

            calisan2.CalisanBilgileri();// Üst satırdaki kodlarda atanan değerler bu kodda yazdırıldı.
        }
    }
    class Calisan // Çalışan isminde bir sınıf oluşturduk.
    {
        public string Ad; 
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri() // Yazdırma fonksiyonu oluşturuldu.
        {
            Console.WriteLine("Çalışanın Adı:{0}",Ad);
            Console.WriteLine("Çalışanın Soyadı:{0}",Soyad);
            Console.WriteLine("Çalışanın Numarası:{0}",No);
            Console.WriteLine("Çalışanın Departmanı:{0}",Departman);
        }

    }
}