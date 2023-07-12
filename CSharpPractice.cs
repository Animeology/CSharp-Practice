namespace CSharp_Practice
{
    using DataTypesA;
    using Introduction;
    using Arithmetic;
    using GeometryA;
    using FlowControlsA;
    using FlowControlsB;
    using FlowControlsC;
    using CSharp_Practice.DataTypesB;

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

            // Data Types B
            VowelSwitch.VowelOrNot();
            NumberCheckerException.ExceptionsChecker();
            ConditionalOperator.CheckForEven();
            StructureUse.StructUsage();
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
    }
}
