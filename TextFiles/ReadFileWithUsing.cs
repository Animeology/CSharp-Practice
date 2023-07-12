namespace CSharp_Practice.TextFiles
{
    public class ReadFileWithUsing
    {
        public static void UsingReadFile()
        {
            Console.WriteLine("Read input.txt file with 'using' keyword");

            string fileName = "input.txt";
            string line;

            using (StreamReader sr = new StreamReader(fileName))
            {
                line = sr.ReadLine()!;

                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine()!;
                }
                sr.Close();
            }
        }
    }
}
