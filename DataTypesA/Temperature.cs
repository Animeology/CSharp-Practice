namespace CSharp_Practice.DataTypesA
{
    public class Temperature
    {
        public static void CalculateTemperature()
        {
            Console.WriteLine("Input your degree in Celsius to convert to Kelvin and Fahrenheit:");

            int celsius = Convert.ToInt32(Console.ReadLine());

            int kelvin = celsius + 273;
            int fahrenheit = celsius * 18 / 10 + 32;

            Console.WriteLine("Kelvin: " + kelvin + " degrees");
            Console.WriteLine("Fahrenheit: " + fahrenheit + " degrees");

            Console.WriteLine("Kelvin = {0}", kelvin);
            Console.WriteLine("Fahrenheit = {0}", fahrenheit);
        }
    }
}
