namespace CSharp_Practice.DataTypesA
{
    public class CalculateRadius
    {
        public static void CalculateShapeFromRadius()
        {
            Console.WriteLine("Input a radius of your choice to calculate the Surface and Volume of the shape:");

            float radius = Convert.ToSingle(Console.ReadLine());
            float pi = 3.14159265359f;

            float surface = 4 * pi * (radius * radius);
            float volume = 4 / 3 * pi * (radius * radius * radius);

            Console.WriteLine("Surface: " + surface);
            Console.WriteLine("Volume: " + volume);
        }
    }
}
