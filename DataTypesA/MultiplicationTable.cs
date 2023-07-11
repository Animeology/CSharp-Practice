namespace CSharp_Practice.DataTypesA
{
    public class MultiplicationTable
    {
        public static void CreateMultiplicationTable()
        {
            Console.WriteLine("Input the desire number to go through the multiplicatoin table to 10");

            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0}x{1}={2}", num, i, num * i);
            }
        }
    }
}
