namespace CSharp_Practice.FlowControlsC
{
    public class Product
    {
        public static void DisplayProduct()
        {
            Console.WriteLine("Input two numbers and the product of the two numbers is displayed (not using multiplication)");

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            int total = 0;

            for (int i = 0; i < y; i++)
            {
                total += x;
            }

            Console.WriteLine("{0}x{1}={2}", x, y, total);
        }
    }
}
