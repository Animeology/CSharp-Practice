namespace CSharp_Practice.DataTypesB
{
    public class ConditionalOperator
    {
        public static void CheckForEven()
        {
            Console.WriteLine("Input two numbers and it would check if both are even or not");

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            bool isEven = ((x % 2 == 0) && (y % 2 == 0)) ? true : false;
            Console.WriteLine(isEven);
        }
    }
}
