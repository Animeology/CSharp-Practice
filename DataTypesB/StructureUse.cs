using CSharp_Practice.Structures;

namespace CSharp_Practice.DataTypesB
{
    public class StructureUse
    {
        public static void StructUsage()
        {
            Person p;
            p.name = "Joseph";
            p.age = 25;

            Console.WriteLine("Hello, {0}", p.name);
            Console.WriteLine("You are {0}", p.age);
        }
    }
}
