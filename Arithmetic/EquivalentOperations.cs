namespace CSharp_Practice.Arithmetic
{
    public class EquivalentOperations
    {
        public static void Equivalent()
        {
            Console.WriteLine("Input 3 numbers and it would display the results for the two equations.");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            int equation1 = (a + b) * c;
            int equation2 = a * c + b * c;

            Console.WriteLine("({0}+{1}) * {2} = {3}", a, b, c, equation1);
            Console.WriteLine("{0}*{2} + {1}*{2} = {3}", a, b, c, equation2);
        }
    }
}
