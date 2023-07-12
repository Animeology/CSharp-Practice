namespace CSharp_Practice.FlowControlsB
{
    public class TheGradeCalculator
    {
        public static void CalculateGrade()
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
    }
}
