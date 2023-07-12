namespace CSharp_Practice
{
    using DataTypesA;
    using Introduction;
    using Arithmetic;
    using GeometryA;
    using FlowControlsA;
    using FlowControlsB;
    using FlowControlsC;
    using DataTypesB;
    using FunctionsA;
    using CSharp_Practice.TextFiles;

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

            // Functions A
            GreetingAndFarewell.Greeting();
            GreetingAndFarewell.Farewell();
            FunctionWithParameters.GreetingAndFarewell("Joseph");
            FunctionWithReturnValue.Add(10, 15);

            // Text File
            StreamReaderReadFile.ReadFile();
            ReadFileWithUsing.UsingReadFile();
            ReadFileWithFileKeyword.FileRead();
            WriteFile.WriteFileStreamWriter();
            AppendFile.AppendFileUsingFile();
        }
    }
}
