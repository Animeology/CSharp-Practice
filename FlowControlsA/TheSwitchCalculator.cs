namespace CSharp_Practice.FlowControlsA
{
    public class TheSwitchCalculator
    {
        public static void SwitchCalculator()
        {
            Console.WriteLine("Input two numbers and operation and it would calculate for you");

            int x = Convert.ToInt32(Console.ReadLine());
            char op = Convert.ToChar(Console.Read());
            int y = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.WriteLine("{0}+{1}={2}", x, y, x + y);
                    break;
                case '-':
                    Console.WriteLine("{0}-{1}={2}", x, y, x - y);
                    break;
                case 'x':
                case '*':
                    Console.WriteLine("{0}x{1}={2}", x, y, x * y);
                    break;
                case '/':
                    Console.WriteLine("{0}/{1}={2}", x, y, x / y);
                    break;
                default:
                    Console.WriteLine("Unrecognized character");
                    break;
            }
        }
    }
}
