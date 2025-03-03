using System;

namespace ReadmeReaderApp
{
    class Program
    {
        static void Main()
        {
            try
            {
                string content = ReadmeReader.ReadReadme("../../README.md");
                Console.WriteLine(content);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine($"Error: {e.Message}");
            }
        }
    }
}
