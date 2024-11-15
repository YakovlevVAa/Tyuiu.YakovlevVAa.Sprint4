using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.YakovlevVAa.Sprint4.Task6.V4.Lib
{
    public class DataService : ISprint4Task6V4
    {
        public string[] Calculate(string[] array)
        {
            string[] lgth = Array.FindAll(array, x => x.Length < 7);
            return lgth;
        }
    }
}
