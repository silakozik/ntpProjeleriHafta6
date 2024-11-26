using System;

class Otopark
{
    private string[,] parkYerleri;

    public Otopark(int katSayisi, int yerSayisi)
    {
        parkYerleri = new string[katSayisi, yerSayisi];
        for (int i = 0; i < katSayisi; i++)
        {
            for (int j = 0; j < yerSayisi; j++)
            {
                parkYerleri[i, j] = "Empty"; // Varsayılan durum
            }
        }
    }

    public string this[int kat, int yer]
    {
        get
        {
            if (kat >= 0 && kat < parkYerleri.GetLength(0) && yer >= 0 && yer < parkYerleri.GetLength(1))
            {
                return parkYerleri[kat, yer];
            }
            else
            {
                return "Geçersiz park yeri!";
            }
        }
        set
        {
            if (kat >= 0 && kat < parkYerleri.GetLength(0) && yer >= 0 && yer < parkYerleri.GetLength(1))
            {
                parkYerleri[kat, yer] = value;
            }
            else
            {
                Console.WriteLine("Geçersiz park yeri!");
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Otopark otopark = new Otopark(2, 3);

        otopark[0, 0] = "34ABC123";
        otopark[1, 2] = "06XYZ789";

        Console.WriteLine(otopark[0, 0]); // Çıktı: 34ABC123
        Console.WriteLine(otopark[1, 2]); // Çıktı: 06XYZ789
        Console.WriteLine(otopark[2, 0]); // Çıktı: Geçersiz park yeri!

        Console.WriteLine("Çıkmak için bir tuşa basın...");
        Console.ReadKey();
    }
}
