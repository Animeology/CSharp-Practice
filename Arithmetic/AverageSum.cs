namespace CSharp_Practice.Arithmetic
{
    public class AverageSum
    {
        public static void Average()
        {
            Console.WriteLine("Input 4 numbers and it will take the average of the 4 numbers.");

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            int num4 = Convert.ToInt32(Console.ReadLine());

            int average = (num1 + num2 + num3 + num4) / 4;

            Console.WriteLine("The average of these four numbers is: {0}", average);
        }
    }
}
