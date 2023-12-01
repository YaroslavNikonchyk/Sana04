using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana04
{
    internal class Matrix
    {
        public static double[,] GenerateArray(int ColsCount, int RowsCount, double minValue = -10, double maxValue = 10, int digitCount = 2)
        {
            double[,] matrix = new double[ColsCount, RowsCount];
            Random random = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = Math.Round(minValue + (random.NextDouble() * (maxValue - minValue)), digitCount);
            return matrix;
        }
        public static int IntegersCount(double[,] matrix)
        {
            int count=0;
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    if (matrix[i, j] > 0) count++;
            return count;
        }
        public static double MaxNumbreWhichOccuresMoreThenTwoTimes(double[,] matrix)
        {
            int count = 0;
            double max = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    if (matrix[i, j] > 0) count++;
            return max;
        }
    }
}
