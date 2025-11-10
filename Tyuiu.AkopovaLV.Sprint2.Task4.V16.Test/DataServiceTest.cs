using Tyuiu.AkopovaLV.Sprint2.Task4.V16.Lib;
namespace Tyuiu.AkopovaLV.Sprint2.Task4.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 0;
            double res = ds.Calculate(x, y);
            double wait = 11;
            Assert.AreEqual(wait, res);

        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 0;
            double res = ds.Calculate(x, y);
            double wait = 0.75;
            Assert.AreEqual(wait, res);

        }
        [TestMethod]
        public void TestMethod3()
        {
            DataService ds = new DataService();
            double x = -3;
            double y = 0;
            double res = ds.Calculate(x, y);
            double wait = 2.091;
            Assert.AreEqual(wait, res);

        }
        [TestMethod]
        public void TestMethod4()
        {
            DataService ds = new DataService();
            double x = -21;
            double y = 0;
            double res = ds.Calculate(x, y);
            double wait = -230.952;
            Assert.AreEqual(wait, res);

        }
    }
}
