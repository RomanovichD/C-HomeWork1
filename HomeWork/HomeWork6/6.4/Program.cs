// задача 2 HARD необязательная. 
// Сгенерировать массив случайных целых чисел размерностью m*n 
// (размерность вводим с клавиатуры). Вывести на экран красивенько таблицей. 
// Перемешать случайным образом элементы массива, причем чтобы каждый 
// гарантированно переместился на другое место и выполнить это за m*n / 2 итераций. 
// То есть если массив три на четыре, то надо выполнить не более 6 итераций. 
// И далее в конце опять вывести на экран как таблицу.


int [,] NewMatrix()
{
    Console.WriteLine("Введите количество строк");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов");
    int n = Convert.ToInt32(Console.ReadLine());

    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return (matrix);
}

void Print(int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void mix (int[,] mat)
{
    for (int i = 0; i < mat.GetLength(0)-1; i++)
    {
        for (int j = 0; j < mat.GetLength(1)-1; j++)
        {
            int y = mat[i,j];
            mat[i,j] = mat[i+1,j];
            mat[i+1,j] = y;
            y = mat[i,j+1];
            mat[i,j+1] = mat[i+1,j+1];
            mat[i+1,j+1] = y;
            Print(mat);
        }
    }
}

mix (NewMatrix());