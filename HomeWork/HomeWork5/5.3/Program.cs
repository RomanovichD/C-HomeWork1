// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] NewArray()
{
    Console.WriteLine("Введите размер массива");
    double[] a = new double[Convert.ToInt32(Console.ReadLine())];
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().NextDouble()*5;
        if (i == a.Length - 1) Console.WriteLine($"{a[i]}.");
        else Console.Write($"{a[i]}, ");
    }
    return (a);
}

void DiffMinMax(double[] arr)
{
    int j = 0;
    double min = arr[j];
    double max = arr[j];
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