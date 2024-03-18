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

        [TestCase(1, 4, 0, 10, "1/4")]
        [TestCase(1, 5, 2, 10,"2/5")]
        [TestCase(2,3,4,5,"22/15")]
        [TestCase(1,2,2,2,"3/2")]
        public void sum_1_5__2_10_2_5returned(int i1, int i2, int j1, int j2,string wait)
        {
            a = new lab1_num1(i1, i2);
            b = new lab1_num1(j1, j2);
            result = a + b;
            Assert.AreEqual(wait, result.ToString());
        }
        [TestCase(1, 5, 2,"11/5")]
        [TestCase(1, 3, 12, "37/3")]
        [TestCase(1, 25, 23, "576/25")]
        public void sum_1_5__2int_2_5returned(int i1, int i2, int j1,string wait)
        {
            a = new lab1_num1(i1, i2);
            result = a + j1;
            Assert.AreEqual(wait, result.ToString());
        }
        [TestCase(1, 5, 2, 10,"0")]
        [TestCase(1, 4, 2, 10, "1/20")]
        [TestCase(1, 3, 2,40, "17/60")]
        public void minus_1_5__2_10_0returned(int i1, int i2, int j1, int j2,string wait)
        {
            a = new lab1_num1(i1, i2);
            b = new lab1_num1(j1, j2);
            result = a - b;
            Assert.AreEqual(wait, result.ToString());
        }
        [TestCase(1, 5,2,"-9/5")]
        [TestCase(1,5,3,"-14/5")]
        public void minus_1_5__2int_0returned(int i1, int i2,int j,string wait)
        {
            a = new lab1_num1(i1, i2);
            result = a - j;
            Assert.AreEqual(wait, result.ToString());
        }
        [TestCase(1, 5, 2, 10,"1/25")]
        [TestCase(1, 2, 4, 3, "2/3")]
        public void ymnozhenie_1_5__2_10__1_25returned(int i1, int i2, int j1, int j2,string wait)
        {
            a = new lab1_num1(i1, i2);
            b = new lab1_num1(j1, j2);
            result = a * b;
            Assert.AreEqual(wait, result.ToString());
        }
        [TestCase(1, 5, 2,"2/5")]
        [TestCase(1,2,3,"3/2")]
        public void ymnozhenie15Int225returned(int i1, int i2, int j,string wait)
        {
            a = new lab1_num1(i1, i2);
            result = a * j;
            Assert.AreEqual(wait, result.ToString());
        }
        [TestCase(1, 5, 2, 10,"1")]
        [TestCase(1, 30, 22, 30, "1/22")]
        public void delenie_1_5__2_10__1returned(int i1, int i2, int j1, int j2,string wait)
        {
            a = new lab1_num1(i1, i2);
            b = new lab1_num1(j1, j2);
            result = a / b;
            Assert.AreEqual(wait, result.ToString());
        }
        [TestCase(1, 5, 5,"1/25")]
        [TestCase(1, 5, 1, "1/5")]
        public void delenie_1_5__5int__1_25returned(int i1, int i2, int j,string wait)
        {
            a = new lab1_num1(i1, i2);
            result = a / j;
            Assert.AreEqual(wait, result.ToString());
        }
        [TestCase(1, 5, 2, 10,true)]
        [TestCase(1, 5, 12, 10, false)]
        public void equal_1_5__2_10__falseReturned(int i1, int i2, int j1, int j2,bool wait)
        {
            a = new lab1_num1(i1, i2);
            b = new lab1_num1(j1, j2);
            bool result = a == b;
            Assert.AreEqual(wait, result);
        }
        [TestCase(1, 5, 2, 1,true)]
        [TestCase(1, 5, 1, 5, false)]
        public void NOTequal_1_5__2_10__trueReturned(int i1, int i2, int j1, int j2, bool wait)
        {
            a = new lab1_num1(i1, i2);
            b = new lab1_num1(j1, j2);
            bool result = a != b;
            Assert.AreEqual(wait, result);
        }
        [TestCase(1, 2, 2, 10, true)]
        [TestCase(1, 5, 2, 10,false)]
        public void logmore_1_5__2_10__falseReturned(int i1, int i2, int j1, int j2, bool wait)
        {
            a = new lab1_num1(i1, i2);
            b = new lab1_num1(j1, j2);
            bool result = a > b;
            Assert.AreEqual(wait, result);
        }
        [TestCase(1, 5, 2, 10,false)]
        [TestCase(1, 5, 199, 10, true)]
        public void logless_1_5__2_10__falseReturned(int i1, int i2, int j1, int j2, bool wait)
        {
            a = new lab1_num1(i1, i2);
            b = new lab1_num1(j1, j2);
            bool result = a < b;
            Assert.AreEqual(wait, result);
        }
        [TestCase(1, 5, 2, 10,true)]
        [TestCase(1, 5, 1, 10, false)]
        public void loglessORequal_1_5__2_10__TrueReturned(int i1, int i2, int j1, int j2,bool wait)
        {
            a = new lab1_num1(i1, i2);
            b = new lab1_num1(j1, j2);
            bool result = a <= b;
            Assert.AreEqual(wait, result);
        }
        [TestCase(1, 5, 2, 10,true)]
        [TestCase(1, 5, 3, 10, false)]
        public void logMoreORequal_1_5__2_10__TrueReturned(int i1, int i2, int j1, int j2,bool wait)
        { a = new lab1_num1(i1, i2);
            b = new lab1_num1(j1, j2);
            bool result = a >= b;
            Assert.AreEqual(wait, result);
        }
        [TestCase(2, 0)]
        public void zero_division_test(int i1, int i2)
        {
            Assert.Throws<ArgumentException>(() => new lab1_num1(i1, i2));
        }
    }
}
