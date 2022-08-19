// Задача 4: Напишите программу, которая принимает на вход 
// три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write ("Введите три целых числа ");
            int x = int.Parse( Console.ReadLine()  )   ;
            int y = int.Parse( Console.ReadLine()  )   ;
            int z = int.Parse( Console.ReadLine()  )   ;
            int max = x;
            if (max < y) max = y;
            if (max < z) max = z;
            Console.WriteLine("max = "+ max);