

namespace FileInteraction 
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] text = {"Hi!", "Hello there!", "How's it going?"};

            string path = @".\TestFile.txt";

            File.WriteAllLines(path, text);
        }
    }
}