

int[] arr = { 1, 3, 6, 2, 5, 4, 6, 4, 2, 9 };
void ChangeArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int min = i;
        for (int j = i+1; j < array.Length; j++)
        {
            if (arr[j] < arr[min]) min = j;
        }
            int x = arr[i];
            arr[i] = arr[min];
            arr[min] = x;
        Console.Write($"{arr[i]}");
    }

}

int count = arr.Length;
for (int i = 0; i < count; i++)
{
Console.Write($"{arr[i]}");
}
Console.WriteLine();
ChangeArr(arr); 