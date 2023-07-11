namespace CSharp_Practice.Arithmetic
{
    public class Division
    {
        public static void DivisionAndModule()
        {
            Console.WriteLine("Input two integers to get the division and rest of the division of the result");

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}", x / y);
            Console.WriteLine("{0}", x % y);
        }
    }
}
