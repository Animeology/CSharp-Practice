namespace CSharp_Practice.FlowControlsB
{
    public class CountDigits
    {
        public static void Digits()
        {
            Console.WriteLine("Input a number and it would print out how many digits are there");

            int num = Convert.ToInt32(Console.ReadLine());
            int digits = 0;

            if (num < 0)
            {
                Console.WriteLine("(Warning it is a negative number)");
                num = -num;
            }

            while (num > 0)
            {
                num /= 10;

                digits++;
            }

            if (digits == 0)
            {
                digits = 1;
            }

            Console.WriteLine("Number of digits: {0}", digits);
        }
    }
}
