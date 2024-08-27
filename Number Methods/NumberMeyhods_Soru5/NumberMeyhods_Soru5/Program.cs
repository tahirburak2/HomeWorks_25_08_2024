namespace NumberMeyhods_Soru5;

class Program
{
    static void Main(string[] args)
    {
    System.Console.Write("Taban olmasını istediğiniz sayıyı yazınız: ");
    string sayi1=Console.ReadLine();

    System.Console.Write("Üs olmasını istediğiniz sayıyı yazınız: ");
    string sayi2 = Console.ReadLine();

    int isayi1 = int.Parse(sayi1);
    int isayi2 = int.Parse(sayi2);

    double sonuc = Math.Pow(isayi1,isayi2);
    System.Console.WriteLine(sonuc);
    }
}
