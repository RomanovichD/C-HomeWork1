// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

void NewArray(int m)
{
    Console.WriteLine("Введите числа");
    int[] ar = new int[m];
    int count = 0;
    for (int i = 0; i < m; i++)
    {
        ar[i] = Convert.ToInt32(Console.ReadLine());
        if (ar[i] > 0) count++;
    }
    Console.WriteLine($"положительных чисел: {count}");
}
NewArray(5);