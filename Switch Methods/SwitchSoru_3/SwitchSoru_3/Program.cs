namespace SwitchSoru_3;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("İşleme sok ak istediğiniz 2 sayıyı yazınız: ");
        int sayi1=int.Parse(Console.ReadLine());
        int sayi2 = int.Parse(Console.ReadLine());
        System.Console.Write("Hangi işlemi yapmak istediğinizi seçiniz(+,-,/,*):");
        string sembol = Console.ReadLine();
        switch (sembol)
        {
            case "+":
            System.Console.WriteLine(sayi1+sayi2);
            break;
            case "-":
                System.Console.WriteLine(sayi1 - sayi2);
                break;
            case "*":
                System.Console.WriteLine(sayi1 * sayi2);
                break;
            case "/":
                System.Console.WriteLine(sayi1 / sayi2);
                break;
            default:
            System.Console.WriteLine("Geçersiz sembol girdiniz");
            break;
        }
    }
}
