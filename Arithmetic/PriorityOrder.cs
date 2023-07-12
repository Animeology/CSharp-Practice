namespace CSharp_Practice.Arithmetic
{
    public class PriorityOrder
    {
        public static void Priority()
        {
            Console.WriteLine("Input a number and it would print out the results for four different equations");

            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-6 + {0} * 5 = {1}", x, -6 + (x * 5));
            Console.WriteLine("(13 - 2) * {0} = {1}", x, (13 - 2) * x);
            Console.WriteLine("({0} + -2) * (20 / 10) = {1}", x, (x + -2) * (20 / 10));
            Console.WriteLine("(12 + {0} / (5 - 4) = {1}", x, (12 + x) / (5 - 4));
        }
    }
}
