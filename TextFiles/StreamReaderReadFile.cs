namespace CSharp_Practice.TextFiles
{
    public class StreamReaderReadFile
    {
        public static void ReadFile()
        {
            Console.WriteLine("Read the contents of input.txt text file");

            string fileName = "input.txt";
            string line;

            StreamReader sr = new StreamReader(fileName);
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
