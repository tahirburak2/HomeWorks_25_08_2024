namespace DateTimes_Soru4;

class Program
{
    static void Main(string[] args)
    {
        DateTime tarih1= new DateTime(2005,03,04);
        DateTime tarih2= new DateTime(1976,10,01);
        TimeSpan fark = tarih1 - tarih2;
        System.Console.WriteLine(fark);
    }
}
