// Задача HARD SORT.
// Задайте двумерный массив из целых чисел. 
// Количество строк и столбцов задается с клавиатуры. 
// Отсортировать элементы по возрастанию слева направо и сверху вниз.
// Например, задан массив:
// 1 4 7 2
// 5 9 10 3
// После сортировки
// 1 2 3 4
// 5 7 9 10

Console.WriteLine("Введите количество строк");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов");
    int n = Convert.ToInt32(Console.ReadLine());

convertInMatrix(SortArrayMinMax(convertInArray(NewMatrix())));

int[,] NewMatrix()
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 100);
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return (matrix);
}

int[] convertInArray(int[,] matr)
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
                Console.Write($"{array1[t]} ");
                t++;
            }
        }
    }
    Console.WriteLine();
    Console.WriteLine();
    return (array1);
}

int[] SortArrayMinMax(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        int min = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[min]) min = j;
        }
        int help = arr[i];
        arr[i] = arr[min];
        arr[min] = help;
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
    Console.WriteLine();
    return (arr);
}

int[,] convertInMatrix(int[] arr)
{
    int[,] table = new int [m,n];
    int t = 0;
    while (t < arr.Length)
    {
        for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++)
            {
                table[i, j] = arr[t];
                Console.Write($"{table[i, j]} ");
                t++;
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
    return (table);
}
