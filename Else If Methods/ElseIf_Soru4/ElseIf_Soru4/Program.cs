namespace ElseIf_Soru4;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Artık yıl mı diye kontorl etmek istediğiniz yılı yazınız: ");
        int yıl = int.Parse(Console.ReadLine());
        if (yıl%4==0){
            System.Console.WriteLine("Girilen yıl artık yıldır");
        }else  {
            System.Console.WriteLine("girilen yıl artık yıl değildir");
        }
    }
}
