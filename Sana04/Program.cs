using Sana04;
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
                int ColsWithZeroes = Matrix.ColsWithZeroes(matrix);
                int MaxNumbreWhichOccuresMoreThenTwoTimes = Matrix.MaxNumbreWhichOccuresMoreThenTwoTimes(matrix);
                int RowsWithoutZeroes = Matrix.RowsWithoutZero(matrix);
                int IntegersCount = Matrix.IntegersCount(matrix);
                int TheRowNumberOfLongestSeriesOfSameElements = Matrix.TheRowNumberOfLongestSeriesOfSameElements(matrix);
                int MaxSumOfParallelDiagonalElements = Matrix.MaxSumOfParallelDiagonalElements(matrix);
                int MinSumOfAbsoluteValuesOfDiagonalElementsParallelToSecondaryDiagonal = Matrix.MinSumOfAbsoluteValuesOfDiagonalElementsParallelToSecondaryDiagonal(matrix);

                Console.WriteLine($"Кількість чисел більших за нуль у матриці:{IntegersCount}");
                Console.WriteLine($"Mаксимальне із чисел, що зустрічається в заданій матриці більше одного разу: {MaxNumbreWhichOccuresMoreThenTwoTimes}");
                Console.WriteLine($"Кількість рядків в яких немає нулів: {RowsWithoutZeroes}");
                Console.WriteLine($"Кількість стовпців в яких є хоч 1 нуль: {ColsWithZeroes}");
                Console.WriteLine($"Номер рядка, в якому знаходиться найдовша серія однакових елементів: {TheRowNumberOfLongestSeriesOfSameElements}");
                Console.WriteLine($"Добуток елементів в тих рядках, які не містять від’ємних елементів:");
                int[] result = Matrix.ProductOfElementsWithoutNegativeElements(matrix);
                for (int i = 0; i < result.Length; i++)
                    Console.WriteLine($"-->{result[i]}");
                Console.WriteLine($"Mаксимум серед сум елементів діагоналей, паралельних головній діагоналі матриці: {MaxSumOfParallelDiagonalElements}");
                Console.WriteLine($"Сума елементів в тих стовпцях, які не містять від’ємних елементів:");
                int[] result1 = Matrix.SumOfElementsInNonNegativeColumns(matrix);
                for (int i = 0; i < result1.Length; i++)
                    Console.WriteLine($"-->{result1[i]}");
                Console.WriteLine($"Мінімум серед сум модулів елементів діагоналей, паралельних побічній діагоналі матриці: {MinSumOfAbsoluteValuesOfDiagonalElementsParallelToSecondaryDiagonal}");
                Console.WriteLine($"Сума елементів в тих рядках, які містять хоч 1 від’ємний елемент:");
                int[] result2 = Matrix.SummaOfElementsInRowsWithNegativeElements(matrix);
                for (int i = 0; i < result2.Length; i++)
                    Console.WriteLine($"-->{result2[i]}");
                Console.WriteLine($"Транспонована матриця:");
                int[,] TransponedMatrix = Matrix.TransponedMatrix(matrix);
                for (int i = 0; i < TransponedMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < TransponedMatrix.GetLength(1); j++)
                        Console.Write($"{TransponedMatrix[i, j]}\t");
                    Console.WriteLine();
                }
            }
            else Console.WriteLine("Задано невiрне значення!");
        } while (!acces2);
    }
    else Console.WriteLine("Задано невiрне значення!");
} while (!acces1);