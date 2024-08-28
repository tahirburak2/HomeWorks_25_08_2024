namespace DateTimes_Soru7;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("geçerli bir tarih giriniz: ");
        string girilenTarih = Console.ReadLine();
long longTarih=long.Parse(girilenTarih);
        DateTime tarih = new DateTime(longTarih);
        System.Console.WriteLine(tarih);

    }
}
