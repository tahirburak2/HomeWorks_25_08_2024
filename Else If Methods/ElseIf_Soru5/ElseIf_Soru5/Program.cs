namespace ElseIf_Soru5;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Üçgen oluyor mu diye kontrol etmek istediğiniz sayıları yazınız: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        
        if (a+b>c&&a+c>b&&b+c>a){
            System.Console.WriteLine("Bu sayılarla üçgen oluşturulabilir.");
        }else {
            System.Console.WriteLine("Bu sayılarla üçgen oluşturulamaz.");
        }
    }
}
