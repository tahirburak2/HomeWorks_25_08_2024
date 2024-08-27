namespace StringMethods_Soru5;

class Program
{
    static void Main(string[] args)
    {
       System.Console.Write("Lütfen bir cümle yazınız: ");
       string cümle = Console.ReadLine();

       System.Console.Write("Aramak istediğiniz kelimeyi yazınız: ");
       string kelime = Console.ReadLine();

       System.Console.WriteLine(cümle.IndexOf(kelime));
    }
}
