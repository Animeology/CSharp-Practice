﻿using System.IO;

class CSharpPractice
{
    static void Main(string[] args)
    {
        //AppendFile();
        // WriteFile();
        // FileRead();
        // UsingReadFile();
        // ReadFile();

        //int x = Convert.ToInt32(Console.ReadLine());
        //int y = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine(Add(x, y));

        //string name = Console.ReadLine();
        // GreetingAndFarewell(name);

        // Greeting();
        // Farewell();
        // StructUsage();
        // CheckForEven();
        // ExceptionsChecker();
        // VowelOrNot();
        // OddOrEvenDescending();
        // PrimeNumber();
        // Product();
        // AbsoluteValue();
        // Digits();
        // CalculateGrade();
        // InfiniteMultiplication();
        // RepeatingNumber();
        // SumOfInfiniteNums();
        // NumberRange();
        // DoWhileLoop();
        // WhileLoop();
        // GreatestNumber();
        // PosOrNeg();
        // SwitchCalculator();
        // IfCalculator();
        // Rectangle();
        // Square();
        // Equivalent();
        // Average();
        // Priority();
        // DivideByZero();
        // DivisionAndModule();
        // MultiplyThreeFactors();
        // SquaredNumber();
        // RandomGenerator();
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
    static void AppendFile()
    {
        Console.WriteLine("Write whatever and it will add to the current 'output.txt' file if created already");

        string fileName = "output.txt";

        if(File.Exists(fileName))
        {
            using (StreamWriter file = File.AppendText(fileName))
            {
                string line;

                do
                {
                    line = Console.ReadLine();

                    if (line.Length != 0)
                    {
                        file.WriteLine(line);
                   
                    }
                }
                while (line.Length != 0);
            }
        }
        else
        {
            WriteFile();
        }

    }

    static void WriteFile()
    {
        Console.WriteLine("Write whatever you want and it will be write into the 'output.txt' file");

        string fileName = "output.txt";

        // Using method
        using (StreamWriter file = File.CreateText(fileName))
        {
            string line;

            do
            {
                line = Console.ReadLine();

                if(line.Length != 0)
                {
                    file.WriteLine(line);
                }
            }
            while(line.Length != 0);
        }

    }

    static void FileRead()
    {
        Console.WriteLine("Read input.txt file with using the File keyword");

        string fileName = "input.txt";
        string readText = File.ReadAllText(fileName);


        Console.WriteLine(readText);        
    }

    static void UsingReadFile()
    {
        Console.WriteLine("Read input.txt file with 'using' keyword");

        string fileName = "input.txt";
        string line;

        using (StreamReader sr = new StreamReader(fileName))
        {
            line = sr.ReadLine();

            while (line != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }
            sr.Close();
        }
    }

    static void ReadFile()
    {
        Console.WriteLine("Read the contents of input.txt text file");
        
        string fileName = "input.txt";
        string line;

        StreamReader sr = new StreamReader(fileName);
        line = sr.ReadLine();

        while (line != null)
        {
            Console.WriteLine(line);
            line = sr.ReadLine();
        }
        sr.Close();
    }

    static int Add(int x, int y)
    {
        return x + y;
    }

    static void GreetingAndFarewell(string name)
    {
        Console.WriteLine("Hello, {0}", name);
        Console.WriteLine("Good Bye!");
    }

    static void Greeting()
    {
        Console.WriteLine("Hello");
    }

    static void Farewell()
    {
        Console.WriteLine("Good Bye!");
    }

    struct Person
    {
        public string name;
        public int age;
    }

    static void StructUsage()
    {
        Person p;
        p.name = "Joseph";
        p.age = 25;

        Console.WriteLine("Hello, {0}", p.name);
        Console.WriteLine("You are {0}", p.age);
    }

    static void CheckForEven()
    {
        Console.WriteLine("Input two numbers and it would check if both are even or not");

        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        bool isEven = ((x % 2 == 0) && (y % 2 == 0)) ? true : false;
        Console.WriteLine(isEven);
    }

    static void ExceptionsChecker()
    {
        Console.WriteLine("Input a word and it would detect if it is a number or not");

        string line = Convert.ToString(Console.ReadLine());

        try
        {
            Convert.ToInt32(line);
            Console.WriteLine("It is a number.");
        }
        catch
        {
            Console.WriteLine("It is not a number.");
        }
    }

    static void VowelOrNot()
    {
        Console.WriteLine("Input a letter and check if it is a vowel or not");

        char letter = Convert.ToChar(Console.Read());

        // If statement
        if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
        {
            Console.WriteLine("{0} is a vowel", letter);
        }
        else
        {
            Console.WriteLine("{0} is a vowel", letter);
        }

        // switch
        //switch (letter)
        //{
        //    case 'a':
        //    case 'e':
        //    case 'i':
        //    case 'o':
        //    case 'u':
        //        Console.WriteLine("{0} is a vowel", letter);
        //        break;
        //    default:
        //        Console.WriteLine("{0} is a vowel", letter);
        //        break;
        //}
    }

    static void OddOrEvenDescending()
    {
        Console.WriteLine("Input two numbers which will be a range of numbers");

        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Odd or Even?");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "odd":
            case "Odd":
                for (int i = x; i >= y; i--)
                {
                    if (i % 2 != 0)
                    {
                        Console.Write("{0}, ", i);
                    }
                }
                break;
            case "even":
            case "Even":
                for (int i = x; i >= y; i--)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write("{0}, ", i);
                    }
                }
                break;
            default:
                Console.WriteLine("Not a valid choice");
                break;
        }

    }

    static void PrimeNumber()
    {
        Console.WriteLine("Input a number and it will tell if it is a prime number or not");

        int prime = Convert.ToInt32(Console.ReadLine());
        int divider = 2;

        while (prime % divider != 0)
        {
            divider++;
        }

        if (divider == prime)
        {
            Console.WriteLine("{0} is a prime number", prime);
        }
        else
        {
            Console.WriteLine("{0} is not a prime number", prime);
        }
    }

    static void Product()
    {
        Console.WriteLine("Input two numbers and the product of the two numbers is displayed (not using multiplication)");

        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        int total = 0;

        for (int i = 0; i < y; i++)
        {
            total += x;
        }

        Console.WriteLine("{0}x{1}={2}", x, y, total);
    }

    static void AbsoluteValue()
    {
        Console.WriteLine("Input a number and the absolute value of the number is printed");

        int num = Convert.ToInt32(Console.ReadLine());

        if (num > 0)
        {
            Console.WriteLine("Absolute Value is {0}", num);
        }
        else
        {
            num = -num;
            Console.WriteLine("Absolute Value is {0}", num);
        }
    }

    static void Digits()
    {
        Console.WriteLine("Input a number and it would print out how many digits are there");

        int num = Convert.ToInt32(Console.ReadLine());
        int digits = 0;

        if (num < 0)
        {
            Console.WriteLine("(Warning it is a negative number)");
            num = -num;
        }

        while (num > 0)
        {
            num /= 10;

            digits++;
        }

        if (digits == 0)
        {
            digits = 1;
        }

        Console.WriteLine("Number of digits: {0}", digits);
    }

    static void CalculateGrade()
    {
        Console.WriteLine("Input a number between 0 to 10 and it would give the grade letter");

        int grade = Convert.ToInt32(Console.ReadLine());

        switch (grade)
        {
            case 10:
                Console.WriteLine("Grade Letter: A+");
                break;
            case 9:
                Console.WriteLine("Grade Letter: A");
                break;
            case 8:
            case 7:
                Console.WriteLine("Grade Letter: B");
                break;
            case 6:
                Console.WriteLine("Grade Letter: C");
                break;
            case 5:
                Console.WriteLine("Grade Letter: E");
                break;
            default:
                Console.WriteLine("Grade Letter: F");
                break;
        }
    }

    static void InfiniteMultiplication()
    {
        Console.WriteLine("Input two numbers and the multiplication table (up to 10) in the range will show and it will keep requesting until input is 0");

        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        for (int i = x; i <= y; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine("{0}x{1}={2}", i, j, i * j);
            }
            Console.WriteLine();
        }
    }

    static void RepeatingNumber()
    {
        Console.WriteLine("Input a number and the number of times you want to repeat it");

        int num = Convert.ToInt32(Console.ReadLine());
        int repeat = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < repeat; i++)
        {
            Console.Write(num);
        }

    }

    static void SumOfInfiniteNums()
    {
        Console.WriteLine("Request a number and it would keep adding it until the number is 0");

        int num;
        int sum = 0;

        do
        {
            num = Convert.ToInt32(Console.ReadLine());
            sum = num + sum;

            Console.WriteLine(sum);
        }
        while (num != 0);
        Console.WriteLine("Finished!");
    }

    static void NumberRange()
    {
        Console.WriteLine("Input two numbers and it would display all the numbers within the range");

        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        for (int i = x; i <= y; i++)
        {
            Console.Write("{0} ", i);
        }
    }

    static void DoWhileLoop()
    {
        Console.WriteLine("Input a number and it would multiple by 10 and keeps going until the input is 0");

        int num = Convert.ToInt32(Console.ReadLine());

        do
        {
            Console.WriteLine(num * 10);
            num = Convert.ToInt32(Console.ReadLine());
        }
        while (num != 0);
    }

    static void WhileLoop()
    {
        Console.WriteLine("Input a number and it would multiple by 10 and keeps going until the input is 0");

        int num = Convert.ToInt32(Console.ReadLine());

        while (num != 0)
        {
            Console.WriteLine(num * 10);
            num = Convert.ToInt32(Console.ReadLine());
        }
    }

    static void GreatestNumber()
    {
        Console.WriteLine("Input 3 numbers and it would display the greatest one out of the three");

        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        int z = Convert.ToInt32(Console.ReadLine());

        if (x > y && x > z)
        {
            Console.WriteLine(x);
        }

        else if (y > x && y > z)
        {
            Console.WriteLine(y);
        }

        else if (z > x && z > y)
        {
            Console.WriteLine(z);
        }

        else
        {
            Console.WriteLine("There are all equal");
        }

    }

    static void PosOrNeg()
    {
        Console.WriteLine("Input a number and it will tell if it is positive or negative.");

        int num = Convert.ToInt32(Console.ReadLine());

        if (num > 0)
        {
            Console.WriteLine("Positive");
        }
        else
        {
            Console.WriteLine("Negative");
        }
    }

    static void SwitchCalculator()
    {
        Console.WriteLine("Input two numbers and operation and it would calculate for you");

        int x = Convert.ToInt32(Console.ReadLine());
        char op = Convert.ToChar(Console.Read());
        int y = Convert.ToInt32(Console.ReadLine());

        switch (op)
        {
            case '+':
                Console.WriteLine("{0}+{1}={2}", x, y, x + y);
                break;
            case '-':
                Console.WriteLine("{0}-{1}={2}", x, y, x - y);
                break;
            case 'x':
            case '*':
                Console.WriteLine("{0}x{1}={2}", x, y, x * y);
                break;
            case '/':
                Console.WriteLine("{0}/{1}={2}", x, y, x / y);
                break;
            default:
                Console.WriteLine("Unrecognized character");
                break;
        }
    }

    static void IfCalculator()
    {
        Console.WriteLine("Input two numbers and operation and it would calculate for you");

        int x = Convert.ToInt32(Console.ReadLine());
        char op = Convert.ToChar(Console.Read());
        int y = Convert.ToInt32(Console.ReadLine());

        if (op == '+')
        {
            Console.WriteLine("{0}+{1}={2}", x, y, x + y);
        }

        else if (op == '-')
        {
            Console.WriteLine("{0}-{1}={2}", x, y, x - y);
        }

        else if (op == 'x')
        {
            Console.WriteLine("{0}x{1}={2}", x, y, x * y);
        }

        else if (op == '/')
        {
            Console.WriteLine("{0}/{1}={2}", x, y, x / y);
        }

        else
        {
            Console.WriteLine("Unrecognized character");
        }

    }

    static void Rectangle()
    {
        Console.WriteLine("Input the number and the width of the square and it would print out the rectangle of the width and height with the number");

        int num = Convert.ToInt32(Console.ReadLine());
        int width = Convert.ToInt32(Console.ReadLine());
        int height = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Console.Write("{0}", num);
            }
            Console.WriteLine();
        }
    }

    static void Square()
    {
        Console.WriteLine("Input the number and the width of the square and it would print out the square of the width with the number");

        int num = Convert.ToInt32(Console.ReadLine());
        int width = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Console.Write("{0}", num);
            }
            Console.WriteLine();
        }
    }

    static void Equivalent()
    {
        Console.WriteLine("Input 3 numbers and it would display the results for the two equations.");

        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());

        int equation1 = (a + b) * c;
        int equation2 = a * c + b * c;

        Console.WriteLine("({0}+{1}) * {2} = {3}", a, b, c, equation1);
        Console.WriteLine("{0}*{2} + {1}*{2} = {3}", a, b, c, equation2);
    }

    static void Average()
    {
        Console.WriteLine("Input 4 numbers and it will take the average of the 4 numbers.");

        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int num3 = Convert.ToInt32(Console.ReadLine());
        int num4 = Convert.ToInt32(Console.ReadLine());

        int average = (num1 + num2 + num3 + num4) / 4;

        Console.WriteLine("The average of these four numbers is: {0}", average);
    }

    static void Priority()
    {
        Console.WriteLine("Input a number and it would print out the results for four different equations");

        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("-6 + {0} * 5 = {1}", x, -6 + (x * 5));
        Console.WriteLine("(13 - 2) * {0} = {1}", x, (13 - 2) * x);
        Console.WriteLine("({0} + -2) * (20 / 10) = {1}", x, (x + -2) * (20 / 10));
        Console.WriteLine("(12 + {0} / (5 - 4) = {1}", x, (12 + x) / (5 - 4));
    }

    static void DivideByZero()
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

    static void DivisionAndModule()
    {
        Console.WriteLine("Input two integers to get the division and rest of the division of the result");

        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("{0}", x / y);
        Console.WriteLine("{0}", x % y);
    }

    static void MultiplyThreeFactors()
    {
        Console.WriteLine("Input 3 numbers and it would multiple all three numbers for the result");

        int firstNum = Convert.ToInt32(Console.ReadLine());
        int secondNum = Convert.ToInt32(Console.ReadLine());
        int thirdNum = Convert.ToInt32(Console.ReadLine());

        int result = firstNum * secondNum * thirdNum;

        Console.WriteLine("{0}", result);
    }

    static void SquaredNumber()
    {
        Console.WriteLine("Write a number and the result will be the squared of the number");

        int num = Convert.ToInt32(Console.ReadLine());
        int squaredNum = (num * num);

        Console.WriteLine("{0}x{0}={1}", num, squaredNum);
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

        for (int i = 1; i <= 10; i++)
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

        char a = Convert.ToChar(Console.Read());
        char b = Convert.ToChar(Console.Read());
        char c = Convert.ToChar(Console.Read());

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


