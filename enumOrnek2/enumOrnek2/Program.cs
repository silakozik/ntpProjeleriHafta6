using System;

enum HavaDurumu
{
    Sunny,
    Rainy,
    Cloudy,
    Stormy
}

class HavaDurumuTahmini
{
    public string TavsiyeVer(HavaDurumu hava)
    {
        switch (hava)
        {
            case HavaDurumu.Sunny:
                return "Güneşli hava! Şapka takmayı unutmayın.";
            case HavaDurumu.Rainy:
                return "Yağmurlu hava! Şemsiyenizi alın.";
            case HavaDurumu.Cloudy:
                return "Bulutlu hava! Serin bir gün olabilir.";
            case HavaDurumu.Stormy:
                return "Fırtınalı hava! Dışarı çıkmaktan kaçının.";
            default:
                return "Bilinmeyen hava durumu!";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        HavaDurumuTahmini tahmin = new HavaDurumuTahmini();

        Console.WriteLine("Sunny: " + tahmin.TavsiyeVer(HavaDurumu.Sunny)); // Çıktı: Güneşli hava! Şapka takmayı unutmayın.
        Console.WriteLine("Rainy: " + tahmin.TavsiyeVer(HavaDurumu.Rainy)); // Çıktı: Yağmurlu hava! Şemsiyenizi alın.
        Console.WriteLine("Stormy: " + tahmin.TavsiyeVer(HavaDurumu.Stormy)); // Çıktı: Fırtınalı hava! Dışarı çıkmaktan kaçının.

        Console.WriteLine("Çıkmak için bir tuşa basın...");
        Console.ReadKey();
    }
}
