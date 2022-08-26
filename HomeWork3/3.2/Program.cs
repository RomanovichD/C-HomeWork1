// Задача 21

// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между 
// ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Res () 
     {
       Console.WriteLine("Введите координаты точки A (x;у;z) ");
        int Ax=Convert.ToInt32(Console.ReadLine());
        int Ay=Convert.ToInt32(Console.ReadLine());
        int Az=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите координаты точки B (x;у;z) ");
        int Bx=Convert.ToInt32(Console.ReadLine());
        int By=Convert.ToInt32(Console.ReadLine());
        int Bz=Convert.ToInt32(Console.ReadLine());

        int x =Ax-Bx;
        int y = Ay-By;
        int z = Az-Bz;
        double S = Math.Sqrt(Math.Pow(x,2)+Math.Pow(y,2)+Math.Pow(z,2));   
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