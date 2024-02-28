namespace odev3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Klavyeden girilen 3 sayının içinden en küçüğünü bulan ve “En küçük sayı: ….” Şeklinde
               ekrana yazan program.
             */

            //sayıların hepsinin farklı olduğu durumu ele aldım.

            Console.WriteLine("Please enter three different numbers.");

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 != num2 || num1 != num3 || num2 != num3)
            {

                if (num1 < num2 && num1 < num3)
                {
                    Console.WriteLine($"The smallest number is: {num1}");
                   
                }
                else if (num2 > num1 && num2 > num3)
                {
                    Console.WriteLine($"The smallest number is: {num2}");
                }
                else
                {
                    Console.WriteLine($"The smallest number is: {num3}");
                }
            }
            else 
            {
                Console.WriteLine("Please enter three different numbers.");
            }


        }
    }
}
