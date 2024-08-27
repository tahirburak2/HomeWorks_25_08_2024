namespace StringMethods_Soru3;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Lütfen bir cümle yazınız: ");
        string cumle = Console.ReadLine();
        
        string kelime = "merhaba";
        string kucukCumle= cumle.ToLower();

        int sayi = kelime.Count();
        System.Console.WriteLine($"{kelime} kelimesi {cumle}'de {sayi} kere geçiyor." );
    }
}
