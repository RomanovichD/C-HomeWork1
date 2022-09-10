// Задача 40: 
// Напишите программу, которая принимает на вход три 
// числа и проверяет, может ли существовать треугольник 
// с сторонами такой длины.



// int[] NewArray()
// {
//     int[] a = {Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())};
//     for (int i = 0; i < a.Length; i++)
//     {
//         if (i == a.Length - 1) Console.WriteLine($"{a[i]}.");
//         else Console.Write($"{a[i]}, ");
//     }
//     return (a);
// }
// NewArray();


// Console.WriteLine("Введите три числа");
//     int a = Convert.ToInt32(Console.ReadLine());
//     int b = Convert.ToInt32(Console.ReadLine());
//     int c = Convert.ToInt32(Console.ReadLine());

// bool IfTriangle (int a, int b, int c)
// {
//         if (a<b+c && b<a+c && c<a+b) return true;
//     else return false;
// }

// if (IfTriangle ())
// {
//     int P = a + b + c;
// }





// Задача 42: Напишите программу, которая будет 
// преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// int[] a = new int [];
// a[a.Length-1-i] = 

// Console.WriteLine("Введите число");
// int a = Convert.ToInt32(Console.ReadLine());
// int c = 0;
// string b = String.Empty;
// while (a >= 1)
// {
//     c = a%2;
//     b = b+Convert.ToString(c);
//     a = a/2;
// }
// char [] b2 = b.ToCharArray();
// Array.Reverse(b2);
// Console.WriteLine(b2);


// !!!!!!!

Console.WriteLine("Insert number");
int N = Convert.ToInt32(Console.ReadLine());

int []arr = new int[N];
arr[0] = 0;
arr[1] = 1;

for (int i = 2; i < N; i++)
{
    arr[i] = arr[i-1] + arr[i-2];
}
Console.WriteLine(string.Join(",", arr));

