namespace CSharp_Practice.DataTypesA
{
    public class Rectangle
    {
        public static void CalculateRectangle()
        {
            Console.WriteLine("Input two numbers to get the Perimeter, Area, and the Diagonal of the Rectangle");

            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            double perimeter = (x * 2) + (y * 2);
            double area = (x * y);
            double diagonal = Convert.ToDouble(Math.Sqrt((x * x) + (y * y)));

            Console.WriteLine("Perimeter = {0}", perimeter);
            Console.WriteLine("Area= {0}", area);
            Console.WriteLine("Diagonal = {0}", diagonal);
        }
    }
}
