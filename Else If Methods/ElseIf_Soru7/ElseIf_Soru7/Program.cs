namespace ElseIf_Soru7;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("istediğiniz 3 sayıyı yazınız: ");
        int sayi1 = int.Parse(Console.ReadLine());
        int sayi2 = int.Parse(Console.ReadLine());
        int sayi3 = int.Parse(Console.ReadLine());

        if (sayi1>sayi2&&sayi1>sayi3){
            System.Console.WriteLine(sayi1+"en büyük sayidir.");
        }else if(sayi2 > sayi1 && sayi2 > sayi3){
            System.Console.WriteLine(sayi2+"en büyük sayidir.");
        }else if (sayi3 > sayi2 && sayi3 > sayi1){
            System.Console.WriteLine(sayi3+"en büyük sayıdır.");
        }
    }
}
