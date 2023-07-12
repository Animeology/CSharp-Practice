namespace CSharp_Practice.TextFiles
{
    public class ReadFileWithFileKeyword
    {
        public static void FileRead()
        {
            Console.WriteLine("Read input.txt file with using the File keyword");

            string fileName = "input.txt";
            string readText = File.ReadAllText(fileName);

            Console.WriteLine(readText);
        }
    }
}
