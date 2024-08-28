namespace DateTimes_Soru8;

class Program
{
    static void Main(string[] args)
    {
        DateTime suankiTarih =  DateTime.Now;
        string ay = suankiTarih.ToString("MMMM");
        System.Console.WriteLine(ay);
    }
}
