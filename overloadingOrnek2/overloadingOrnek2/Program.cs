using System;

class Program
{
    static int Alan(int kenar)
    {
        return kenar * kenar;
    }

    static int Alan(int uzunKenar, int kisaKenar)
    {
        return uzunKenar * kisaKenar;
    }

    static double Alan(double yaricap)
    {
        return Math.PI * yaricap * yaricap;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Karenin alanı: " + Alan(4)); // Çıktı: 16
        Console.WriteLine("Dikdörtgenin alanı: " + Alan(5, 3)); // Çıktı: 15
        Console.WriteLine("Dairenin alanı: " + Alan(2.5)); // Çıktı: 19.63 (yaklaşık)

        Console.WriteLine("Çıkmak için bir tuşa basın...");
        Console.ReadKey(); // Konsolu açık tutar
    }
}
