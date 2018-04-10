using NUnit.Framework;

namespace NunitTesting
{
    [TestFixture]

    class MyTestCase
    {
        public MyTestCase()
        {
        }

        [TestCase]

        public void Add()
        {
            MyCalculator cal = new MyCalculator();
            Assert.AreEqual(10, cal.Add(6,4));
        }

        [TestCase]
        public void Sub()
        {
            MyCalculator cal = new MyCalculator();
            Assert.AreEqual(10, cal.Add(20,10));
        }

        [TestCase]
        public void Mul()
        {
            MyCalculator cal = new MyCalculator();
            Assert.AreEqual(20, cal.Add(5, 4));
        }

        [TestCase]
        public void Div()
        {
            MyCalculator cal = new MyCalculator();
            Assert.AreEqual(100, cal.Add(500, 5));
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
