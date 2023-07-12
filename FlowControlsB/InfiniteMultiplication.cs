namespace CSharp_Practice.FlowControlsB
{
    public class InfiniteMultiplication
    {
        public static void InfiniteProduct()
        {
            Console.WriteLine("Input two numbers and the multiplication table (up to 10) in the range will show and it will keep requesting until input is 0");

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            for (int i = x; i <= y; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0}x{1}={2}", i, j, i * j);
                }
                Console.WriteLine();
            }
        }
    }
}
