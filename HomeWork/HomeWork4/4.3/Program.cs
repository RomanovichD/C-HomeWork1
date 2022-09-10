// Задача 29: 
// Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите восемь чисел");
int[] a = new int[8];
for (int i = 0; i<a.Length; i++) 
{
    a[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i<a.Length; i++) 
{
    if (i!=a.Length-1) Console.Write($"{a[i]}, ");
    else Console.Write($"{a[i]}.");
}
Console.WriteLine();