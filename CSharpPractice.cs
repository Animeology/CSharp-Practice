namespace CSharp_Practice
{
    using DataTypesA;
    using Introduction;
    using Arithmetic;
    using GeometryA;
    using FlowControlsA;
    using FlowControlsB;
    using FlowControlsC;

    class CSharpPractice
    {
        static void Main(string[] args)
        {
            // Introduction
            HelloWorld.PrintHelloWorld();
            PrintLines.PrintingLines();
            ReadUserInput.ReadingUserInput();
            StoreUserInput.StoringUserInput();
            Comment.Commenting();

            // DataTypes A
            CalculateRadius.CalculateShapeFromRadius();
            BasicCalculator.Calculator();
            Reverse.ReverseCharacters();
            Temperature.CalculateTemperature();
            Rectangle.CalculateRectangle();
            TimeDistance.CalculateTimeDistance();
            MultiplicationTable.CreateMultiplicationTable();
            RandomNumberGenerator.RandomGenerator();

            // Arithmetic
            SumSquare.SquaredNumber();
            MultiplicationOfThreeFactors.MultiplyThreeFactors();
            Division.DivisionAndModule();
            ZeroDivision.DivideByZero();
            PriorityOrder.Priority();
            AverageSum.Average();
            EquivalentOperations.Equivalent();

            // Geometry A
            SquareShape.Square();
            RectangleShape.Rectangle();

            // Flow Controls A
            TheIFCalculator.IfCalculator();
            TheSwitchCalculator.SwitchCalculator();
            PositiveAndNegative.PosOrNeg();
            GreatestNumber.SearchForGreatestNumber();
            WhileLoop.CreateWhileLoop();
            DoWhileLoop.CreateDoWhileLoop();
            NumberRange.DisplayNumberRange();
            InfiniteSum.SumOfInfiniteNums();

            // Flow Controls B
            RepeatNumbers.RepeatingNumber();
            InfiniteMultiplication.InfiniteProduct();
            TheGradeCalculator.CalculateGrade();
            CountDigits.Digits();

            // Flow Controls C
            AbsoluteValue.DisplayAbsoluteValue();
            Product.DisplayProduct();
            PrimeNumber.PrimeNumberChecker();
            DescendingNumbers.OddOrEvenDescending();
        }


        static void AppendFile()
        {
            Console.WriteLine("Write whatever and it will add to the current 'output.txt' file if created already");

            string fileName = "output.txt";

            if (File.Exists(fileName))
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

                    if (line.Length != 0)
                    {
                        file.WriteLine(line);
                    }
                }
                while (line.Length != 0);
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
    }
}
