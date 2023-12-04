using Sana04;
Console.OutputEncoding = System.Text.Encoding.UTF8;

int n=0,m=0;
bool acces1 = false, acces2 = false;
Console.WriteLine("Задайте розміри матриці");
do
{
    if (int.TryParse(Console.ReadLine(), out n) && n > 0 && int.TryParse(Console.ReadLine(), out m) && m > 0 && n>0)
    {
        acces1 = true;
        int a, b;
        Console.WriteLine("Задайте промiжок генерацiї цілих чисел");
        do
        {
            if (int.TryParse(Console.ReadLine(), out a) && int.TryParse(Console.ReadLine(), out b) && a < b)
            {
                 
                acces2 = true;
                int[,] matrix = Matrix.GenerateMatrix(n, m, a, b);
                Console.WriteLine("Згенерована матриця:");
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write($"{matrix[i, j]}\t");
                    }

                    Console.WriteLine();
                }
                int colsWithZeroes = Matrix.ColsWithZeroes(matrix);
                int maxNumbreWhichOccuresMoreThenTwoTimes = Matrix.MaxNumbreWhichOccuresMoreThenTwoTimes(matrix);
                int rowsWithoutZeroes = Matrix.RowsWithoutZero(matrix);
                int integersCount = Matrix.IntegersCount(matrix);
                int theRowNumberOfLongestSeriesOfSameElements = Matrix.TheRowNumberOfLongestSeriesOfSameElements(matrix);
                int maxSumOfParallelDiagonalElements = Matrix.MaxSumOfParallelDiagonalElements(matrix);
                int minSumOfAbsoluteValuesOfDiagonalElementsParallelToSecondaryDiagonal = Matrix.MinSumOfAbsoluteValuesOfDiagonalElementsParallelToSecondaryDiagonal(matrix);

                Console.WriteLine($"Кількість чисел більших за нуль у матриці:{integersCount}");
                Console.WriteLine($"Mаксимальне із чисел, що зустрічається в заданій матриці більше одного разу: {maxNumbreWhichOccuresMoreThenTwoTimes}");
                Console.WriteLine($"Кількість рядків в яких немає нулів: {rowsWithoutZeroes}");
                Console.WriteLine($"Кількість стовпців в яких є хоч 1 нуль: {colsWithZeroes}");
                Console.WriteLine($"Номер рядка, в якому знаходиться найдовша серія однакових елементів: {theRowNumberOfLongestSeriesOfSameElements}");
                Console.WriteLine($"Добуток елементів в тих рядках, які не містять від’ємних елементів:");
                int[] result = Matrix.ProductOfElementsWithoutNegativeElements(matrix);
                for (int i = 0; i < result.Length; i++)
                    Console.WriteLine($"-->{result[i]}");
                Console.WriteLine($"Mаксимум серед сум елементів діагоналей, паралельних головній діагоналі матриці: {maxSumOfParallelDiagonalElements}");
                Console.WriteLine($"Сума елементів в тих стовпцях, які не містять від’ємних елементів:");
                int[] result1 = Matrix.SumOfElementsInNonNegativeColumns(matrix);
                for (int i = 0; i < result1.Length; i++)
                    Console.WriteLine($"-->{result1[i]}");
                Console.WriteLine($"Мінімум серед сум модулів елементів діагоналей, паралельних побічній діагоналі матриці: {minSumOfAbsoluteValuesOfDiagonalElementsParallelToSecondaryDiagonal}");
                Console.WriteLine($"Сума елементів в тих рядках, які містять хоч 1 від’ємний елемент:");
                int[] result2 = Matrix.SummaOfElementsInRowsWithNegativeElements(matrix);
                for (int i = 0; i < result2.Length; i++)
                    Console.WriteLine($"-->{result2[i]}");
                Console.WriteLine($"Транспонована матриця:");
                int[,] transponedMatrix = Matrix.TransponedMatrix(matrix);
                for (int i = 0; i < transponedMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < transponedMatrix.GetLength(1); j++)
                        Console.Write($"{transponedMatrix[i, j]}\t");
                    Console.WriteLine();
                }
            }
            else Console.WriteLine("Задано невiрне значення!");
        } while (!acces2);
    }
    else Console.WriteLine("Задано невiрне значення!");
} while (!acces1);