namespace DateTlmes_Soru6;

class Program
{
    static void Main(string[] args)
    {
      System.Console.Write("İstedğiniz yılı yazınız: ");
      string girileYil = Console.ReadLine();

      int yil = int.Parse(girileYil);
      bool artikYil = (yil/4==0);
      if  (artikYil){
        System.Console.WriteLine("Artık yıldır");
      }else  {
        System.Console.WriteLine("Artık yıl değildir");
      }
    }
}
