namespace CSharp_Practice.DataTypesA
{
    public class TimeDistance
    {
        public static void CalculateTimeDistance()
        {
            Console.WriteLine("Input the desire distance in meters and the time in hours, minutes, seconds in this order to calculate speed in m/s, km/h, m/h");

            float distance = Convert.ToSingle(Console.ReadLine());
            float hour = Convert.ToSingle(Console.ReadLine());
            float minute = Convert.ToSingle(Console.ReadLine());
            float second = Convert.ToSingle(Console.ReadLine());

            float totalSeconds = (hour * 3600) + (minute * 60) + second;

            float metersPerSec = distance / totalSeconds;
            float kilometersPerHour = (distance / 1000.0f) / (totalSeconds / 3600.0f);
            float milesPerHour = kilometersPerHour / 1.609f;

            Console.WriteLine("Speed in meter/sec is {0}", metersPerSec);
            Console.WriteLine("Speed in km/h is {0}", kilometersPerHour);
            Console.WriteLine("Speed in miles/h is {0}", milesPerHour);
        }
    }
}
