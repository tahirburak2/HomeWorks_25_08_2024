namespace Switch_Soru2;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("1-12 arasında bir sayı yazınız: ");
        int sayi = int.Parse(Console.ReadLine());

        switch (sayi)
        {
            case 1:
                System.Console.WriteLine("Yazdığınız sayı Ocak ayını temsil ediyor.");
                break;
            case 2:
                System.Console.WriteLine("Yazdığınız sayı Şubat ayını temsil ediyor.");
                break;
            case 3:
                System.Console.WriteLine("Yazdığınız sayı Mart ayını temsil ediyor.");
                break;
            case 4:
                System.Console.WriteLine("Yazdığınız sayı Nisan ayını temsil ediyor.");
                break;
            case 5:
                System.Console.WriteLine("Yazdığınız sayı Mayıs ayını temsil ediyor.");
                break;
            case 6:
                System.Console.WriteLine("Yazdığınız sayı Haziran ayını temsil ediyor.");
                break;
            case 7:
                System.Console.WriteLine("Yazdığınız sayı Temmuz ayını temsil ediyor.");
                break;
            case 8:
                System.Console.WriteLine("Yazdığınız sayı Ağustos ayını temsil ediyor.");
                break;
            case 9:
                System.Console.WriteLine("Yazdığınız sayı Eylül ayını temsil ediyor.");
                break;
            case 10:
                System.Console.WriteLine("Yazdığınız sayı Ekim ayını temsil ediyor.");
                break;
            case 11:
                System.Console.WriteLine("Yazdığınız sayı Kasım ayını temsil ediyor.");
                break;
            case 12:
                System.Console.WriteLine("Yazdığınız sayı Aralık ayını temsil ediyor.");
                break;
            default:
            System.Console.WriteLine("geçersiz bir sayı yazdınız!!!");
             break;
        }
    }
}
