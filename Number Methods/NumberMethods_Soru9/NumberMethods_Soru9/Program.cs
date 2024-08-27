namespace NumberMethods_Soru9;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("İki farklı sayı yazınız: ");
        string sayi1= Console.ReadLine();
        string sayi2= Console.ReadLine();

        int isayi1 = int.Parse(sayi1);
        int isayi2 = int.Parse(sayi2);

        if (isayi1>isayi2){
            System.Console.WriteLine(sayi1+" büyüktür "+sayi2);
        }else if(isayi2>isayi1){
            System.Console.WriteLine(sayi2 + " büyüktür " + sayi1);
        }
            
        
    }
}
