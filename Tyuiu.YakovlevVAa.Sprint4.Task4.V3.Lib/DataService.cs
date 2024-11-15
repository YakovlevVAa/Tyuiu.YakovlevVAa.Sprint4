﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.YakovlevVAa.Sprint4.Task4.V3.Lib
{
    public class DataService : ISprint4Task4V3
    {
        public int Calculate(int[,] matrix)
        {
            int s = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] % 2 != 0)
                    {
                        s += matrix[i, j];
                    }
                }
            }
            return s;
        }
    }
}
