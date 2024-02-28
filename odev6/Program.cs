namespace odev6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Bir satıcı sattığı mallardan belirli oranda komisyon almaktadır. 200TL’ye kadar olan
             satışlardan %3, daha fazla olanlardan ise %2 komisyon almaktadır. Buna göre
             klavyeden girilen 3 satış tutarından satıcının alacağı komisyonları ve toplam komisyonu
             ekrana yazan program. (Not: Henüz döngüleri öğrenmedik döngü kullanmayınız).
            */

            
            Console.WriteLine("enter 3 sales");
            double sales1 = Convert.ToDouble(Console.ReadLine());
            double sales2 = Convert.ToDouble(Console.ReadLine());
            double sales3 = Convert.ToDouble(Console.ReadLine());
            double percentage;
            double brokerage = 0;
            
            //SALES1

            if (sales1 > 200 )
            {
                percentage = 0.03;
                brokerage += sales1 * percentage;
                Console.WriteLine($"sales1 brokersage: {sales1 * percentage}");
            }
            else
            {
                percentage = 0.02;
                brokerage += sales1 * percentage;
                Console.WriteLine($"sales1 brokersage: {sales1 * percentage}");
            }

            //SALES2

            if (sales2 > 200)
            {
                percentage = 0.03;
                brokerage += sales2 * percentage;
                Console.WriteLine($"sales2 brokersage: {sales2 * percentage}");
            }
            else
            {
                percentage = 0.02;
                brokerage += sales2 * percentage;
                Console.WriteLine($"sales2 brokersage: {sales2 * percentage}");
            }

            //SALES3

            if (sales3 > 200)
            {
                percentage = 0.03;
                brokerage += sales3 * percentage;
                Console.WriteLine($"sales3 brokersage: {sales3 * percentage}");
            }
            else
            {
                percentage = 0.02;
                brokerage += sales3 * percentage;
                Console.WriteLine($"sales3 brokersage: {sales3 * percentage}");
            }

            Console.WriteLine($"total brokerage: {brokerage}");


        }
    }
}
