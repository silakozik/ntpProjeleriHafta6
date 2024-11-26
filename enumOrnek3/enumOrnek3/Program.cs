using System;

enum CalisanRolleri
{
    Manager,
    Developer,
    Designer,
    Tester
}

class MaasHesaplama
{
    public int MaasBelirle(CalisanRolleri rol)
    {
        switch (rol)
        {
            case CalisanRolleri.Manager:
                return 20000; // Manager maaşı
            case CalisanRolleri.Developer:
                return 15000; // Developer maaşı
            case CalisanRolleri.Designer:
                return 12000; // Designer maaşı
            case CalisanRolleri.Tester:
                return 10000; // Tester maaşı
            default:
                return 0; // Geçersiz rol
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        MaasHesaplama maas = new MaasHesaplama();

        Console.WriteLine("Manager maaşı: " + maas.MaasBelirle(CalisanRolleri.Manager) + " TL"); // Çıktı: 20000 TL
        Console.WriteLine("Developer maaşı: " + maas.MaasBelirle(CalisanRolleri.Developer) + " TL"); // Çıktı: 15000 TL
        Console.WriteLine("Designer maaşı: " + maas.MaasBelirle(CalisanRolleri.Designer) + " TL"); // Çıktı: 12000 TL
        Console.WriteLine("Tester maaşı: " + maas.MaasBelirle(CalisanRolleri.Tester) + " TL"); // Çıktı: 10000 TL

        Console.WriteLine("Çıkmak için bir tuşa basın...");
        Console.ReadKey();
    }
}
