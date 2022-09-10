// string MessageDiapasone(int chetvert)
// {
//     if (chetvert>=0 && chetvert<=4)
//     {
//         if (chetvert == 1) return "x>0, y>0";
//         else if (chetvert == 2) return "x<0, y>0";
//         else if (chetvert == 3) return "x<0, y<0";
//         else if (chetvert == 4) return "x>0, y<0";
//         else if (chetvert == 0) return "";
//         else return "Неведанная ошибка";
//     }
//     else if (chetvert == 0) return "";
//     return "Вы ввели не номер четверти!";
// }

// int chetvert = 5;
// while (chetvert!=0)
// {
//     try 
//         {
//         Console.Write("Введите номер четверти (от 1 до 4, или 0 - выход): ");
//         chetvert = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine(MessageDiapasone(chetvert));
//         }
//     catch 
//         {
//         Console.WriteLine("Вы ввели не номер четверти!");
//         }
// }




// double Res () 
//      {
//        Console.WriteLine("Введите координаты точки A (x;у) ");
//         int Ax=Convert.ToInt32(Console.ReadLine());
//         int Ay=Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Введите координаты точки B (x;у) ");
//         int Bx=Convert.ToInt32(Console.ReadLine());
//         int By=Convert.ToInt32(Console.ReadLine());

//         int x =Ax-Bx;
//         int y = Ay-By;
//         double S = Math.Sqrt(Math.Pow(x,2)+Math.Pow(y,2));   
//         return S;
//      }
// try
// {
    
//      Console.WriteLine(Res());
            
// }
// catch
// {
//     Console.WriteLine("введите цифры");
// }        



double Res () 
     {
       Console.WriteLine("Введите координаты точки A (x;у) ");
        int Ax=Convert.ToInt32(Console.ReadLine());
        int Ay=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите координаты точки B (x;у) ");
        int Bx=Convert.ToInt32(Console.ReadLine());
        int By=Convert.ToInt32(Console.ReadLine());

        int x =Ax-Bx;
        int y = Ay-By;
        double S = Math.Sqrt(Math.Pow(x,2)+Math.Pow(y,2));   
        return S;
     }
try
{
    
     Console.WriteLine(Res());
            
}
catch
{
    Console.WriteLine("введите цифры");
}        



//Задача 22: Напишите программу, которая
//    принимает на вход число (N) и выдаёт
//    таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

void SquareTableN()
{
    Console.Write("Введите число ");
    int N = Convert.ToInt32(Console.ReadLine());
    int[] answer = new int[N];
    if (N > 0)
    {
        for (int i = 1; i < (N + 1); i++)
        {
            answer[i - 1] = (i * i);
        }
    }
    else
        {
            Console.Write("Надо было вводить положительные числа");
        }
    var str = string.Join(" ", answer);
    Console.WriteLine(str);
}

try
{
    SquareTableN();
}
catch
{
    Console.Write("Надо было вводить числа");
}
