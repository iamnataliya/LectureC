// Задача 1 Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*
int NaturalSum(int a)
{
    int sum = 0;
    if (a < 1) return 0;
    else
    {
        for (int i = 1; i <= a; i++)
        {
            sum = sum+i;
            //sum +=i; Выполяет тоже самое что и строчка 10
        }
        return sum;
    }
}
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sum of elements is " + NaturalSum(num));
// Задача 2 Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

System.Console.WriteLine();

System.Console.Write("Введите число:   ");
string writeNum = Console.ReadLine();
int number = Convert.ToInt32(writeNum);
int result = number;
int count1 = 0;
while (result > 0)
{
    result = result / 10;
    count1++;
}
System.Console.WriteLine("Первый способ:");
System.Console.WriteLine($"В числе {number} {count1} цифр");
System.Console.WriteLine();
// Задача 3 Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N. (Факториал)

int Fartorial(int a)
{
    int fakt = 1;
    if (a < 1) return 0;
    else
    {
        for (int i = 1; i <= a; i++)
        {
            fakt = fakt * i;
        }
        return fakt;
    }
}
Console.Write("input number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Faktorial = " + Fartorial(num));
*/
// Задача 4 Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
int N = 8;

int[] SetArray(int x)
{
    int[] arr = new int[x];
    for (int i = 0; i < x; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        System.Console.Write($"{array[i]} ");
}

PrintArray(SetArray(N));