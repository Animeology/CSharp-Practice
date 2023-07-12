namespace CSharp_Practice.Arithmetic
{
    public class ZeroDivision
    {
        public static void DivideByZero()
        {
            Console.WriteLine("Divide a number by zero and an exception will appear, otherwise it is just a normal division");

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            try
            {
                Console.WriteLine(x / y);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot Divide By Zero");
            }
        }
    }
}
