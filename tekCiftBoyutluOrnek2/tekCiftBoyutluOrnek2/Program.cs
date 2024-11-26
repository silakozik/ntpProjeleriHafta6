using System;
using System.Collections.Generic;

class OgrenciNotlari
{
    private Dictionary<string, int> notlar = new Dictionary<string, int>();

    public int this[string ders]
    {
        get
        {
            if (notlar.ContainsKey(ders))
            {
                return notlar[ders];
            }
            else
            {
                Console.WriteLine("Ders bulunamadı!");
                return -1; // Hata değeri
            }
        }
        set
        {
            notlar[ders] = value;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        OgrenciNotlari notSistemi = new OgrenciNotlari();

        notSistemi["Matematik"] = 90;
        notSistemi["Fizik"] = 85;

        Console.WriteLine($"Matematik Notu: {notSistemi["Matematik"]}"); // Çıktı: 90
        Console.WriteLine($"Fizik Notu: {notSistemi["Fizik"]}"); // Çıktı: 85
        Console.WriteLine($"Kimya Notu: {notSistemi["Kimya"]}"); // Çıktı: Ders bulunamadı!

        Console.WriteLine("Çıkmak için bir tuşa basın...");
        Console.ReadKey();
    }
}
