namespace ElseIf_Soru2;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Sıralanmasını istediğiniz 3 sayıyı yazınız: ");
        int sayi1 = int.Parse(Console.ReadLine());
        int sayi2 = int.Parse(Console.ReadLine());
        int sayi3 = int.Parse(Console.ReadLine());

        if (sayi1>sayi2&&sayi2>sayi3){
            System.Console.Write((sayi1)+" büyüktür "+(sayi2)+" büyüktür "+(sayi3));
        }else if (sayi2 > sayi1 && sayi2 > sayi3&&sayi1>sayi3){
            System.Console.Write((sayi2) + " büyüktür " + (sayi1) + " büyüktür " + (sayi3));
        }else if (sayi1 > sayi2 && sayi3 > sayi2 && sayi1 > sayi3)
        {
            System.Console.Write((sayi1) + " büyüktür " + (sayi3) + " büyüktür " + (sayi2));
        }else if (sayi2 > sayi1 && sayi3 > sayi1 && sayi2 > sayi3)
        {
            System.Console.Write((sayi2) + " büyüktür " + (sayi3) + " büyüktür " + (sayi1));
        }else if (sayi3 > sayi1 && sayi3 > sayi2 && sayi2 > sayi1)
        {
            System.Console.Write((sayi3) + " büyüktür " + (sayi2) + " büyüktür " + (sayi1));
        }else if (sayi3 > sayi1 && sayi3 > sayi2 && sayi1 > sayi2){
            System.Console.Write((sayi3) + " büyüktür " + (sayi1) + " büyüktür " + (sayi2));
        }
    }
}
