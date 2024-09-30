using System;

class Program
{
    static void Main(string[] args)
    {
        // Kullanıcıdan bilgileri alalım
        Console.WriteLine("Lütfen aşağıdaki bilgileri giriniz:");

        // T.C. Kimlik Numarası ve Telefon Numarası string olarak alınır çünkü aritmetik işlem yapılmayacak
        Console.Write("T.C. Kimlik Numarası: ");
        string tcKimlik = Console.ReadLine();

        Console.Write("Adı: ");
        string ad = Console.ReadLine();

        Console.Write("Soyadı: ");
        string soyad = Console.ReadLine();

        Console.Write("Telefon Numarası: ");
        string telefonNo = Console.ReadLine();

        // Yaş bir tamsayı olduğu için int olarak alınır
        Console.Write("Yaş: ");
        int yas = int.Parse(Console.ReadLine());

        // Ürün fiyatları ondalıklı olabileceğinden decimal olarak alınır
        Console.Write("İlk Aldığı Ürünün Fiyatı: ");
        decimal urunFiyat1 = decimal.Parse(Console.ReadLine());

        Console.Write("İkinci Aldığı Ürünün Fiyatı: ");
        decimal urunFiyat2 = decimal.Parse(Console.ReadLine());

        // Kullanıcı bilgilerini ekrana yazdır
        Console.WriteLine("\n-----------------------------");
        Console.WriteLine($"T.C. Kimlik Numarası: {tcKimlik}");
        Console.WriteLine($"Adı: {ad}");
        Console.WriteLine($"Soyadı: {soyad}");
        Console.WriteLine($"Telefon Numarası: {telefonNo}");
        Console.WriteLine($"Yaş: {yas}");
        Console.WriteLine($"İlk Aldığı Ürünün Fiyatı: {urunFiyat1}");
        Console.WriteLine($"İkinci Aldığı Ürünün Fiyatı: {urunFiyat2}");
        Console.WriteLine("-----------------------------");

        // Toplam harcama ve puan hesaplama
        decimal toplamHarcama = urunFiyat1 + urunFiyat2;
        decimal puan = toplamHarcama * 0.10M;

        // Kayıt mesajı
        Console.WriteLine($"{tcKimlik} TC numaralı {ad} {soyad} isimli kişi için kayıt oluşturulmuştur.");
        Console.WriteLine($"{telefonNo} telefon numarasına bildirim mesajı gönderilmiştir.");
        Console.WriteLine($"Toplam harcama karşılığı kazandığı %10 puan miktarı -> {puan} TL'dir.");
    }
}
