namespace Switcg_Soru6;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Notunuzun harf karşılığını yazınız: ");
        string harf = Console.ReadLine();
        switch (harf)
        {
            case "A":
            System.Console.WriteLine("Geçtiniz!");
            break;
            case "B":
                System.Console.WriteLine("Geçtiniz!");
                break;
            case "C":
                System.Console.WriteLine("Geçtiniz!");
                break;
            case "D":
                System.Console.WriteLine("Geçtiniz!");
                break;

            default:
            System.Console.WriteLine("Girdiğiniz harf geçersiz.");
            break;
        }
    }
}
