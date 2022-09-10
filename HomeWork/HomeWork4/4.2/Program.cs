// Задача 27: 
// Напишите программу, которая принимает на 
// вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите целое число");
int b = 0;
for (int a = Convert.ToInt32(Console.ReadLine()); a>0; a=a/10) b = b + a%10;
Console.WriteLine(b);

