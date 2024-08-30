namespace Switch_Soru10;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("'+,-,*,/,%' içinden bir işlem seçiniz: ");
        char sembol = Convert.ToChar(Console.ReadLine());

        switch (sembol)
        {
            case '+':
            System.Console.WriteLine("Girdiğiniz sembolün adı 'artıdır'.");
            break;
            case '-':
                System.Console.WriteLine("Girdiğiniz sembolün adı 'eksidir'.");
                break;
            case '*':
                System.Console.WriteLine("Girdiğiniz sembolün adı 'çarpıdır'.");
                break;
            case '/':
                System.Console.WriteLine("Girdiğiniz sembolün adı 'bölümdür'.");
                break;
            case '%':
                System.Console.WriteLine("Girdiğiniz sembolün adı 'yüzde almadır'.");
                break;

            default:
            System.Console.WriteLine("Girdiğiniz sembol hatalıdır.");
            break;
        }
    }
}
