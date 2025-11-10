using Tyuiu.AkopovaLV.Sprint2.Task1.V9.Lib;
namespace Tyuiu.AkopovaLV.Sprint2.Task1.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            bool[] res = new bool[6];
            int a = 15;
            int b = 335;
            int c = 174;
            int d = 478;
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { false, false, true, false, true, false };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
