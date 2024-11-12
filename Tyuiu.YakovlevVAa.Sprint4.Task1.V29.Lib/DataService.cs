using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.YakovlevVAa.Sprint4.Task1.V29.Lib
{
    public class DataService : ISprint4Task1V29
    {
        public int Calculate(int[] array)
        {
            int p = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    p += array[i];

                }
            }
            return p;
        }
    }
}
