namespace Switch_Soru8;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("0-6 arasında bir sayı yazınız: ");
        int sayi = int.Parse(Console.ReadLine());
        switch (sayi)
        {
            case 0:
            System.Console.WriteLine("Girdiğiniz sayı 'nokta' geometrik şeklini temsil ediyor. ");
            break;
            case 1:
                System.Console.WriteLine("Girdiğiniz sayı 'çizgi' geometrik şeklini temsil ediyor. ");
                break;
            case 2:
                System.Console.WriteLine("Girdiğiniz sayı 'açı' geometrik şeklini temsil ediyor. ");
                break;
            case 3:
                System.Console.WriteLine("Girdiğiniz sayı 'üçgen' geometrik şeklini temsil ediyor. ");
                break;
            case 4:
                System.Console.WriteLine("Girdiğiniz sayı 'kare' geometrik şeklini temsil ediyor. ");
                break;
            case 5:
                System.Console.WriteLine("Girdiğiniz sayı 'beşgen' geometrik şeklini temsil ediyor. ");
                break;
            case 6:
                System.Console.WriteLine("Girdiğiniz sayı 'altıgen' geometrik şeklini temsil ediyor. ");
                break;
            default:
            System.Console.WriteLine("Geçersiz bir sayı girdiniz!!!");
            break;
        }
    }
}
