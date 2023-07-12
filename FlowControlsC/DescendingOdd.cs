namespace CSharp_Practice.FlowControlsC
{
    public class DescendingOdd
    {
        public static void OddOrEvenDescending()
        {
            Console.WriteLine("Input two numbers which will be a range of numbers");

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Odd or Even?");
            string choice = Console.ReadLine()!;

            switch (choice)
            {
                case "odd":
                case "Odd":
                    for (int i = x; i >= y; i--)
                    {
                        if (i % 2 != 0)
                        {
                            Console.Write("{0}, ", i);
                        }
                    }
                    break;
                case "even":
                case "Even":
                    for (int i = x; i >= y; i--)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write("{0}, ", i);
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Not a valid choice");
                    break;
            }

        }
    }
}
