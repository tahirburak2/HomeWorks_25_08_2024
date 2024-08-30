namespace Switch_Soru5;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("1-4 arasında bir sayı yazınız: ");
        int sayi = int.Parse(Console.ReadLine());
        switch (sayi)
        {
            case 1:
            System.Console.WriteLine("Girdiğiniz sayı Yaz mevsimini temsil ediyor.");
            break;
            case 2:
                System.Console.WriteLine("Girdiğiniz sayı İlkbahar mevsimini temsil ediyor.");
                break;
            case 3:
                System.Console.WriteLine("Girdiğiniz sayı Kış mevsimini temsil ediyor.");
                break;
            case 4:
                System.Console.WriteLine("Girdiğiniz sayı Sonbahar mevsimini temsil ediyor.");
                break;
            default:
            System.Console.WriteLine("Girdiğiniz sayı geçersiz.");
            break;
        }
    }
}
