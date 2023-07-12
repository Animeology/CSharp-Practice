namespace CSharp_Practice.FlowControlsA
{
    public class PositiveAndNegative
    {
        public static void PosOrNeg()
        {
            Console.WriteLine("Input a number and it will tell if it is positive or negative.");

            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("Positive");
            }
            else
            {
                Console.WriteLine("Negative");
            }
        }
    }
}
