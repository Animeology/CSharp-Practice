namespace CSharp_Practice.FlowControlsA
{
    public class DoWhileLoop
    {
        public static void CreateDoWhileLoop()
        {
            Console.WriteLine("Input a number and it would multiple by 10 and keeps going until the input is 0");

            int num = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine(num * 10);
                num = Convert.ToInt32(Console.ReadLine());
            }
            while (num != 0);
        }
    }
}
