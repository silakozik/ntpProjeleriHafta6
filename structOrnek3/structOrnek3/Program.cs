using System;

struct GPSKonum
{
    public double Enlem { get; private set; }
    public double Boylam { get; private set; }

    public GPSKonum(double enlem, double boylam)
    {
        Enlem = enlem;
        Boylam = boylam;
    }

    // Haversine formülü ile mesafe hesaplama
    public double MesafeHesapla(GPSKonum diger)
    {
        double R = 6371; // Dünya'nın yarıçapı (km)
        double dLat = DereceyiRadyana(diger.Enlem - this.Enlem);
        double dLon = DereceyiRadyana(diger.Boylam - this.Boylam);

        double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                   Math.Cos(DereceyiRadyana(this.Enlem)) * Math.Cos(DereceyiRadyana(diger.Enlem)) *
                   Math.Sin(dLon / 2) * Math.Sin(dLon / 2);

        double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
        return R * c; // Kilometre cinsinden mesafe
    }

    private static double DereceyiRadyana(double derece)
    {
        return derece * (Math.PI / 180);
    }

    public override string ToString()
    {
        return $"Enlem: {Enlem}, Boylam: {Boylam}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        GPSKonum konum1 = new GPSKonum(41.0082, 28.9784); // İstanbul
        GPSKonum konum2 = new GPSKonum(39.9208, 32.8541); // Ankara

        Console.WriteLine($"Konum 1: {konum1}");
        Console.WriteLine($"Konum 2: {konum2}");
        Console.WriteLine($"İki konum arasındaki mesafe: {konum1.MesafeHesapla(konum2):F2} km");

        Console.WriteLine("Çıkmak için bir tuşa basın...");
        Console.ReadKey();
    }
}
