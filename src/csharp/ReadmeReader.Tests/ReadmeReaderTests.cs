using System;
using System.IO;
using NUnit.Framework;
using ReadmeReaderApp;

namespace ReadmeReaderTests
{
    [TestFixture]
    public class ReadmeReaderTests
    {
        [Test]
        public void ReadReadme_ShouldReturnFileContent()
        {
            string tempPath = Path.GetTempFileName();
            File.WriteAllText(tempPath, "Sample README content");

            string content = ReadmeReader.ReadReadme(tempPath);

            Assert.AreEqual("Sample README content", content);

            File.Delete(tempPath);
        }

        [Test]
        public void ReadReadme_ShouldThrowException_WhenFileNotFound()
        {
            var ex = Assert.Throws<FileNotFoundException>(() => ReadmeReader.ReadReadme("non_existent.md"));
            Assert.AreEqual("README.md not found.", ex.Message);
        }
    }
}
