namespace SwitchSoru_4;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Sesli mi sessiz mi olduğunu bulmak istedğiniz harfi yazınız: ");
        string harf = Console.ReadLine();
        switch (harf)
        {
            case "a":
            System.Console.WriteLine("Yazdığınız harf seslidir.");
            break;
            case "e":
                System.Console.WriteLine("Yazdığınız harf seslidir.");
                break;
            case "i":
                System.Console.WriteLine("Yazdığınız harf seslidir.");
                break;
            case "ı":
                System.Console.WriteLine("Yazdığınız harf seslidir.");
                break;
            case "o":
                System.Console.WriteLine("Yazdığınız harf seslidir.");
                break;
            case "ö":
                System.Console.WriteLine("Yazdığınız harf seslidir.");
                break;
            case "u":
                System.Console.WriteLine("Yazdığınız harf seslidir.");
                break;
            case "ü":
                System.Console.WriteLine("Yazdığınız harf seslidir.");
                break;
            default:
            System.Console.WriteLine("yazdığınız harf sessizdir.");
            break;
        }
    }
}
