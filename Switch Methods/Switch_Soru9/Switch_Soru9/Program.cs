namespace Switch_Soru9;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1-5 araası bir sayı giriniz: ");
        int sayi = int.Parse(Console.ReadLine());
        switch (sayi)
        {
            case 1:
            System.Console.WriteLine("Girdiğiniz sayının türkçedeki karşılığı 'bir'dir.");
            break;
            case 2:
                System.Console.WriteLine("Girdiğiniz sayının türkçedeki karşılığı 'iki'dir.");
                break;
            case 3:
                System.Console.WriteLine("Girdiğiniz sayının türkçedeki karşılığı 'üç'dir.");
                break;
            case 4:
                System.Console.WriteLine("Girdiğiniz sayının türkçedeki karşılığı 'dört'dir.");
                break;
            case 5:
                System.Console.WriteLine("Girdiğiniz sayının türkçedeki karşılığı 'beş'dir.");
                break;
            default:
            System.Console.WriteLine("Girdiğiniz sayı geçersizdir!!!");
            break;
        }
    }
}
