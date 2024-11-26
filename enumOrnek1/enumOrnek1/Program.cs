using System;

enum TrafikIsiklari
{
    Red,
    Yellow,
    Green
}

class TrafikDurumu
{
    public string IsikDurumu(TrafikIsiklari isik)
    {
        switch (isik)
        {
            case TrafikIsiklari.Red:
                return "Dur!";
            case TrafikIsiklari.Yellow:
                return "Hazırlan!";
            case TrafikIsiklari.Green:
                return "Geç!";
            default:
                return "Bilinmeyen durum!";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        TrafikDurumu trafik = new TrafikDurumu();

        Console.WriteLine("Kırmızı Işık: " + trafik.IsikDurumu(TrafikIsiklari.Red)); // Çıktı: Dur!
        Console.WriteLine("Sarı Işık: " + trafik.IsikDurumu(TrafikIsiklari.Yellow)); // Çıktı: Hazırlan!
        Console.WriteLine("Yeşil Işık: " + trafik.IsikDurumu(TrafikIsiklari.Green)); // Çıktı: Geç!

        Console.WriteLine("Çıkmak için bir tuşa basın...");
        Console.ReadKey();
    }
}
