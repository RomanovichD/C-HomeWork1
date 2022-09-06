// задача 40 - HARD необязательная. 
// На вход программы подаются три целых положительных числа. 
// Определить, является ли это сторонами треугольника. 
// Если да, то вывести всю информацию по нему - 
// площадь, периметр, значения углов треугольника, является ли он 
// прямоугольным, равнобедренным, равносторонним.




void triangle()
{
    Console.WriteLine("Введите стороны треугольника");
    double a = Convert.ToInt32(Console.ReadLine());
    double b = Convert.ToInt32(Console.ReadLine());
    double c = Convert.ToInt32(Console.ReadLine());
    if (a >= b + c || b >= a + c || c >= a + b) Console.WriteLine("Не треугольник");

    else
    {
        Console.WriteLine("Треугольник");
        
        Console.WriteLine($"Периметр = {a + b + c}");
        
        double p = (a + b + c) / 2;
        double S = Math.Sqrt(p * (p-a) * (p-b) * (p-c));
        Console.WriteLine($"Площадь = {S}");
        
        double a1 = Math.Round(57.296*Math.Asin((2*S)/(b*c)),2);
        double b1 = Math.Round(57.296*Math.Asin((2*S)/(a*c)),2);
        double c1 = Math.Round(57.296*Math.Asin((2*S)/(a*b)),2);
        Console.WriteLine($"Углы треугольника = ({a1}) ({b1}) ({c1})");
        
        if (a1 == 90 || b1 == 90 || a1 == 90) Console.WriteLine("Прямоугольный");
        else Console.WriteLine("Непрямоугольный");

        if (a == b || b == c || a == c) Console.WriteLine("Равнобедренный");
        else Console.WriteLine("Неравнобедренный");
        
        if (a == b && b == c) Console.WriteLine("Равносторонний");
        else Console.WriteLine("Неравносторонний");
    }
}
triangle();