using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RegisterLib;

namespace RegisterTestFramework
{
    [TestFixture]
    public class Class1
    {
        private Register uut_;

        [SetUp]
        public void Setup()
        {
            uut_ = new Register();
        }
    }
}
