namespace StringMethods_Soru2;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Lütfen bir kelime yazınız: ");
        string kelime = Console.ReadLine();

        string kucuk = kelime.ToLower();
        string buyuk = kelime.ToUpper();
        System.Console.WriteLine(@$"
{kucuk}
{buyuk}");
    }
}
