namespace CSharp_Practice.FlowControlsC
{
    public class AbsoluteValue
    {
        public static void DisplayAbsoluteValue()
        {
            Console.WriteLine("Input a number and the absolute value of the number is printed");

            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("Absolute Value is {0}", num);
            }
            else
            {
                num = -num;
                Console.WriteLine("Absolute Value is {0}", num);
            }
        }
    }
}
