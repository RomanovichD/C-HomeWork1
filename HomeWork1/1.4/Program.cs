// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write ("Введите целое число");
            int x = int.Parse( Console.ReadLine()  )   ;
            int y = 0;
            if (x%2 == 1) x = x - 1;
            while (x > 1) 
            {
            Console.WriteLine(x);
            x = x - 2;
            }