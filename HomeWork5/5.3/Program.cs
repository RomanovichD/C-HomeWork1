// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] NewArray()
{
    Console.WriteLine("Введите размер массива");
    int[] a = new int[Convert.ToInt32(Console.ReadLine())];
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(-10, 10);
        if (i == a.Length - 1) Console.WriteLine($"{a[i]}.");
        else Console.Write($"{a[i]}, ");
    }
    return (a);
}

void DiffMinMax(int[] arr)
{
    int j = 0;
    int min = arr[j];
    int max = arr[j];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]<min) min = arr[i];
        if (arr[i]>max) max = arr[i];
    }
    Console.WriteLine($"Max = {max};");
    Console.WriteLine($"Min = {min}.");
    Console.WriteLine($"Diff = {max-min}");
}

DiffMinMax(NewArray());