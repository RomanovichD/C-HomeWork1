// Задача 50. Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

FindPosition(NewTable());

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
            table[i, j] = new Random().Next(1,100);
            Console.Write($"{table[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return (table);
}

void FindPosition(int [,] table)
{
    Console.WriteLine("Введите строку");
    int y = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите столбец");
    int x = Convert.ToInt32(Console.ReadLine());
    if (y>table.GetLength(0) || x>table.GetLength(1)) Console.WriteLine("Такого элемента нет");
    else 
    {
        Console.WriteLine($"Элемент равен: {table[y-1,x-1]}");
    }
    Console.WriteLine();
}