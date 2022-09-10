// Задача 48: 
// Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: 
// Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,] NewMatrix()
{
    Console.WriteLine("Введите количество строк");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов");
    int n = Convert.ToInt32(Console.ReadLine());

    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return (matrix);
}

int[] convertArray(int[,] matr)
{
    int m = matr.GetLength(0);
    int n = matr.GetLength(1);
    int[] array1 = new int[m * n];
    int t = 0;
    while (t < array1.Length)
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array1[t] = matr[i, j];
                Console.Write(array1[t]);
                t++;
            }
        }
    }
    Console.WriteLine();
    return (array1);
}




convertArray(NewMatrix());


// Задача 49: Задайте двумерный массив. Найдите элементы, 
// у которых оба индекса нечётные, и замените эти элементы на их квадраты.
// Например, изначально массив

// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть 
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

// int[,] NewMatrix()
// {
//     Console.WriteLine("Введите количество строк");
//     int m = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите количество столбцов");
//     int n = Convert.ToInt32(Console.ReadLine());

//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 10);
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
//     return (matrix);
// }

// void SortMatrix(int[,] matr)
// {
//     int m = matr.GetLength(0);
//     int n = matr.GetLength(1);
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             if (i%2 == 1 && j%2 == 1)
//             {
//                 matr [i,j]*= matr [i,j];
//             }
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// SortMatrix(NewMatrix());


// Задача 51: 
// Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// int[,] NewMatrix()
// {
//     Console.WriteLine("Введите количество строк");
//     int m = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите количество столбцов");
//     int n = Convert.ToInt32(Console.ReadLine());

//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 10);
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
//     return (matrix);
// }

// void SortMatrix(int[,] matr)
// {
//     // int m = matr.GetLength(0);
//     // int n = matr.GetLength(1);
//     int sum = 0;
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             if (i == j)
//             {
//                 sum = sum + matr[i, j];
//             }
//         }
//     }
//     Console.WriteLine();
//     Console.WriteLine(sum);
// }
// SortMatrix(NewMatrix());