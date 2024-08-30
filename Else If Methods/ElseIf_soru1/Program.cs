namespace ElseIf_soru1;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Lütfen bir sayı giriniz: ");
        string girilen = Console.ReadLine();

        int sayi = int.Parse(girilen);
        

        if (sayi>0){
            System.Console.WriteLine("Girilen sayı '0'dan büyüktür. ");
        }else if (sayi<0){
            System.Console.WriteLine("Girilen sayı '0'dan küçüktür. ");
        }else {
            System.Console.WriteLine("girilen sayı '0'a eşittir. ");
        }
    }
}
