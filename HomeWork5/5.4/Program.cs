// Задача 19 HARD - необязательная

// Напишите программу, которая принимает на вход 
// любое число и проверяет, является ли оно палиндромом.


int[] NewArray()
{
    Console.WriteLine("Введите число");
    string q = Console.ReadLine();
    int b = Convert.ToInt32(q);
    int [] a = new int[q.Length];
    for (int i = 0; i < a.Length; i++)
    {
        a[a.Length-1-i] = b%10;
        b = b/10;
    }
    return (a);
}

void CheckPalindrome(int[] arr)
{
    bool x = true;
    for (int i = 0; i<arr.Length; i++)
    {
        if (arr[i] == arr [arr.Length-1-i]) x = true;
        else x = false;
    }
    if (x) Console.WriteLine("да");
    else Console.WriteLine("нет");
}

CheckPalindrome(NewArray());