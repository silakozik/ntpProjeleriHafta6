using System;

class Program
{
    // Gün cinsinden fark
    static int TarihFarki(DateTime baslangic, DateTime bitis)
    {
        return (bitis - baslangic).Days;
    }

    // Saat cinsinden fark
    static int TarihFarkiSaat(DateTime baslangic, DateTime bitis)
    {
        return (int)(bitis - baslangic).TotalHours;
    }

    // Yıl, Ay, Gün cinsinden fark
    static (int Yil, int Ay, int Gun) TarihFarkiDetay(DateTime baslangic, DateTime bitis)
    {
        int yil = bitis.Year - baslangic.Year;
        int ay = bitis.Month - baslangic.Month;
        int gun = bitis.Day - baslangic.Day;

        // Gün farkı negatifse ayı bir azalt, günü düzelt
        if (gun < 0)
        {
            ay--;
            gun += DateTime.DaysInMonth(baslangic.Year, baslangic.Month);
        }

        // Ay farkı negatifse yılı bir azalt, ayı düzelt
        if (ay < 0)
        {
            yil--;
            ay += 12;
        }

        return (yil, ay, gun);
    }

    static void Main(string[] args)
    {
        // Tarihleri tanımla
        DateTime baslangic = new DateTime(2020, 5, 15);
        DateTime bitis = new DateTime(2023, 11, 25);

        // Gün farkı
        Console.WriteLine("Gün farkı: " + TarihFarki(baslangic, bitis)); // Çıktı: 1289

        // Saat farkı
        Console.WriteLine("Saat farkı: " + TarihFarkiSaat(baslangic, bitis)); // Çıktı: 30936

        // Yıl, ay ve gün farkı
        var detayliFark = TarihFarkiDetay(baslangic, bitis);
        Console.WriteLine($"Yıl: {detayliFark.Yil}, Ay: {detayliFark.Ay}, Gün: {detayliFark.Gun}");
        // Çıktı: Yıl: 3, Ay: 6, Gün: 10

        // Konsolu açık tut
        Console.WriteLine("Çıkmak için bir tuşa basın...");
        Console.ReadKey();
    }
}
