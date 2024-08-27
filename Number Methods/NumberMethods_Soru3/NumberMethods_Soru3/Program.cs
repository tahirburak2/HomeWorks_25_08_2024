namespace NumberMethods_Soru3;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Lütfen mutlağını bulmak istediğiniz negatif bir sayı yazınız: ");
        string sayi = Console.ReadLine();

        int sayi2 = int.Parse(sayi);

        int sonuc = Math.Abs(sayi2);

        System.Console.WriteLine(sonuc);
    }
}
