namespace Ismekodev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Suyun sıcaklık değeri dirildiğinde suyun sıcaklığına göre maddenin halini(katı, sıvı, gaz)
               gösteren program. Not: suyun kaynama ısısı 100 donma ısısı 0 derece 
             */

            //0 ve 100 derecede su iki halde de bulunabiliyor ama ben sıvı olarak kabul ettim.

            int degree = Convert.ToInt32(Console.ReadLine());

            if (degree > 0)
            {
                Console.WriteLine("katı");
            }
            else if (degree < 0)
            {
                Console.WriteLine("gaz");
            }
            else
            {
                Console.WriteLine("sıvı");
            }








        }
    }
}
