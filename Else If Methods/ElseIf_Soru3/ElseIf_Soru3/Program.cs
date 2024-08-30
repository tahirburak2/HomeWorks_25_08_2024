namespace ElseIf_Soru3;

class Program
{
    static void Main(string[] args)
    {
       System.Console.WriteLine("Bir harf giriniz: ");
       char harf = Console.ReadKey().KeyChar;
       System.Console.WriteLine();
       string sesli = "aeiıoöüuAEİIOÖÜU";
       if (sesli.IndexOf(harf) =>0){
        System.Console.WriteLine("Girdiğiniz harf sesli harf");
       }
    }
}
