using Tyuiu.YakovlevVAa.Sprint4.Task6.V4.Lib;
namespace Tyuiu.YakovlevVAa.Sprint4.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            var array = new string[] { "Москва", "Санкт Петербург", "Новосибирск", "Екатеринбург", "Нижний Новгород", "Казахстан", "Самара" };
            DataService ds = new DataService();
            string[] res = ds.Calculate(array);
            string[] wait = { "Москва", "Самара" };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}