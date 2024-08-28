namespace DateTimes_Soru5;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("yılın kaçıncı gününü bulmamızı istediğiniz tarihi yazınız: ");
        string girilenTarih = Console.ReadLine();

        DateTime tarih = DateTime.Parse(girilenTarih);

        int yılGun = tarih.DayOfYear;
        System.Console.WriteLine(yılGun);
    }
}
