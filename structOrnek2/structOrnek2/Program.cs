using System;

struct KarmasikSayi
{
    public double Gercek { get; private set; }
    public double Sanal { get; private set; }

    public KarmasikSayi(double gercek, double sanal)
    {
        Gercek = gercek;
        Sanal = sanal;
    }

    // Toplama işlemi
    public KarmasikSayi Topla(KarmasikSayi diger)
    {
        return new KarmasikSayi(this.Gercek + diger.Gercek, this.Sanal + diger.Sanal);
    }

    // Çıkarma işlemi
    public KarmasikSayi Cikar(KarmasikSayi diger)
    {
        return new KarmasikSayi(this.Gercek - diger.Gercek, this.Sanal - diger.Sanal);
    }

    public override string ToString()
    {
        return $"{Gercek} + {Sanal}i";
    }
}

class Program
{
    static void Main(string[] args)
    {
        KarmasikSayi sayi1 = new KarmasikSayi(3, 4);
        KarmasikSayi sayi2 = new KarmasikSayi(1, 2);

        KarmasikSayi toplam = sayi1.Topla(sayi2);
        KarmasikSayi fark = sayi1.Cikar(sayi2);

        Console.WriteLine($"Sayı 1: {sayi1}");
        Console.WriteLine($"Sayı 2: {sayi2}");
        Console.WriteLine($"Toplam: {toplam}");
        Console.WriteLine($"Fark: {fark}");

        Console.WriteLine("Çıkmak için bir tuşa basın...");
        Console.ReadKey();
    }
}
