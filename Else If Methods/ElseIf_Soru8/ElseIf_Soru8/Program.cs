namespace ElseIf_Soru8;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Bir sayı yazınız:");
        int sayi =int.Parse(Console.ReadLine());
        if (sayi%3==0&&sayi%5==0){
            System.Console.WriteLine("Yazdığınız sayı 3 ve 5 sayılarına tam bölünüyor");
        }else {
            System.Console.WriteLine("Yazdığınız sayı 3 ve 5 sayılarına tam bölünmüyor.");
        }
    }
}
