// Задача 1. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*
int FindQvart(int x, int y)
{
    if (x > 0 && y > 0)
        return 1;
    else if (x < 0 && y > 0)
        return 2;
    else if (x < 0 && y < 0)
        return 3;
    else if (x > 0 && y < 0)
        return 4;
    else
        return 0;
}
Console.Write("Input X coordinate: ");
int xDot = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Y coordinate: ");
int yDot = Convert.ToInt32(Console.ReadLine());
int quartNum = FindQvart(xDot, yDot);
if (quartNum == 0)
    Console.Write("Dot located on the axes!");
else
    Console.Write("Number of quart is: " + quartNum);

//Задача 2 Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
void FindQvart(int qvad)
{
    if (qvad ==1)
    Console.Write("Located X > 0 , Y > 0");
    else if (qvad ==2)
    Console.Write("Located X < 0 , Y > 0");
    else if (qvad ==3)
    Console.Write("Located X < 0 , Y < 0");
    else if (qvad ==4)
    Console.Write("Located X > 0 , Y < 0");
    else
    Console.Write("Wrong number!");
}
Console.Write("input qvad number: ");
int quartNum = Convert.ToInt32(Console.ReadLine());
FindQvart(quartNum);
*/
//Задача 3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

Console.Write("Input X coordinate: ");
int xDot = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Y coordinate: ");
int yDot = Convert.ToInt32(Console.ReadLine());
int quartNum = FindQvart(xDot, yDot);

Console.WriteLine(Math.Sqrt(xb - xa)2 + (yb - ya)2))
//Задача 4. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4