// Задача 23

// Напишите программу, которая принимает на вход 
// число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число");
int x = int.Parse(Console.ReadLine());
int index = 1;
while (x-x+index <= x)
{
Console.Write(Math.Pow(x-x+index,3)+", ");
index ++;
}
