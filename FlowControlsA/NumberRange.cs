namespace CSharp_Practice.FlowControlsA
{
    public class NumberRange
    {
        public static void DisplayNumberRange()
        {
            Console.WriteLine("Input two numbers and it would display all the numbers within the range");

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            for (int i = x; i <= y; i++)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}
