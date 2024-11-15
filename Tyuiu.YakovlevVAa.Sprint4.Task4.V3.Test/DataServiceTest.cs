using Tyuiu.YakovlevVAa.Sprint4.Task4.V3.Lib;
namespace Tyuiu.YakovlevVAa.Sprint4.Task4.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] array = { { 7, 9, 7, 8, 6 }, { 4, 4, 4, 8, 6 }, { 7, 9, 6, 7, 6 }, { 7, 5, 4, 9, 8 }, { 9, 6, 4, 9, 8 } };
            int wait = 85;
            int res = ds.Calculate(array);
            Assert.AreEqual(wait, res);
        }
    }
}