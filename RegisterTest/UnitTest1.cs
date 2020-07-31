
using NUnit.Framework;
using System.Diagnostics;

namespace RegisterTest
{
    public class Tests
    {
        RegisterLib.Register uut_;

        [SetUp]
        public void Setup()
        {
            uut_ = new RegisterLib.Register();
        }

        [Test]
        public void Test1()
        {
            Assert.That(
                ()=> uut_.AddItem(-1),
                Throws.TypeOf<System.ArgumentException>()
            );
        }
    }
}