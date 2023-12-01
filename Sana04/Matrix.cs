﻿using System;
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
            int count = 0;
            int max = 0;
            for (int i = 1; i < matrix.GetLength(0); i++)
                for (int j = 1; j < matrix.GetLength(1); j++)
                    if (true) ;

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
                int count = 0;
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    if (matrix[i, j] == matrix[i, j + 1]) count++;
                    array[i] = count;
                }
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
            return maxRow;
        }
        public static int ProductOfElementsWithoutNegativeElements(int[,] matrix)
        {
            int product = 1;

        }
    }
}
