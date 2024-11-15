using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.YakovlevVAa.Sprint4.Task3.V18.Lib
{
    public class DataService : ISprint4Task3V18
    {
        public int Calculate(int[,] array)
        {
            int maxInLastRow = int.MinValue;
            int rowCount = array.GetLength(0);
            int lastRowIndex = rowCount - 1;
            for (int col = 0; col < array.GetLength(1); col++)
            {
                if (array[lastRowIndex, col] > maxInLastRow)
                {
                    maxInLastRow = array[lastRowIndex, col];
                }
            }
            return maxInLastRow;
        }
    }
}
