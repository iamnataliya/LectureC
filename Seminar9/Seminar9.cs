﻿// Задача 1
NaturalNums(5);
void NaturalNums(int n)
{
    if (n >= 1)
    {
        Console.Write(n + " ");
        NaturalNums(n - 1);
    }
}
// Задача 2 Метод возведения числа А, в степень В