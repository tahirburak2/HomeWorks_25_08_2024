namespace NumberMethods_Soru2;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Birinci sayıyı giriniz: ");
        string sayi1 = Console.ReadLine();

        System.Console.Write("İkinci sayıyı giriniz: ");
        string sayi2 = Console.ReadLine();

        double dsayi1 = double.Parse(sayi1);
        double dsayi2 = double.Parse(sayi2);

        if (dsayi1 > dsayi2)
        {
System.Console.WriteLine("Birinci sayı büyüktür ikinci sayı.");
        }else if(dsayi1<dsayi2){
            System.Console.WriteLine("İkinci sayi büyüktür birinci sayi.");
        }
        
    }
}
