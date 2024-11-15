using Tyuiu.YakovlevVAa.Sprint4.Task2.V25.Lib;
namespace Tyuiu.YakovlevVAa.Sprint4.Task2.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 3, 9, 4, 2, 3, 3, 3, 5, 7, 7, 4};
            int wait = 32;
            int res = ds.Calculate(array);
            Assert.AreEqual(wait, res);
        }
    }
}