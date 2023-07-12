namespace CSharp_Practice.TextFiles
{
    public class AppendFile
    {
        public static void AppendFileUsingFile()
        {
            Console.WriteLine("Write whatever and it will add to the current 'output.txt' file if created already");

            string fileName = "output.txt";

            if (File.Exists(fileName))
            {
                using (StreamWriter file = File.AppendText(fileName))
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
            else
            {
                WriteFile.WriteFileStreamWriter();
            }
        }
    }
}
