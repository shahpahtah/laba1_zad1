using ConsoleApp3;

namespace class1test
{
    public class class1test
    {
        lab1_num1 a = new lab1_num1(0, 1);
        lab1_num1 b = new lab1_num1(0, 1);
        lab1_num1 result;
        [SetUp]
        public void Setup()
        {
           
        }

        [Test]
        public void sum_1_5__2_10_2_5returned() 
        {
            a = new lab1_num1(1, 5);
            b = new lab1_num1(2, 10);
            result = a + b;
            Assert.AreEqual("2/5", result.ToString());
        }
        [Test]
        public void sum_1_5__2int_2_5returned()
        {
            a = new lab1_num1(1, 5);
            b = new lab1_num1(2, 10);
            result = a + 2;
            Assert.AreEqual("11/5", result.ToString());
        }
        [Test]
        public void minus_1_5__2_10_0returned()
        {
            a = new lab1_num1(1, 5);
            b = new lab1_num1(2, 10);
            result = a - b;
            Assert.AreEqual("0", result.ToString());
        }
        [Test]
        public void minus_1_5__2int_0returned()
        {
            a = new lab1_num1(1, 5);
            b = new lab1_num1(2, 10);
            result = a - 2;
            Assert.AreEqual("-9/5", result.ToString());
        }
        [Test]
        public void ymnozhenie_1_5__2_10__1_25returned()
        {
            a = new lab1_num1(1, 5);
            b = new lab1_num1(2, 10);
            result = a * b;
            Assert.AreEqual("1/25", result.ToString());
        }
        [Test]
        public void ymnozhenie15Int225returned()
        {
            a = new lab1_num1(1, 5);
            b = new lab1_num1(2, 10);
            result = a * 2;
            Assert.AreEqual("2/5", result.ToString());
        }
        [Test]
        public void delenie_1_5__2_10__1returned()
        {
            a = new lab1_num1(1, 5);
            b = new lab1_num1(2, 10);
            result = a / b;
            Assert.AreEqual("1", result.ToString());
        }
        [Test]
        public void delenie_1_5__5int__1_25returned()
        {
            a = new lab1_num1(1, 5);
            b = new lab1_num1(2, 10);
            result = a / 5;
            Assert.AreEqual("1/25", result.ToString());
        }
        [Test]
        public void equal_1_5__2_10__falseReturned()
        {
            a = new lab1_num1(1, 5);
            b = new lab1_num1(2, 10);
            bool result = a == b;
            Assert.AreEqual(false, result);
        }
        [Test]
        public void NOTequal_1_5__2_10__trueReturned()
        {
            a = new lab1_num1(1, 5);
            b = new lab1_num1(2, 10);
            bool result = a != b;
            Assert.AreEqual(true, result);
        }
        [Test]
        public void logmore_1_5__2_10__falseReturned()
        {
            a = new lab1_num1(1, 5);
            b = new lab1_num1(2, 10);
            bool result = a > b;
            Assert.AreEqual(false, result);
        }
        [Test]
        public void logless_1_5__2_10__falseReturned()
        {
            a = new lab1_num1(1, 5);
            b = new lab1_num1(2, 10);
            bool result = a < b;
            Assert.AreEqual(false, result);
        }
        [Test]
        public void loglessORequal_1_5__2_10__TrueReturned()
        {
            a = new lab1_num1(1, 5);
            b = new lab1_num1(2, 10);
            bool result = a <= b;
            Assert.AreEqual(true, result);
        }
        [Test]
        public void logMoreORequal_1_5__2_10__TrueReturned()
        {
            a = new lab1_num1(1, 5);
            b = new lab1_num1(2, 10);
            bool result = a >= b;
            Assert.AreEqual(true, result);
        }
    }
}