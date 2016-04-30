using Exader.IO;
using System.IO;
using Xunit;

namespace Exader
{
    public static class TestData
    {
        // TODO = FilePaths.CurrentDirectory.SubpathBefore("artifacts") / "src/TestData";
        public static readonly FilePath Path = FilePath.Parse(Directory.GetCurrentDirectory()).SubpathBefore("artifacts") / "src/TestData";

        public static FilePath Temp()
        {
            return (Path / "PleaseIgnore").EnsureDirectoryExists();
        }

        public static FilePath Get(string fileName)
        {
            var path = Path / fileName;
            Assert.True(path.IsFileExists);
            return path;
        }
    }
}
