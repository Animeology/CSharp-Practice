namespace CSharp_Practice.Arithmetic
{
    public class MultiplicationOfThreeFactors
    {
        public static void MultiplyThreeFactors()
        {
            Console.WriteLine("Input 3 numbers and it would multiple all three numbers for the result");

            int firstNum = Convert.ToInt32(Console.ReadLine());
            int secondNum = Convert.ToInt32(Console.ReadLine());
            int thirdNum = Convert.ToInt32(Console.ReadLine());

            int result = firstNum * secondNum * thirdNum;

            Console.WriteLine("{0}", result);
        }
    }
}
