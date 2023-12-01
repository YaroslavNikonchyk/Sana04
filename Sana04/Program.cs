using Sana04;

int[,] matrix = Matrix.GenerateMatrix(5, 5,0,10);
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
int RowsWithoutZeroes = Matrix.RowsWithoutZero(matrix);
int IntegersCount = Matrix.IntegersCount(matrix);
int TheRowNumberOfLongestSeriesOfSameElements = Matrix.TheRowNumberOfLongestSeriesOfSameElements(matrix);
Console.WriteLine($"Кількість чисел більших за нуль у матриці:{IntegersCount}");
Console.WriteLine($"Кількість рядків в яких немає нулів: {RowsWithoutZeroes}");
Console.WriteLine($"Кількість стовпців в яких є хоч 1 нуль: {ColsWithZeroes}");
Console.WriteLine($"Номер рядка, в якому знаходиться найдовша серія однакових елементів: {TheRowNumberOfLongestSeriesOfSameElements}");

