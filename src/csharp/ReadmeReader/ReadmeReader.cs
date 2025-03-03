using System;
using System.IO;

namespace ReadmeReaderApp
{
    public class ReadmeReader
    {
        public static string ReadReadme(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("README.md not found.");
            }
            return File.ReadAllText(filePath);
        }
    }
}
