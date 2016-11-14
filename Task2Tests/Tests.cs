using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;
using Task2;

namespace Task2Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Shape shape=new Square(2);
            Assert.AreEqual(8,shape.Perimeter);
        }
    }
}
