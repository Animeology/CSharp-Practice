namespace CSharp_Practice.GeometryA
{
    public class SquareShape
    {
        public static void Square()
        {
            Console.WriteLine("Input the number and the width of the square and it would print out the square of the width with the number");

            int num = Convert.ToInt32(Console.ReadLine());
            int width = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < width; i++)
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
