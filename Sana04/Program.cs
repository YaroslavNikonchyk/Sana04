using Sana04;
Console.OutputEncoding = System.Text.Encoding.UTF8;

int n = 0, m = 0;
bool acces1 = false, acces2 = false;
Console.WriteLine("Задайте розміри матриці");
do
{
    if (int.TryParse(Console.ReadLine(), out n) && n > 0 && int.TryParse(Console.ReadLine(), out m) && m > 0 && n > 0)
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
                Console.WriteLine("============================================================================================================");
                Console.WriteLine($"Кількість чисел більших за нуль у матриці:{integersCount}");
                Console.WriteLine("============================================================================================================");
                if (maxNumbreWhichOccuresMoreThenTwoTimes > 0)
                {
                    Console.WriteLine($"Mаксимальне із чисел, що зустрічається в заданій матриці більше одного разу: {maxNumbreWhichOccuresMoreThenTwoTimes}");
                }
                else Console.WriteLine("Всі числа матриці унікальні");
                Console.WriteLine("============================================================================================================");
                Console.WriteLine($"Кількість рядків в яких немає нулів: {rowsWithoutZeroes}");
                Console.WriteLine("============================================================================================================");
                Console.WriteLine($"Кількість стовпців в яких є хоч 1 нуль: {colsWithZeroes}");
                Console.WriteLine("============================================================================================================");
                if (theRowNumberOfLongestSeriesOfSameElements != -1)
                {
                    Console.WriteLine($"Номер рядка(індекс + 1), в якому знаходиться найдовша серія однакових елементів: {theRowNumberOfLongestSeriesOfSameElements}");
                }
                else Console.WriteLine("В деяких рядках однакові найдовші серії елементів");
                Console.WriteLine("============================================================================================================");
                Console.WriteLine($"Добуток елементів в тих рядках, які не містять від’ємних елементів:");
                int[] result = Matrix.ProductOfElementsWithoutNegativeElements(matrix);
                if (result.Length > 1)
                {
                    for (int i = 0; i < result.Length; i++)
                        Console.WriteLine($"-->{result[i]}");
                }
                else Console.WriteLine("Рядки без від'ємних елементів відсутні");
                Console.WriteLine("============================================================================================================");
                Console.WriteLine($"Mаксимум серед сум елементів діагоналей, паралельних головній діагоналі матриці: {maxSumOfParallelDiagonalElements}");
                Console.WriteLine("============================================================================================================");
                Console.WriteLine($"Сума елементів в тих стовпцях, які не містять від’ємних елементів:");
                int[] result1 = Matrix.SumOfElementsInNonNegativeColumns(matrix);
                if (result1.Length > 1)
                {
                    for (int i = 0; i < result1.Length; i++)
                        Console.WriteLine($"-->{result1[i]}");
                }
                else Console.WriteLine("Стовпці без від'ємних елементів відсутні");
                Console.WriteLine("============================================================================================================");
                Console.WriteLine($"Мінімум серед сум модулів елементів діагоналей, паралельних побічній діагоналі матриці: {minSumOfAbsoluteValuesOfDiagonalElementsParallelToSecondaryDiagonal}");
                Console.WriteLine("============================================================================================================");
                Console.WriteLine($"Сума елементів в тих рядках, які містять хоч 1 від’ємний елемент:");
                int[] result2 = Matrix.SummaOfElementsInRowsWithNegativeElements(matrix);
                if (result2.Length > 1)
                {
                    for (int i = 0; i < result2.Length; i++)
                        Console.WriteLine($"-->{result2[i]}");
                }
                else Console.WriteLine("Рядки з від'ємними елементами відсутні");
                Console.WriteLine("============================================================================================================");
                Console.WriteLine($"Транспонована матриця:");
                int[,] transponedMatrix = Matrix.TransponedMatrix(matrix);
                for (int i = 0; i < transponedMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < transponedMatrix.GetLength(1); j++)
                        Console.Write($"{transponedMatrix[i, j]}\t");
                    Console.WriteLine();
                }
                Console.WriteLine("============================================================================================================");
            }
            else Console.WriteLine("Задано невiрне значення!");
        } while (!acces2);
    }
    else Console.WriteLine("Задано невiрне значення!");
} while (!acces1);