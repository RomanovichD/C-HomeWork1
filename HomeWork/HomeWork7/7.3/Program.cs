// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

averageColumn(NewTable());

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
            table[i, j] = new Random().Next(1, 100);
            Console.Write($"{table[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return (table);
}

void averageColumn(int[,] table)
{
    double[] array = new double[table.GetLength(1)];
    int a = 0;
    Console.Write("Среднее арифметическое каждого столбца: ");
    while (a < array.Length)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            double sum = 0;
            for (int t = 0; t < table.GetLength(0); t++)
            {
                sum = sum + table[t, j];
            }
            array[a] = sum / table.GetLength(0);
            if (j == table.GetLength(1) - 1) Console.Write($"{array[a]}.");
            else Console.Write($"{array[a]}; ");
            a++;
        }
    }
    Console.WriteLine();
}


