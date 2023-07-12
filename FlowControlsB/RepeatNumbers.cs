namespace CSharp_Practice.FlowControlsB
{
    public class RepeatNumbers
    {
        public static void RepeatingNumber()
        {
            Console.WriteLine("Input a number and the number of times you want to repeat it");

            int num = Convert.ToInt32(Console.ReadLine());
            int repeat = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < repeat; i++)
            {
                Console.Write(num);
            }

        }
    }
}
