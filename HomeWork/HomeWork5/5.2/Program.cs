// Задача 36: 
// Задайте одномерный массив, заполненный 
// случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

void sum(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i=i+2) sum += arr[i];
    Console.WriteLine(sum);
}

sum (NewArray());