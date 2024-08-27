namespace NumberMethods_Soru6;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Sinüsünü bulmak istediğiniz dereceyi giriniz: ");

        string derece = Console.ReadLine();
        double douDerece = double.Parse(derece);
         double radyan =douDerece * (Math.PI/180);
         double sinüs = Math.Sin(radyan);
         System.Console.WriteLine(sinüs);
    }
}
