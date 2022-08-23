// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1



Console.WriteLine("Введите трехзначное число");
string DeleteSecond()
{
    int a = int.Parse(Console.ReadLine());
    int First = a / 100;
    int Third = a % 10;
    int desired = First * 10 + Third;

    return ("ответ "+ desired);
}
Console.WriteLine(DeleteSecond());
