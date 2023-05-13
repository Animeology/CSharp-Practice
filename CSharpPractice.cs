﻿class CSharpPractice
{
    static void Main(string[] args)
    {
        RandomGenerator();
        // MultiplicationTable();
        // CalculateTimeDistance();
        // CalculateRectangle();
        // CalculateTemperature();
        // Reverse();
        // Calculator();
        // CalculateShapeFromRadius();
        // Comment();
        // StoreUserInput();
        // ReadUserInput();
        // PrintLines();
        // HelloWorld();
    }

    static void RandomGenerator()
    {
        Console.WriteLine("Input two numbers and it would select a random number between these two numbers");

        int firstNum = Convert.ToInt32(Console.ReadLine());
        int secondNum = Convert.ToInt32(Console.ReadLine());

        Random rnd = new Random();
        int randNum = rnd.Next(firstNum, secondNum);

        Console.WriteLine("The random number between {0} and {1} is {2}", firstNum, secondNum, randNum);
    }

    static void MultiplicationTable()
    {
        Console.WriteLine("Input the desire number to go through the multiplicatoin table to 10");

        int num = Convert.ToInt32(Console.ReadLine());
        
        for(int i = 1; i <= 10; i++)
        {
            Console.WriteLine("{0}x{1}={2}", num, i, num * i);
        }
    }

    static void CalculateTimeDistance()
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

    static void CalculateRectangle()
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

    static void CalculateTemperature()
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

    static void Reverse()
    {
        Console.WriteLine("Input 3 letters to print out in reverse:");

        char a = Convert.ToChar(Console.ReadLine());
        char b = Convert.ToChar(Console.ReadLine());
        char c = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("{0}, {1}, {2}", c, b, a);
    }

    static void Calculator()
    {
        Console.WriteLine("Input 2 numbers to calculate through all operations:");

        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Addition: " + (x + y));
        Console.WriteLine("Subtraction: " + (x - y));
        Console.WriteLine("Multiplication: " + (x * y));
        Console.WriteLine("Division: " + (x / y));
        Console.WriteLine("Modulus: " + (x % y));

        Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
        Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
        Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
        Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
        Console.WriteLine("{0} mod {1} = {2}", x, y, x % y);
    }

    static void CalculateShapeFromRadius()
    {
        Console.WriteLine("Input a radius of your choice to calculate the Surface and Volume of the shape:");

        float radius = Convert.ToSingle(Console.ReadLine());
        float pi = 3.14159265359f;

        float surface = 4 * pi * (radius * radius);
        float volume = 4 / 3 * pi * (radius * radius * radius);

        Console.WriteLine("Surface: " + surface);
        Console.WriteLine("Volume: " + volume);
    }

    static void Comment()
    {
        // This is a comment
    }

    static void StoreUserInput()
    {
        Console.WriteLine("What is your name?");
        string x = Console.ReadLine();
        Console.WriteLine("Nice to meet you, " + x);
    }

    static void ReadUserInput()
    {
        Console.WriteLine("What is your favorite animal?");
        Console.Read();
        Console.WriteLine("Mine too!");
    }

    static void PrintLines()
    {
        Console.WriteLine("Hello");
        Console.WriteLine("Joseph");
    }

    static void HelloWorld()
    {
        Console.Write("Hello World!");
    }

}

