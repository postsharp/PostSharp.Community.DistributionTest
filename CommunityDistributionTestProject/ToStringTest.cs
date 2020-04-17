using PostSharp.Community.ToString;
using Xunit;

namespace CommunityDistributionTestProject
{
    [ToString(IncludePrivate = true)]
    public class ToStringTest
    {
        private int a = 2;

        [Fact]
        public void TestSelf()
        {
            Assert.Equal("{ToStringTest; a:2}", this.ToString());
        }

    }
}