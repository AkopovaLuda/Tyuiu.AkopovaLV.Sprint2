using Tyuiu.AkopovaLV.Sprint2.Task3.V16.Lib;
namespace Tyuiu.AkopovaLV.Sprint2.Task3.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest : IDataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = ds.Calculate(x);
            double wait = 11;
            Assert.AreEqual(wait, y);
        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = ds.Calculate(x);
            double wait = 0.75;
            Assert.AreEqual(wait, y);

        }
        [TestMethod]
        public void TestMethod3()
        {
            DataService ds = new DataService();
            double x = -3;
            double y = ds.Calculate(x);
            double wait = 2.091;
            Assert.AreEqual(wait, y);

        }
        [TestMethod]
        public void TestMethod4()
        {
            DataService ds = new DataService();
            double x = -21;
            double y = ds.Calculate(x);
            double wait = -230.952;
            Assert.AreEqual(wait, y);

        }
    }
}
