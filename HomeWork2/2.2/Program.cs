// Задача 13: Напишите программу, которая выводит третью 
// цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("введите число");
string FindThird()
{
    int a = int.Parse(Console.ReadLine());
    int b = 0;
    if (a < 100) return ("третьей цифры нет");
    else
    {    
        while (a > 99)
        {
            a = a / 10;
        }
        return ("ответ " + a % 10);
    }
}
Console.WriteLine(FindThird());