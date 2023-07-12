namespace CSharp_Practice.DataTypesA
{
    public class Reverse
    {
        public static void ReverseCharacters()
        {
            Console.WriteLine("Input 3 letters to print out in reverse:");

            char a = Convert.ToChar(Console.Read());
            char b = Convert.ToChar(Console.Read());
            char c = Convert.ToChar(Console.Read());

            Console.WriteLine("{0}, {1}, {2}", c, b, a);
        }
    }
}
