using System;

class Program
{
    static int Topla(int a, int b)
    {
        return a + b;
    }

    static int Topla(int a, int b, int c)
    {
        return a + b + c;
    }

    static int Topla(int[] numbers)
    {
        int toplam = 0;
        foreach (int num in numbers)
        {
            toplam += num;
        }
        return toplam;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(Topla(3, 5)); // Çıktı: 8
        Console.WriteLine(Topla(1, 2, 3)); // Çıktı: 6
        Console.WriteLine(Topla(new int[] { 1, 2, 3, 4 })); // Çıktı: 10

        Console.WriteLine("Çıkmak için bir tuşa basın...");
        Console.ReadKey(); // Konsolu açık tutar
    }
}
