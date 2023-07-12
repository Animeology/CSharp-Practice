namespace CSharp_Practice.FlowControlsC
{
    public class PrimeNumber
    {
        public static void PrimeNumberChecker()
        {
            Console.WriteLine("Input a number and it will tell if it is a prime number or not");

            int prime = Convert.ToInt32(Console.ReadLine());
            int divider = 2;

            while (prime % divider != 0)
            {
                divider++;
            }

            if (divider == prime)
            {
                Console.WriteLine("{0} is a prime number", prime);
            }
            else
            {
                Console.WriteLine("{0} is not a prime number", prime);
            }
        }
    }
}
