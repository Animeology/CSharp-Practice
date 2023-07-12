namespace CSharp_Practice.FlowControlsA
{
    public class GreatestNumber
    {
        public static void SearchForGreatestNumber()
        {
            Console.WriteLine("Input 3 numbers and it would display the greatest one out of the three");

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());

            if (x > y && x > z)
            {
                Console.WriteLine(x);
            }

            else if (y > x && y > z)
            {
                Console.WriteLine(y);
            }

            else if (z > x && z > y)
            {
                Console.WriteLine(z);
            }

            else
            {
                Console.WriteLine("There are all equal");
            }
        }
    }
}
