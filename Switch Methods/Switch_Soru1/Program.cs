namespace Switch_Soru1;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("1-7 arasında bir sayı yazınız: ");
        int sayi = int.Parse(Console.ReadLine());

        switch (sayi)
        {
            case 1:
                System.Console.WriteLine("Yazdığınız sayı Pazartesi gününü ifade ediyor.");
                break;
            case 2:
                System.Console.WriteLine("Yazdığınız sayı Salı gününü ifade ediyor.");
                break;
            case 3:
                System.Console.WriteLine("Yazdığınız sayı Çarşamba gününü ifade ediyor.");
                break;
            case 4:
                System.Console.WriteLine("Yazdığınız sayı Perşembe gününü ifade ediyor.");
                break;
            case 5:
                System.Console.WriteLine("Yazdığınız sayı Cuma gününü ifade ediyor.");
                break;
            case 6:
                System.Console.WriteLine("Yazdığınız sayı Cumartesi gününü ifade ediyor.");
                break;
            case 7:
                System.Console.WriteLine("Yazdığınız sayı Pazar gününü ifade ediyor.");
                break;
            default:
                System.Console.WriteLine("Geçersiz bir sayı girdiniz!!");
                break;
        }
    }
}
