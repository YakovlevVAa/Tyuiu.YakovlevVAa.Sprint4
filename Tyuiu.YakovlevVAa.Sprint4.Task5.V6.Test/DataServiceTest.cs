using Tyuiu.YakovlevVAa.Sprint4.Task5.V6.Lib;
namespace Tyuiu.YakovlevVAa.Sprint4.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5,5] { {0, -1, -2, 3, 1 }, { 0, -1, -2, 3, 1 }, { 0, -1, -2, 3, 1 }, { 0, -1, -2, 3, 1 }, { 0, -1, -2, 3, 1 } };
            int[,] wait = new int[,] { { 0, -1, -2, 1, 1 }, { 0, -1, -2, 1, 1 }, { 0, -1, -2, 1, 1 }, { 0, -1, -2, 1, 1 }, { 0, -1, -2, 1, 1 } };
            int[,] res = ds.Calculate(matrix);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}