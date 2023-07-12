namespace CSharp_Practice.Arithmetic
{
    public class SumSquare
    {
        public static void SquaredNumber()
        {
            Console.WriteLine("Write a number and the result will be the squared of the number");

            int num = Convert.ToInt32(Console.ReadLine());
            int squaredNum = (num * num);

            Console.WriteLine("{0}x{0}={1}", num, squaredNum);
        }
    }
}
