// Söz dizimi
//Class sınıf adı
// {
//    [Erişim Belirleyici] [Veri Tİpi] ÖzelikAdi;
//      [Erişim Belirleyici][Geri Dönüş Tipi] Metot Adi([Parametre Listesi])
//     {
//      //Metot Komutları
//     }
//
// }
//Erişim Belirleyiciler
// 1. Public : Her yerden erişilebilir.
// *2.Private : Sadece tanımlandığı sınıf içerisinden erişilebilir.
// 3. Internal : Sadece bulunduğu proje içerisinden erişilebilir
// 4. Protected : Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir.



var calisan1 = new Calisan();
calisan1.Ad = "Ayşe";
calisan1.Soyad = "Kara";
calisan1.No = 23425634;
calisan1.Depertman = "İnsan Kaynakları";
calisan1.CalisanBilgileri();
Console.WriteLine("****************");
Calisan calisan2 = new Calisan();
calisan2.Ad = "Deniz";
calisan2.Soyad="Arda";
calisan2.No = 25646789;
calisan2.Depertman = "Satın Alma";

calisan2.CalisanBilgileri();
class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Depertman;

    public void CalisanBilgileri()
    {
        Console.WriteLine("Çalışanın Adı:{0}", Ad);
        Console.WriteLine("Çalışanın Soyadı: {0}", Soyad);
        Console.WriteLine("Çalışanın Numarası: {0}", No);
        Console.WriteLine("Çalışanın Depertmanı: {0}", Depertman);
    }
}