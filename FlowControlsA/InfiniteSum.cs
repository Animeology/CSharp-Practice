namespace CSharp_Practice.FlowControlsA
{
    public class InfiniteSum
    {
        public static void SumOfInfiniteNums()
        {
            Console.WriteLine("Request a number and it would keep adding it until the number is 0");

            int num;
            int sum = 0;

            do
            {
                num = Convert.ToInt32(Console.ReadLine());
                sum = num + sum;

                Console.WriteLine(sum);
            }
            while (num != 0);
            Console.WriteLine("Finished!");
        }
    }
}
