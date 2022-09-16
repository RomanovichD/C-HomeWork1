// Задача 64: 
// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

string AllNumbersRec(int m, int n)
{
if (m==n) return ".";
if (m==n-1) return m + ".";
return m + "," + AllNumbersRec(m+1, n);
}

Console.WriteLine(AllNumbersRec(1, 6));