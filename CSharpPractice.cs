class CSharpPractice
{
    static void Main(string[] args)
    {
        CalculateShapeFromRadius();
        // Comment();
        // StoreUserInput();
        // ReadUserInput();
        // PrintLines();
        // HelloWorld();
    }

    static void CalculateShapeFromRadius()
    {
        Console.WriteLine("Input a radius of your choice to calculate the Surface and Volume of the shape: ");

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

