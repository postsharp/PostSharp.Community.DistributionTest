using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using PostSharp.Community.DeepSerializable;
using Xunit;

namespace CommunityDistributionTestProject
{
    public class DeepSerializableTest
    {
        [Fact]
        public void TestItIsSerializable()
        {
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, new World());
            ms.Close();
        }

        [DeepSerializable]
        public class World
        {
            public Animal Hero = new Animal();
        }
        public class Animal
        {
        }
    }

}