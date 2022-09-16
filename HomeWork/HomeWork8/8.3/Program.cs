// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

MatrixMultiplication(NewTable(), NewTable());

int[,] NewTable()
{
    Console.WriteLine("Введите количество строк");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] table = new int[m, n];
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = new Random().Next(1, 10);
            Console.Write($"{table[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return (table);
}

void MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        Console.WriteLine("Произведение этих матриц невозможно");
    }
    else
    {
        int[,] table = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
        for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++)
            {
                int tableElement = 0;
                for (int t = 0; t < matrix1.GetLength(1); t++)
                {
                    tableElement = tableElement + matrix1[i, t] * matrix2[t, j];
                }
                table[i, j] = tableElement;
                Console.Write($"{table[i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
