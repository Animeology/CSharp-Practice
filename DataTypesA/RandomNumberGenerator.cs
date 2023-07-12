namespace CSharp_Practice.DataTypesA
{
    public class RandomNumberGenerator
    {
        public static void RandomGenerator()
        {
            Console.WriteLine("Input two numbers and it would select a random number between these two numbers");

            int firstNum = Convert.ToInt32(Console.ReadLine());
            int secondNum = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            int randNum = rnd.Next(firstNum, secondNum);

            Console.WriteLine("The random number between {0} and {1} is {2}", firstNum, secondNum, randNum);
        }
    }
}
