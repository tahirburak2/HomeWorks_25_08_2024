namespace DateTimes_Soru9;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Tarih giriniz: ");
        long girilenTarih = long.Parse(Console.ReadLine());
        DateTime tarih = new DateTime(girilenTarih);

        System.Console.Write("2. bir tarih giriniz: ");
        long girilenTarih2 = long.Parse(Console.ReadLine());
        DateTime tarih2 = new DateTime(girilenTarih2);

        if (tarih>tarih2){
            System.Console.WriteLine(tarih+" tarihi büyüktür "+tarih2+" tarihinden.");

        
        }else if (tarih<tarih2){
            System.Console.WriteLine(tarih2 + " tarihi büyüktür " + tarih + " tarihinden.");
        }else {
            System.Console.WriteLine("bu iki tarih eşittir.");
        }
    }
}
