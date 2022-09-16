// Задача 62. 
// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

PrintMatrix(SpiralFilling(4, 4));


int[,] SpiralFilling(int m, int n)
{
    int[,] table = new int[m, n];
    int i = 0;
    int j = 0;
    int t = 1;

    while (t < m * n)
    {
        for (j = j; j <= table.GetLength(1) - i - 1; j++)
        {
            table[i, j] = t;

            t++;
        }
        j--;
        for (i = i + 1; i <= j; i++)
        {
            table[i, j] = t;

            t++;
        }
        i--;
        for (j = j - 1; j >= table.GetLength(1) - i - 1; j--)
        {
            table[i, j] = t;

            t++;
        }
        j++;
        for (i = i - 1; i > j; i--)
        {
            table[i, j] = t;

            t++;
        }
        j++;
        i++;
    }
    return (table);
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}