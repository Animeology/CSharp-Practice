namespace CSharp_Practice.TextFiles
{
    public class WriteFile
    {
        public static void WriteFileStreamWriter()
        {
            Console.WriteLine("Write whatever you want and it will be write into the 'output.txt' file");

            string fileName = "output.txt";

            // Using method
            using (StreamWriter file = File.CreateText(fileName))
            {
                string line;

                do
                {
                    line = Console.ReadLine()!;

                    if (line.Length != 0)
                    {
                        file.WriteLine(line);
                    }
                }
                while (line.Length != 0);
            }
        }
    }
}
