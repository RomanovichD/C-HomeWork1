// Задача 24: Напишите программу, которая принимает 
// на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Console.WriteLine("Введите число");
// int A = Convert.ToInt32(Console.ReadLine());
// int[] а = new int[A];
// for (int i = 0; i < A; i++) а[i] = i+1;
// int B = 0;
// for (int i = 0; i < A; i++) B = B + а[i];
// Console.WriteLine(B);


// Задача 30: Напишите программу, которая выводит массив
// из N элементов, заполненный случайными целыми числами. 
// N - целое число и задается с клавиатуры.

// int NewArr01()
// {
// Console.WriteLine("Введите размер массива");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] a = new int[N];
// for (int i = 0; i < a.Length; i++) a[i] = new Random().Next (0,10);
// return (a);
// // for (int i = 0; i < a.Length; i++) Console.Write($"{a[i]}, ");
// }

// NewArr01();

// int Max()
// {
//     int maxi = 0;
// for (int i = 0; i < NewArr01().Length; i++)
//     if (a[i] > maxi) maxi = i;
// return (maxi);
// return (NewArr01()[maxi]);
// }
// Console.WriteLine(Max());

// Функция создания массива по заданным параметрам
// Функция нахождения min, max, average в массиве

// int[] arr01(int size, int min, int max)
// {
// int[] a = new int[size];
// for (int i = 0; i < a.Length; i++) a[i] = new Random().Next (min,max);
// Console.Write("У массива: ");
// for (int i = 0; i < a.Length; i++) 
// if (i!=a.Length-1) Console.Write($"{a[i]}, ");
// else Console.WriteLine(a[i]);
// return (a);
// }

// void Maxim(int[]a)
// {
// int[] b = a;
// int maxi = 0;
// int mini = 0;
// for (int i = 0; i < b.Length; i++)
// {
//     if (b[maxi] < b[i]) maxi = i;
//     if (b[mini] > b[i]) mini = i;
// }
// double average = 0;
// foreach (int j in b) average += j;
// average = average/b.Length;
// double[] answer = 
// Console.WriteLine($"максимальное число {maxi+1} = {b[maxi]}");
// Console.WriteLine($"минимальное число  {mini+1} = {b[mini]}");
// Console.WriteLine($"среднее арифметическое всех чисел = {average}");
// }

// Maxim(arr01(5,1,50));




Задача 30: Напишите программу, 
   которая выводит массив из N элементов,
   заполненный случайными целыми числами. 
   N - целое число и задается с клавиатуры.
Random rd = new Random();
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = FillArray(N);

int[] FillArray(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < N; i++)
    {
        array[i] = rd.Next(1, 100);
    }
    return array;
}

void printArray(int[] Array)
{
    foreach (int i in Array)
    {
        Console.Write($"{i}, ");
    }
    Console.WriteLine("");
}

double[] zadacha(int[] array)
{
    //max
    //int N = array.Length;
    int max = array[0];
    int maxIndex = 0;
    for (int i = 0; i < N; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxIndex = i;
            }
        }

    //min
    int min = array[0];
    int minIndex = 0;
    for (int i = 0; i < N; i++)
    {
        if (array[i] < max)
        {
            min = array[i];
            minIndex = i;
        }
    }

    //average
    double average = 0;
    foreach(int i in array)
    {
        average += i;
    }
    average = average / array.Length;

    double[] answer = {maxIndex, minIndex, average, max, min};
    return answer;
}
//printArray(arr);
double[] answer = zadacha(arr);
Console.WriteLine($" max индекс = {answer[0]}");
Console.WriteLine($" min индекс = {answer[1]}");
Console.WriteLine($" average = {answer[2]}");
Console.WriteLine($" max = {answer[3]}");
Console.WriteLine($" min = {answer[4]}");