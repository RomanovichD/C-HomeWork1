// Задача 32: 
// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие 
// отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 




// Console.WriteLine("Введите размер массива");
//     int[] array = new int[Convert.ToInt32(Console.ReadLine())];
//     for (int i = 0; i < array.Length; i++) 
//         {
//             array[i] = new Random().Next(-9, 10);
//             if (i!=array.Length-1) Console.Write($"{array[i]}, ");
//             else Console.WriteLine($"{array[i]}");
//         }
//         Console.WriteLine("Измененный");
//         for (int item = 0; item < array.Length; item++)
//             {
//                 array[item] *= -1;
//                 Console.Write($"{array[item]}, ");
//             }
// Console.WriteLine();

// Задача 33: Задайте массив. Напишите программу, 
// которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// Console.WriteLine("Введите размер массива");
//     int[] array = new int[Convert.ToInt32(Console.ReadLine())];
//     for (int i = 0; i < array.Length; i++) 
//         {
//             array[i] = new Random().Next(-9, 10);
//             if (i!=array.Length-1) Console.Write($"{array[i]}, ");
//             else Console.WriteLine($"{array[i]}");
//         }
//         Console.WriteLine("Какое число найти?");
//         int x = Convert.ToInt32(Console.ReadLine());
//          bool find=false;
//         foreach (var item in array )
//         {
//             if (x==item)
//             {
//                 find=true;
//                 break;
//             }
//         }

//         if (find) Console.WriteLine("ДА");
//         else  Console.WriteLine("НЕТ");


// Задача 35: Задайте одномерный массив из 15 случайных 
// чисел. Найдите количество элементов массива, значения 
// которых лежат в отрезке [3,10]. 
// Пример для массива из 5, а не 123 элементов. В своём 
// решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// Console.WriteLine("Введите размер массива");
//     int[] array = new int[Convert.ToInt32(Console.ReadLine())];
//     for (int i = 0; i < array.Length; i++) 
//         {
//             array[i] = new Random().Next(-9, 10);
//             if (i!=array.Length-1) Console.Write($"{array[i]}, ");
//             else Console.WriteLine($"{array[i]}");
//         }


//     int count = 0;
//     for (int i = 0; i < array.Length; i++) 
//     {
//     if (array[i] > 2 && array[i] < 11) count++;
//     }

// Console.WriteLine(count);

// Задача 37: Найдите произведение пар чисел в 
// одномерном массиве. Парой считаем первый и 
// последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.WriteLine("Введите размер массива");
    int q = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[q];
    for (int i = 0; i < array.Length; i++) 
        {
            array[i] = new Random().Next(-9, 10);
            if (i!=array.Length-1) Console.Write($"{array[i]}, ");
            else Console.WriteLine($"{array[i]}");
        }
            int j = array.Length;
            if (j % 2 == 0) 
            {
                j /= 2;
                int[] array2 =  new int [j];
                for (int i = 0; i < j; i++)
                {
                    array2 [i] = array[i] * array[q-1-i];
                    Console.Write($"{array2[i]} ");
                }
            }
            else 
            {
                j = (j + 1) / 2;
                int[] array2 =  new int [j];
                array2[j-1] = array [j-1];
                for (int i = 0; i < j-1; i++)
                {
                array2 [i] = array[i] * array[q-1-i];
                Console.Write($"{array2[i]} ");
                }
                Console.Write($"{array2[j-1]}");
            }    
        Console.WriteLine();