// Задача 56: 
// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

SmallestStringInMatrix(NewTable());

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

void SmallestStringInMatrix(int[,] matrix)
{
    int[] sumStrings = new int[matrix.GetLength(0)];
    for (int t = 0; t < matrix.GetLength(0); t++)
    {
        int sumString = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumString = sumString + matrix[t, j];
        }
        sumStrings[t] = sumString;
    }
    int minString = 0;
    int sumMinString = sumStrings[0];
    for (int i = 0; i < sumStrings.Length; i++)
    {
        if (sumStrings[i] < sumMinString)
        {
            minString = i;
            sumMinString = sumStrings[i];
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {minString+1}");
}

