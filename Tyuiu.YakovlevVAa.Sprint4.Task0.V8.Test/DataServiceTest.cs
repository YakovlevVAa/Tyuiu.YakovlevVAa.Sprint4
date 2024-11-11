using Tyuiu.YakovlevVAa.Sprint4.Task0.V8.Lib;
namespace Tyuiu.YakovlevVAa.Sprint4.Task0.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultEvenArrEl()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 1, 6, 3, 7, 5, 4, 2, 7, 8, 9 };
            int wait = 384;
            int res = ds.GetMultEvenArrEl(array);
            Assert.AreEqual(wait, res);
        }
    }
}