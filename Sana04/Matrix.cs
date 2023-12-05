using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana04
{
    internal class Matrix
    {
        public static int[,] GenerateMatrix(int ColsCount, int RowsCount, int minValue = -10, int maxValue = 10)
        {
            int[,] matrix = new int[ColsCount, RowsCount];
            Random random = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = random.Next(minValue, maxValue);
            return matrix;
        }
        public static int IntegersCount(int[,] matrix)
        {
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    if (matrix[i, j] > 0) count++;
            return count;

        }
        public static int MaxNumbreWhichOccuresMoreThenTwoTimes(int[,] matrix)
        {
            int max = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int count = 0;
                    for (int a = 0; a < matrix.GetLength(0); a++)
                    {
                        for (int b = 0; b < matrix.GetLength(1); b++)
                        {
                            if (matrix[i, j] == matrix[a, b]) count++;
                        }
                    }
                    if (count > 2)
                    {
                        if (max < matrix[i, j]) max = matrix[i, j];
                    }
                    if (max == 1) max = 0;
                }
            }
            return max;
        }
        public static int RowsWithoutZero(int[,] matrix)
        {
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                bool zeroes = false;
                for (int j = 0; j < matrix.GetLength(1); j++)
                    if (matrix[i, j] == 0)
                    {
                        zeroes = true;
                        break;
                    }
                if (zeroes) count++;
            }
            return matrix.GetLength(0) - count;
        }
        public static int ColsWithZeroes(int[,] matrix)
        {
            int count = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                bool zeroes = false;
                for (int i = 0; i < matrix.GetLength(0); i++)
                    if (matrix[i, j] == 0)
                    {
                        zeroes = true;
                        break;
                    }
                if (zeroes) count++;
            }
            return count;
        }
        public static int TheRowNumberOfLongestSeriesOfSameElements(int[,] matrix)
        {
            int max = 0;
            int maxRow = 0;
            int[] array = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int count = 1;
                int maxCount = 1;
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    if (matrix[i, j] == matrix[i, j + 1])
                    {
                        count++;
                        if (count > maxCount)
                        {
                            maxCount = count;
                        }
                    }
                    else
                    {
                        count = 1;
                    }
                }
                array[i] = maxCount;
            }
            max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                    maxRow = i;
                }
            }
            int maxCountOccurrences = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    maxCountOccurrences++;
                }
            }
            if (maxCountOccurrences > 1)
            {
                return -1;
            }
            return maxRow + 1;
        }
        public static int[] ProductOfElementsWithoutNegativeElements(int[,] matrix)
        {
            int[] array = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                array[i] = 1;
                bool negativeNum = false;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        negativeNum = true;
                        break;
                    }
                    else
                    {
                        array[i] *= matrix[i, j];
                    }
                }
                if (negativeNum)
                {
                    array[i] = 1;
                }
            }
            int a = 0;
            for (int i = 0; i < array.Length; i++)
                if (array[i] != 1) array[a++] = array[i];
            Array.Resize(ref array, a);
            return array;
        }
        public static int MaxSumOfParallelDiagonalElements(int[,] matrix)
        {
            int max = int.MinValue;
            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < matrix.GetLength(1) && i + j < matrix.GetLength(0); j++)
                {
                    sum += matrix[i + j, j];
                }
                if (sum > max)
                {
                    max = sum;
                }
            }
            for (int i = 1; i < matrix.GetLength(1); i++)
            {
                int sum = 0;
                for (int j = 0; j < matrix.GetLength(0) && i + j < matrix.GetLength(1); j++)
                {
                    sum += matrix[j, i + j];
                }
                if (sum > max)
                {
                    max = sum;
                }
            }
            return max;
        }
        public static int[] SumOfElementsInNonNegativeColumns(int[,] matrix)
        {
            int[] array = new int[matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                array[i] = 0;
                bool negativeNum = false;
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[j, i] < 0)
                    {
                        negativeNum = true;
                        break;
                    }
                    else
                    {
                        array[i] += matrix[j, i];
                    }
                }
                if (negativeNum)
                {
                    array[i] = 1;
                }
            }
            int a = 0;
            for (int i = 0; i < array.Length; i++)
                if (array[i] != 1) array[a++] = array[i];
            Array.Resize(ref array, a);
            return array;
        }
        public static int MinSumOfAbsoluteValuesOfDiagonalElementsParallelToSecondaryDiagonal(int[,] matrix)
        {
            int minAbs = int.MaxValue;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < matrix.GetLength(1) && i + j < matrix.GetLength(0); j++)
                {
                    sum += matrix[i + j, matrix.GetLength(1) - 1 - j];
                }
                if (Math.Abs(sum) < minAbs)
                {
                    minAbs = Math.Abs(sum);
                }
            }
            for (int i = 1; i < matrix.GetLength(1); i++)
            {
                int sum = 0;
                for (int j = 0; j < matrix.GetLength(0) && i + j < matrix.GetLength(1); j++)
                {
                    sum += matrix[j, matrix.GetLength(1) - 1 - i - j];
                }
                if (Math.Abs(sum) < minAbs)
                {
                    minAbs = Math.Abs(sum);
                }
            }
            return minAbs;
        }
        public static int[] SummaOfElementsInRowsWithNegativeElements(int[,] matrix)
        {
            int[] array = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                array[i] = 0;
                bool negativeNum = false;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        negativeNum = true;
                    }
                    array[i] += matrix[i, j];
                }
                if (!negativeNum)
                {
                    array[i] = 0;
                }
            }
            int a = 0;
            for (int i = 0; i < array.Length; i++)
                if (array[i] != 0) array[a++] = array[i];
            Array.Resize(ref array, a);
            return array;
        }
        public static int[,] TransponedMatrix(int[,] matrix)
        {
            int[,] transMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    transMatrix[j, i] = matrix[i, j];
            return transMatrix;
        }
    }
}