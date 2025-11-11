using Tyuiu.AkopovaLV.Sprint2.Task6.V6.Lib;
namespace Tyuiu.AkopovaLV.Sprint2.Task6.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual("шестерка пик", ds.FindCardNameAndValue(1, 6));
        }
    }
}
