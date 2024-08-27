namespace NumberMethods_Soru07;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Radyan cinsinden değerini bulmak istediğiniz sayıyı yazınız: ");
        string sayi = Console.ReadLine();
        double sayi2 = double.Parse(sayi);
        double derece = sayi2 * (Math.PI/180);
        System.Console.WriteLine(derece);

    }
}
