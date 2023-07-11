namespace CSharp_Practice.Introduction
{
    public class StoreUserInput
    {
        public static void StoringUserInput()
        {
            Console.WriteLine("What is your name?");
            string x = Console.ReadLine()!;
            Console.WriteLine("Nice to meet you, " + x);
        }
    }
}
