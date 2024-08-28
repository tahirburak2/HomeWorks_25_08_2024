namespace DateTimes_Soru3;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Lütfen geçerli bir tarih yazınız: ");
        string girilenTarih= Console.ReadLine();
        DateTime tarih = DateTime.Parse(girilenTarih);

        System.Console.Write("üstüne kaç gün eklemek istiyorsunuz: ");
        string girilenTarih2= Console.ReadLine();
        int gun = int.Parse(girilenTarih2);

        System.Console.WriteLine(tarih.AddDays(gun));
    }
}
