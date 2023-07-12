namespace CSharp_Practice.FlowControlsA
{
    public class TheIFCalculator
    {
        public static void IfCalculator()
        {
            Console.WriteLine("Input two numbers and operation and it would calculate for you");

            int x = Convert.ToInt32(Console.ReadLine());
            char op = Convert.ToChar(Console.Read());
            int y = Convert.ToInt32(Console.ReadLine());

            if (op == '+')
            {
                Console.WriteLine("{0}+{1}={2}", x, y, x + y);
            }

            else if (op == '-')
            {
                Console.WriteLine("{0}-{1}={2}", x, y, x - y);
            }

            else if (op == 'x')
            {
                Console.WriteLine("{0}x{1}={2}", x, y, x * y);
            }

            else if (op == '/')
            {
                Console.WriteLine("{0}/{1}={2}", x, y, x / y);
            }

            else
            {
                Console.WriteLine("Unrecognized character");
            }
        }
    }
}
