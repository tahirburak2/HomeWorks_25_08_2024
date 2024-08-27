namespace StringMethods_Soru4;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Lütfen bir cümle yazınız: ");
        string cumle = Console.ReadLine();

string tumCumle = cumle.Trim();
string basCumle = cumle.TrimStart();
string sonCumle = cumle.TrimEnd();

        System.Console.WriteLine(@$"
        {tumCumle}
        {basCumle}
        {sonCumle}
        
        
        ");
    }
}
