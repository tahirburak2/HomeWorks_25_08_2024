namespace NumberMethods_Soru04;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Lütfen karekökünü bulmasını istediğiniz bir sayı yazınız: ");
        string sayi=Console.ReadLine();

        int sayi2 = int.Parse(sayi);

        double sonuc = Math.Sqrt(sayi2);
        System.Console.WriteLine(sonuc);
    }
}
