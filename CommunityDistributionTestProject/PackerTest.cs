using System.Diagnostics;
using System.IO;
using System.Linq;
using Xunit;

namespace CommunityDistributionTestProject
{
    public class PackerTest
    {
#if DEBUG
        private const string ConfigFolder = "Debug";
#else
        private const string ConfigFolder = "Release";
#endif
        [Fact]
        public void TestPacker()
        {
            string folder = @"..\..\..\..\PackerTest\bin\" + ConfigFolder + @"\net48";
            string filename = "PackerTest.exe";
            DeleteAllButOne(folder, filename);
            Process p = Process.Start(Path.Combine(folder, filename));
            Assert.True(p.WaitForExit(5000));
            Assert.Equal(0, p.ExitCode);
        }
        
        private void DeleteAllButOne(string folder, string keepFileName)
        {
            foreach (string filename in Directory.EnumerateFiles(folder).ToList())
            {
                if (filename.EndsWith(keepFileName))
                {
                    // keep
                }
                else
                {
                    File.Delete(filename);
                }
            }
        }
    }
}