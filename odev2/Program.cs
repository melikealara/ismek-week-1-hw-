namespace odev2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen bir sayının kullanıcı seçimine bağlı olarak karesini, küpünü ve karekökünü
            //alan programı

            Console.WriteLine("Please first enter the math operation type, then enter the number");
            Console.WriteLine("For square, please enter 0.");
            Console.WriteLine("For cube, please enter 1.");
            Console.WriteLine("For square root, please enter 2.");


            int operationType = Convert.ToInt32(Console.ReadLine());
            int number = Convert.ToInt32(Console.ReadLine());


            switch (operationType)
            {
                case 0: 
                    {
                        Console.WriteLine(number * number);
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine(number * number * number);
                        
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine(Math.Sqrt(number));
                        
                        break;
                    }
                default:
                    {
                        Console.WriteLine("You entered wrong value. Please try again");

                    }
                    break;

            }
                
        }
    }
}
