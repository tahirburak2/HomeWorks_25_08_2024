namespace Switch_Soru7;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1-5 arasında bir harf giriniz: ");
        int sayı = int.Parse(Console.ReadLine());
        switch (sayı)
        {
            case 1:
            System.Console.WriteLine("Girdiğiniz sayı 1Krş'u temsil ediyor");
            break;
            case 2:
                System.Console.WriteLine("Girdiğiniz sayı 5Krş'u temsil ediyor");
                break;
            case 3:
                System.Console.WriteLine("Girdiğiniz sayı 10Krş'u temsil ediyor");
                break;
            case 4:
                System.Console.WriteLine("Girdiğiniz sayı 25Krş'u temsil ediyor");
                break;
            case 5:
                System.Console.WriteLine("Girdiğiniz sayı 50Krş'u temsil ediyor");
                break;
            default:
            System.Console.WriteLine("Geçersiz bir sayı girdiniz.");
            break;
        }
    }
}
