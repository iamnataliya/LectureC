// //Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

// Задача 1
// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
/*
int m = 3;
int n = 5;
int[,] matrix = new int[m, n];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = i+j;
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

*/
// Задача 2
// Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

int SumOfDiagonal(int[,] quad)
{
    int sum = 0;
    for (int i = 0; i < quad.GetLength(0); i++)
    {
        sum += quad[i, i];
    }
    return sum;
}
Console.Write("Input size of matrix: ");
int size = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[size, size];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine(SumOfDiagonal(matrix));

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (i % 2 == 0 && j % 2 == 0)
        {
            Console.Write($"{i * i} {j * j}");
        }
    }
}
//Console.WriteLine(SumOfDiagonal(matrix2));

//Задача 3
//Задайте двумерный массив. 
//Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
/*
int SumOfDiagonal(int[,] quad)
{
    int sum = 0;
    for (int i = 0; i < quad.GetLength(0); i++)
    {
        sum += quad[i, i];
    }
    return sum;
}
Console.Write("Input size of matrix: ");
int size = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[size, size];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine(SumOfDiagonal(matrix));
*/