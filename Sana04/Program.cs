using Sana04;

int[,] matrix = Matrix.GenerateMatrix(5, 5,0,5);
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
Console.WriteLine($"Кількість рядків в яких немає нулів: {RowsWithoutZeroes}");
Console.WriteLine($"Кількість стовпців в яких є хоч 1 нуль: {ColsWithZeroes}");

