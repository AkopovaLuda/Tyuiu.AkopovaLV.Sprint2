using Tyuiu.AkopovaLV.Sprint2.Task4.V1.Lib;
namespace Tyuiu.AkopovaLV.Sprint2.Task4.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 4;
            double z = ds.Calculate(x, y);
            double wait = 1.5;
            Assert.AreEqual(wait, z);
        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 3;
            double z = ds.Calculate(x, y);
            double wait = 2.5;
            Assert.AreEqual(wait, z);
        }
    }
}
