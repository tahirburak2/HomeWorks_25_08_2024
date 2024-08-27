namespace NumberMethods_Soru1;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Lütfen bir ondalıklı sayı yazınız: ");
        string sayi = Console.ReadLine();

        double sonuc = double.Parse(sayi);
        double donusenSonuc = Math.Round(sonuc);
        System.Console.WriteLine(donusenSonuc);
    }
}
