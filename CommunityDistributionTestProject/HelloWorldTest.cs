using System;
using System.IO;
using PostSharp.Community.HelloWorld;
using Xunit;

namespace CommunityDistributionTestProject
{
    public class HelloWorldTest
    {
        [Fact]
        public void HelloWorldTests()
        {
            StringWriter sw = new StringWriter();
            TextWriter original = Console.Out;
            try
            {
                Console.SetOut(sw);
                Assert.Equal(42, HelloFunction());
                Assert.Equal("Hello, world!", sw.ToString().Trim());
                sw.Close();
            }
            finally
            {
                Console.SetOut(original);
            }
        }

        [HelloWorld]
        private int HelloFunction()
        {
            return 42;
        }
    }
}