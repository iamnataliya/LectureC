// Семинар 5
//Задача 1
// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
int[] ChangNums(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] *= (-1);
    return array;
}
// Задача 2
// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
/*
int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
        Console.WriteLine();
}
void FindNumber(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
       if(array[i] == num)
       Console.Write("Number find!");
       else
       Console.Write("Number NOT find!");
       break;
    }
}
Console.WriteLine("Size massiv: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Max massiv: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Min massiv: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Number fin in massiv: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(size, min, max);
FindNumber(array, num);
*/
// Задача 3
// Задайте одномерный массив из 15 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int FindNum3(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array.Length <= 99) ;
        {
            count++;
        }
    }
    return count;
}
//Задача 4
// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
int[] NewMagic(int[] array)
{
    int newSize = array.Length / 2;
    int[] newArray = new int[newSize];

    for (int i = 0, j = array.Length - 1; i < newSize; i++, j--)
    {
    newArray[i] = array[i] * array[j];
    }
    return newArray;
}
int[] arr = CreateRandomArray(6, 1, 9);
int[] newArr = NewMagic(arr);
ShowArray(newArr);