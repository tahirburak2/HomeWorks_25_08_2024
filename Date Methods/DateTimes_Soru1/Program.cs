namespace DateTimes_Soru1;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Geçerli formatta bir tarih giriniz: ");
        string girilenTarih = Console.ReadLine();

        DateTime tarih = DateTime.Parse(girilenTarih);
        DayOfWeek gun = tarih.DayOfWeek;
        System.Console.WriteLine(gun);
    }
}
