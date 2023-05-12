using System;

class CSharpPractice
{
    static void Main(string[] args)
    {
        Comment();
        // StoreUserInput();
        // ReadUserInput();
        // PrintLines();
        // HelloWorld();
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

