// необязательная задача. 
// Написать программу сортировки массива от 
// большего к меньшему. Массив задается 
// размерностью N с клавиатуры, далее заполняется 
// случайными целыми числами.

int[] newArray()
{
    Console.WriteLine("Введите размер массива");
    int[] a = new int[Convert.ToInt32(Console.ReadLine())];
    for (int i = 0; i < a.Length; i++) a[i] = new Random().Next(0, 100);
    // for (int i = 0; i < a.Length; i++)
    // {
    //     if (i != a.Length - 1) Console.Write($"{a[i]}, ");
    //     else Console.Write($"{a[i]}.");
    // }
    Console.Write("Новый массив: ");
    return (a);
}

int[] ChangeArr(int[] ForArray)
{
    int[] ChangeArr = ForArray;
    for (int i = 0; i < ChangeArr.Length; i++)
    {
        int max = i;
        for (int j = i + 1; j < ChangeArr.Length; j++)
        {
            if (ChangeArr[j] > ChangeArr[max]) max = j;
        }
        int x = ChangeArr[i];
        ChangeArr[i] = ChangeArr[max];
        ChangeArr[max] = x;
        // if (i != ChangeArr.Length - 1) Console.Write($"{ChangeArr[i]}, ");
        // else Console.Write($"{ChangeArr[i]}.");
    }
    Console.Write("Отсортирован: ");
    return (ChangeArr);
}

int[] PrintArr (int[] array)
{
for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}.");
    }
    Console.WriteLine();
    return (array);
}

PrintArr (ChangeArr(PrintArr (newArray())));