using System;

class Kitaplik
{
    private string[] kitaplar;

    public Kitaplik(int boyut)
    {
        kitaplar = new string[boyut];
        for (int i = 0; i < boyut; i++)
        {
            kitaplar[i] = "Boş"; // Varsayılan değer
        }
    }

    public string this[int index]
    {
        get
        {
            if (index >= 0 && index < kitaplar.Length)
            {
                return kitaplar[index];
            }
            else
            {
                return "Geçersiz indeks!";
            }
        }
        set
        {
            if (index >= 0 && index < kitaplar.Length)
            {
                kitaplar[index] = value;
            }
            else
            {
                Console.WriteLine("Geçersiz indeks!");
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Kitaplik kitaplik = new Kitaplik(3);

        kitaplik[0] = "Harry Potter";
        kitaplik[1] = "Yüzüklerin Efendisi";

        Console.WriteLine(kitaplik[0]); // Çıktı: Harry Potter
        Console.WriteLine(kitaplik[1]); // Çıktı: Yüzüklerin Efendisi
        Console.WriteLine(kitaplik[2]); // Çıktı: Boş
        Console.WriteLine(kitaplik[5]); // Çıktı: Geçersiz indeks!

        Console.WriteLine("Çıkmak için bir tuşa basın...");
        Console.ReadKey();
    }
}
