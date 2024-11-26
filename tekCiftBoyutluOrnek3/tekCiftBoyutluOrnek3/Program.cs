using System;

class SatrançTahtası
{
    private string[,] tahta = new string[8, 8];

    public SatrançTahtası()
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                tahta[i, j] = "Boş"; // Varsayılan durum
            }
        }
    }

    public string this[int x, int y]
    {
        get
        {
            if (x >= 0 && x < 8 && y >= 0 && y < 8)
            {
                return tahta[x, y];
            }
            else
            {
                return "Geçersiz kare!";
            }
        }
        set
        {
            if (x >= 0 && x < 8 && y >= 0 && y < 8)
            {
                tahta[x, y] = value;
            }
            else
            {
                Console.WriteLine("Geçersiz kare!");
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        SatrançTahtası tahta = new SatrançTahtası();

        tahta[0, 0] = "Kale";
        tahta[7, 7] = "Kral";

        Console.WriteLine(tahta[0, 0]); // Çıktı: Kale
        Console.WriteLine(tahta[7, 7]); // Çıktı: Kral
        Console.WriteLine(tahta[8, 8]); // Çıktı: Geçersiz kare!

        Console.WriteLine("Çıkmak için bir tuşa basın...");
        Console.ReadKey();
    }
}
