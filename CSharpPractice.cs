using System;

class CSharpPractice
{
    static void Main(string[] args)
    {
        ReadUserInput();
        // PrintLines();
        // HelloWorld();
    }

    static void HelloWorld()
    {
        Console.Write("Hello World!");
    }

    static void PrintLines()
    {
        Console.WriteLine("Hello");
        Console.WriteLine("Joseph");
    }

    static void ReadUserInput()
    {
        Console.WriteLine("What is your favorite animal?");
        Console.Read();
        Console.WriteLine("Mine too!");
    }
}

