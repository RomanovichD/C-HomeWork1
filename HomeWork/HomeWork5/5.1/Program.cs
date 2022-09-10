// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int [] NewArray()
{
    Console.WriteLine("Введите размер массива");
    int [] a = new int [Convert.ToInt32(Console.ReadLine())];
    for (int i = 0; i<a.Length; i++)
    {
        a[i] = new Random().Next(100, 999);
        if (i == a.Length-1) Console.WriteLine($"{a[i]}.");
        else Console.Write($"{a[i]}, ");
    }
return (a);
}
void even(int[] arr)
{
    int count = 0;
    for (int i = 0; i<arr.Length; i++)
    {
        if (arr[i]%2 == 0) count++;
    }   
    Console.WriteLine(count); 
}

even (NewArray());