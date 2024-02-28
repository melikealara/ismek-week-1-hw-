using System.Runtime.ExceptionServices;

namespace odev4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Klavyeden girilen boy ve cinsiyet bilgilerine göre kişinin ideal kilosunu aşağıdaki
               açıklamaya göre hesaplayıp ekrana “İdeal Kilonuz=...” şeklinde yazdırınız.
               Not: Hesaplama Kadın için ayrı erkek için ayrı aşağıdaki bilgilere göre yapılık ekrana
               yazdırılacak.
               Kadınlar için: Boyunuzun ilk 150 santimetresi için 45 kilo, sonraki her 2.5 cm için 2.2 kilo
               ekler.
               Örnek olarak; boyunuz 160 cm ise, ideal kilonuz 45+8.8=53.8 kilogram olacaktır.
               Erkekler için: Boyunuzun ilk 150 santimetresi için 48 kilo, sonraki her 2.5 cm için 2.7 kilo
               ekler.
               Örnek olarak boyunuz 180 cm ise, ideal kilonuz 48+32.4=80.4 kilogram olacaktır.
             */

            Console.WriteLine("First enter your gender as 'f' or 'm', then enter your height in cm.");

            char gender = Convert.ToChar(Console.ReadLine());
            double height = Convert.ToDouble(Console.ReadLine());
            

            if (gender == 'f')
            {
                if (height  > 150) 
                {
                    Console.WriteLine($"Your ideal kilogram is: {IdealKilogramF(height)}");
                }
                else if (height == 150)
                {
                    Console.WriteLine("Your ideal kilogram is 45");
                }
                else 
                { 
                    Console.WriteLine("Please enter height above 150 cm.");
                }
            }
            else if (gender == 'm') 
            {
                if (height > 150)
                {
                    Console.WriteLine($"Your ideal kilogram is: {IdealKilogramM(height)}");
                }
                else if (height == 150)
                {
                    Console.WriteLine("Your ideal kilogram is 45");
                }
                else
                {
                    Console.WriteLine("Please enter height above 150 cm.");
                }
            }
            else
            {
                Console.WriteLine();
            }

            

        }

        static double IdealKilogramF(double height)
        {
            return  (((height - 150)/2.5) * 2.2) + 45;
        }
        static double IdealKilogramM(double height)
        {
            return (((height - 150) / 2.5) * 2.7) + 48;
        }
    }
}
