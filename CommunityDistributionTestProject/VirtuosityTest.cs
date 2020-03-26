using PostSharp.Community.Virtuosity;
using Xunit;

namespace CommunityDistributionTestProject
{
    public class VirtuosityTest
    {
        [Fact]
        public void TestVirtuosity()
        {
            A b = new B();
            Assert.Equal(40, b.ReturnBigNumber());
        }
    }

    [Virtual]
    public class A
    {
        public int ReturnBigNumber() => 20;
    }
    [Virtual]
    public class B : A
    {
        public new int ReturnBigNumber() => 40;
    }
}