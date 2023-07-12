namespace CSharp_Practice.DataTypesB
{
    public class NumberCheckerException
    {
        public static void ExceptionsChecker()
        {
            Console.WriteLine("Input a word and it would detect if it is a number or not");

            string line = Convert.ToString(Console.ReadLine()!);

            try
            {
                Convert.ToInt32(line);
                Console.WriteLine("It is a number.");
            }
            catch
            {
                Console.WriteLine("It is not a number.");
            }
        }
    }
}
