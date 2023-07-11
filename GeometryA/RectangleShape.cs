namespace CSharp_Practice.GeometryA
{
    public class RectangleShape
    {
        public static void Rectangle()
        {
            Console.WriteLine("Input the number and the width of the square and it would print out the rectangle of the width and height with the number");

            int num = Convert.ToInt32(Console.ReadLine());
            int width = Convert.ToInt32(Console.ReadLine());
            int height = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("{0}", num);
                }
                Console.WriteLine();
            }
        }
    }
}
