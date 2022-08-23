// Задача 15: Напишите программу, которая принимает на 
// вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("введите число");
string FindThird()
{
    int a = int.Parse(Console.ReadLine());
    if (a < 8)
    {
        if (a < 6) return ("нет");
        else return ("да");
    }
    else return ("такого дня недели нет");
}
Console.WriteLine(FindThird());