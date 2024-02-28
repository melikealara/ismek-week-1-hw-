namespace odev7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Aylık elektrik faturası hesaplanacaktır. Kullanıcıdan kaç kWh tükettiğini alınız. Eğer
             tüketim 150’den küçükse kWh’i 10 kuruş, eğer 150 ile 300 arasında ise 20 kuruş, 300
             üzeri ise 40 kuruş olarak hesaplanmaktadır. Kişinin yaptığı tüketime göre faturasının kaç
             TL olacağını hesaplayıp ekrana yazan program.*/

            Console.WriteLine("Please enter your electricity consume as kWh");

            double consumedElectricty = Convert.ToDouble(Console.ReadLine());
            double electricityBill;

            if (consumedElectricty < 150)
            {
                electricityBill = consumedElectricty * 0.10;
                Console.WriteLine($"The electricity bill is : {electricityBill} tl");
            }
            else if (consumedElectricty > 300 )
            {
                electricityBill = consumedElectricty * 0.40;
                Console.WriteLine($"The electricity bill is : {electricityBill} tl");
            }
            else 
            {
                electricityBill = consumedElectricty * 0.20;
                Console.WriteLine($"The electricity bill is : {electricityBill} tl");
            }
            

        }
    }
}
