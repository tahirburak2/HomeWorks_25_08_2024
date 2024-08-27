namespace StringMethods_Soru1;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Lütfen bir kelime yazınız: ");
        string kelime = System.Console.ReadLine();

        int fullKelime = kelime.Length;
        System.Console.WriteLine(fullKelime);
    }
}
