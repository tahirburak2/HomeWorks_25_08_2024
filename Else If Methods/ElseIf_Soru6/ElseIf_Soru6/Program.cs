namespace ElseIf_Soru6;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Başarı notunuzu giriniz: ");
        int not =int.Parse(Console.ReadLine());
        if (not<=100&&not>=90){
            System.Console.WriteLine("Harf notunuz 'AA'");
        }else if (not <= 89 && not >= 85){
            System.Console.WriteLine("harf notunuz 'BA'");
        }else if (not <= 84 && not >= 80){
            System.Console.WriteLine("harf notunuz 'BB'");
        }
        else if (not <= 79 && not >= 70){
            System.Console.WriteLine("harf notunuz 'CB'");
        }
        else if (not <= 69 && not >= 60){
            System.Console.WriteLine("harf notunuz 'CC'");
        }
        else if (not <= 59 && not >= 55){
            System.Console.WriteLine("harf notunuz 'DC'");
        }
        else if (not <= 54 && not >= 50){
            System.Console.WriteLine("harf notunuz 'DD'");
        }
        else if (not <= 49 && not >= 40){
            System.Console.WriteLine("harf notunuz 'FD'");
        }
        else if (not <= 39 && not >= 0){
            System.Console.WriteLine("harf notunuz 'FF'");
        }
    }
}
