// // Задача 25: 
// Напишите цикл, который принимает на 
// вход два числа (A и B) и возводит 
// число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double degree()
{
Console.WriteLine("Введите два целых числа");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
double z = Math.Pow(x,y);
return(z);
}

Console.WriteLine(degree());