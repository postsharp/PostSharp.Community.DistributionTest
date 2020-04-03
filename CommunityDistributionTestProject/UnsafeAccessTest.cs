using System;
using PostSharp.Community.UnsafeMemoryChecker;
using Xunit;

[assembly: CheckUnsafeMemory]

namespace CommunityDistributionTestProject
{
    public class UnsafeAccess
    {
        [Fact]
        public unsafe void ThrowOnBadAccess()
        {
            Assert.Throws<AccessViolationException>(() =>
            {
                int a = 40;
                int* ap = &a;
                *ap = 20;
            });
        }
    }
}