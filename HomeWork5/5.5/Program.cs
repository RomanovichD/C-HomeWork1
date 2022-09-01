// Задача 21 HARD - необязательная

// Напишите программу, которая принимает на вход целое 
// положительное число N и координаты двух точек и находит 
// расстояние между ними в N-мерном пространстве.

Console.WriteLine("Введите размерность пространства от 1 до 3");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 1 || a > 3) Console.WriteLine("Введите число от 1 до 3");
int[] arr = new int[a * 2];
double distance = 0;
if (a == 1) OneDimensional ();
if (a == 2) TwoDimensional ();
if (a == 3) ThreeDimensional ();
Console.WriteLine($"Расстояние между А и В = {distance}");

double OneDimensional ()
{
    Console.WriteLine("Введите координаты точки А по оси X");
    arr[0] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты точки B по оси X");
    arr[1] = Convert.ToInt32(Console.ReadLine());
    distance = arr[1] - arr[0];
    if (distance < 0) distance *= -1;
    return (distance);
}

double TwoDimensional ()
{
    Console.WriteLine("Введите координаты точки А по оси X");
    arr[0] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты точки А по оси Y");
    arr[1] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты точки B по оси X");
    arr[2] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты точки B по оси Y");
    arr[3] = Convert.ToInt32(Console.ReadLine());
    distance = Math.Sqrt((Math.Pow(arr[2] - arr[0], 2)) + (Math.Pow(arr[3] - arr[1], 2)));
    return (distance);
}

double ThreeDimensional ()
{
    Console.WriteLine("Введите координаты точки А по оси X");
    arr[0] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты точки А по оси Y");
    arr[1] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты точки А по оси Z");
    arr[2] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты точки B по оси X");
    arr[3] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты точки B по оси Y");
    arr[4] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты точки B по оси Z");
    arr[5] = Convert.ToInt32(Console.ReadLine());
    distance = Math.Sqrt((Math.Pow(arr[3] - arr[0], 2)) + (Math.Pow(arr[4] - arr[1], 2)) + (Math.Pow(arr[5] - arr[2], 2)));
    return (distance);
}