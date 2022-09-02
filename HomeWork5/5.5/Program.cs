// Задача 21 HARD - необязательная

// Напишите программу, которая принимает на вход целое 
// положительное число N и координаты двух точек и находит 
// расстояние между ними в N-мерном пространстве.


double Distance()
{
    Console.WriteLine("Введите количество осей");
    int a = Convert.ToInt32(Console.ReadLine());
    if (a < 1) Console.WriteLine("Введите положительное число");
    double[] arr = new double[a * 2];
    double distance = 0;

    for (int i = 0; i < a; i++)
    {
        Console.WriteLine($"Введите координаты точки A по оси {i + 1}");
        arr[i] = Convert.ToDouble(Console.ReadLine());
    }
    for (int i = 0; i < a; i++)
    {
        Console.WriteLine($"Введите координаты точки B по оси {i + 1}");
        arr[i + a] = Convert.ToDouble(Console.ReadLine());
    }
    double[] sum = new double[a];
    for (int i = 0; i < a; i++)
    {
        sum[i] = Math.Pow(arr[a + i] - arr[i], 2);
        distance = distance + sum[i];
    }
    distance = Math.Sqrt(distance);
    return (distance);
}

Console.WriteLine($"Расстояние между А и В = {Distance()}");