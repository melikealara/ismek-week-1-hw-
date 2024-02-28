using System.Collections.Generic;

namespace odev5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Muhtaç öğrencilere taban olarak 1000TL burs verilmektedir. Ancak öğrencinin okuduğu
            //okula göre bu paranın üzerine belirli miktarda ekleme yapılacaktır.Eğer ilkokul ise ekleme
            //yapılmayacak, ortaokul ise 20TL, lise ise 50TL, üniversite ise 100TL eklenecektir.
            //Öğrencinin okuduğu okulun seçimine göre kaç tl burs alacağını gösteren program.

            Console.WriteLine("Please enter your school level(university, high school, middle school and elementary school)");

            string schoolLevel = Console.ReadLine().ToLower();
            int tabanBurs = 1000;


            if (schoolLevel == "university")
            {
                Console.WriteLine(tabanBurs + 100);
            }
            else if (schoolLevel == "high school")
            {
                Console.WriteLine(tabanBurs + 50);
            }
            else if (schoolLevel == "middle school")
            {
                Console.WriteLine(tabanBurs + 20);
            }
            else if (schoolLevel == "elementary school")
            {
                Console.WriteLine(tabanBurs);
            }
            else
            {
                Console.WriteLine("Please enter correct values.");
            }
        }
    }
}
