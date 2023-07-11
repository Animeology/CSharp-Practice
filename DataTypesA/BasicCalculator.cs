namespace CSharp_Practice.DataTypesA
{
    public class BasicCalculator
    {
        public static void Calculator()
        {
            Console.WriteLine("Input 2 numbers to calculate through all operations:");

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Addition: " + (x + y));
            Console.WriteLine("Subtraction: " + (x - y));
            Console.WriteLine("Multiplication: " + (x * y));
            Console.WriteLine("Division: " + (x / y));
            Console.WriteLine("Modulus: " + (x % y));

            Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
            Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
            Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
            Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
            Console.WriteLine("{0} mod {1} = {2}", x, y, x % y);
        }
    }
}
