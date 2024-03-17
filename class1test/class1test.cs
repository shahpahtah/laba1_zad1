using ConsoleApp3;
using System.ComponentModel.Design.Serialization;

namespace class1test
{
    [TestFixture]
    public class class1test
    {
        lab1_num1? a = null;
        lab1_num1? b = null;
        lab1_num1? result = null;
        [SetUp]
        public void Setup()
        {
            a = new lab1_num1(1, 5);
            b = new lab1_num1(2, 10);
        }

        [TestCase(1, 5, 2, 10)]
        public void sum_1_5__2_10_2_5returned(int i1, int i2, int j1, int j2)
        {
            a = new lab1_num1(i1, i2);
            b = new lab1_num1(j1, j2);
            result = a + b;
            Assert.AreEqual("2/5", result.ToString());
        }
        [TestCase(1, 5, 2, 10)]
        public void sum_1_5__2int_2_5returned(int i1, int i2, int j1, int j2)
        {
            a = new lab1_num1(i1, i2);
            b = new lab1_num1(j1, j2);
            result = a + 2;
            Assert.AreEqual("11/5", result.ToString());
        }
        [TestCase(1, 5, 2, 10)]
        public void minus_1_5__2_10_0returned(int i1, int i2, int j1, int j2)
        {
            a = new lab1_num1(1, 5);
            b = new lab1_num1(2, 10);
            result = a - b;
            Assert.AreEqual("0", result.ToString());
        }
        [TestCase(1, 5)]
        public void minus_1_5__2int_0returned(int i1, int i2)
        {
            a = new lab1_num1(i1, i2);
            result = a - 2;
            Assert.AreEqual("-9/5", result.ToString());
        }
        [TestCase(1, 5, 2, 10)]
        public void ymnozhenie_1_5__2_10__1_25returned(int i1, int i2, int j1, int j2)
        {
            a = new lab1_num1(i1, i2);
            b = new lab1_num1(j1, j2);
            result = a * b;
            Assert.AreEqual("1/25", result.ToString());
        }
        [TestCase(1, 5, 2)]
        public void ymnozhenie15Int225returned(int i1, int i2, int j)
        {
            a = new lab1_num1(1, 5);
            result = a * j;
            Assert.AreEqual("2/5", result.ToString());
        }
        [TestCase(1, 5, 2, 10)]
        public void delenie_1_5__2_10__1returned(int i1, int i2, int j1, int j2)
        {
            a = new lab1_num1(i1, i2);
            b = new lab1_num1(j1, j2);
            result = a / b;
            Assert.AreEqual("1", result.ToString());
        }
        [TestCase(1, 5, 5)]
        public void delenie_1_5__5int__1_25returned(int i1, int i2, int j)
        {
            a = new lab1_num1(1, 5);
            result = a / j;
            Assert.AreEqual("1/25", result.ToString());
        }
        [TestCase(1, 5, 2, 10)]
        public void equal_1_5__2_10__falseReturned(int i1, int i2, int j1, int j2)
        {
            a = new lab1_num1(i1, i2);
            b = new lab1_num1(j1, j2);
            bool result = a == b;
            Assert.AreEqual(false, result);
        }
        [TestCase(1, 5, 2, 10)]
        public void NOTequal_1_5__2_10__trueReturned(int i1, int i2, int j1, int j2)
        {
            a = new lab1_num1(i1, i2);
            b = new lab1_num1(j1, j2);
            bool result = a != b;
            Assert.AreEqual(true, result);
        }
        [TestCase(1, 5, 2, 10)]
        public void logmore_1_5__2_10__falseReturned(int i1, int i2, int j1, int j2)
        {
            a = new lab1_num1(i1, i2);
            b = new lab1_num1(j1, j2);
            bool result = a > b;
            Assert.AreEqual(false, result);
        }
        [TestCase(1, 5, 2, 10)]
        public void logless_1_5__2_10__falseReturned(int i1, int i2, int j1, int j2)
        {
            a = new lab1_num1(i1, i2);
            b = new lab1_num1(j1, j2);
            bool result = a < b;
            Assert.AreEqual(false, result);
        }
        [TestCase(1, 5, 2, 10)]
        public void loglessORequal_1_5__2_10__TrueReturned(int i1, int i2, int j1, int j2)
        {
            a = new lab1_num1(i1, i2);
            b = new lab1_num1(j1, j2);
            bool result = a <= b;
            Assert.AreEqual(true, result);
        }
        [TestCase(1, 5, 2, 10)]
        public void logMoreORequal_1_5__2_10__TrueReturned(int i1, int i2, int j1, int j2)
        {
            a = new lab1_num1(i1, i2);
            b = new lab1_num1(j1, j2);
            bool result = a >= b;
            Assert.AreEqual(true, result);
        }
        [TestCase(2, 0)]
        public void zero_division_test(int i1, int i2)
        {
            Assert.Throws<ArgumentException>(() => new lab1_num1(i1, i2));
        }
    }
}
