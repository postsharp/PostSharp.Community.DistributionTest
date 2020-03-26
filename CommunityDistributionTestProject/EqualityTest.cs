using PostSharp.Community.StructuralEquality;
using Xunit;

namespace CommunityDistributionTestProject
{
    public class EqualityTest
    {
        [Fact]
        public void TestEq()
        {
            var one = new DataObject(10,20);
            var two = new DataObject(10,20);
            var three = new DataObject(10,30);
            Assert.True(one.Equals(two));
            Assert.False(one.Equals(three));
            Assert.True(one == two);
            Assert.False(one == three);
            Assert.False(one != two);
            Assert.True(one != three);
            Assert.Equal(one.GetHashCode(), two.GetHashCode());
        }
    }

    [StructuralEquality]
    public class DataObject
    {
        public int a;
        public int B { get; set; }

        public DataObject(int a, int b)
        {
            this.a = a;
            this.B = b;
        }
        
        public static bool operator ==(CommunityDistributionTestProject.DataObject left, CommunityDistributionTestProject.DataObject right) => Operator.Weave(left, right);
        public static bool operator !=(CommunityDistributionTestProject.DataObject left, CommunityDistributionTestProject.DataObject right) => Operator.Weave(left, right);
    }
}