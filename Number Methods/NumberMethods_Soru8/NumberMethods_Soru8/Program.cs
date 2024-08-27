namespace NumberMethods_Soru8;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Algoritmasını bulmak istediğiniz sayıyı yazınız: ");
        string sayi = Console.ReadLine();

        double sayi1 = double.Parse(sayi);
        double logaritma = Math.Log(sayi1);
        
        System.Console.WriteLine(logaritma);
    }
}
