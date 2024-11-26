using System;

struct Zaman
{
    public int Saat { get; private set; }
    public int Dakika { get; private set; }

    // Constructor (Geçersiz saat ve dakika durumunda 0 yapar)
    public Zaman(int saat, int dakika)
    {
        if (saat < 0 || saat > 23 || dakika < 0 || dakika > 59)
        {
            Saat = 0;
            Dakika = 0;
        }
        else
        {
            Saat = saat;
            Dakika = dakika;
        }
    }

    // Toplam dakika hesaplama metodu
    public int ToplamDakika()
    {
        return (Saat * 60) + Dakika;
    }

    // İki zaman arasındaki farkı hesaplayan metot
    public int ZamanFarki(Zaman diger)
    {
        return Math.Abs(this.ToplamDakika() - diger.ToplamDakika());
    }

    public override string ToString()
    {
        return $"{Saat:D2}:{Dakika:D2}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Zaman zaman1 = new Zaman(10, 30);
        Zaman zaman2 = new Zaman(12, 45);
        Zaman zaman3 = new Zaman(25, 70); // Geçersiz değer, 0:0 olacak

        Console.WriteLine($"Zaman 1: {zaman1}");
        Console.WriteLine($"Zaman 2: {zaman2}");
        Console.WriteLine($"Zaman 3: {zaman3}");

        Console.WriteLine($"Zaman 1 toplam dakika: {zaman1.ToplamDakika()}");
        Console.WriteLine($"Zaman 1 ve Zaman 2 farkı: {zaman1.ZamanFarki(zaman2)} dakika");

        Console.WriteLine("Çıkmak için bir tuşa basın...");
        Console.ReadKey();
    }
}
