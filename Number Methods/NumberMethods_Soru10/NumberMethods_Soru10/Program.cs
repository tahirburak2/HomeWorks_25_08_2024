namespace NumberMethods_Soru10;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Ondalıklı bir sayı yazınız: ");
        string girilenSayi=Console.ReadLine();
        double sayi = double.Parse(girilenSayi);

        System.Console.Write("yuvarlamak istediğiniz basağımı yazınız: ");
        string girilenSayi2 = Console.ReadLine();
        int sayi2 = int.Parse(girilenSayi2);

        double sonuc = Math.Round(sayi,sayi2);
        System.Console.WriteLine(sonuc);
    }
}
