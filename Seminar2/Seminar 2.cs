// Задача 1
/*
int ShowNumber()
{
    int num = new Random().Next(10, 99);
    int firstNum = num/10;
    int secondNum = num%10;
    Console.Write(num + " -> ");
    if(firstNum > secondNum)
    { 
       return firstNum;
    }
    else
    {
        return secondNum;
    }
}
int a = ShowNumber();
Console.WriteLine(a);
*/
//Задача 2 Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
/*
void ReduceNumber()
{
    int num = new Random().Next(100, 999);
    Console.Write(num + " -> ");
    int num1 = num / 100;
    int num2 = num % 10;
    int num3 = num1 * 10 + num2;
  
    Console.Write(num3);
}
ReduceNumber();
*/

//Задача 3 Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.
/*
void IfMultiple()
{
    Console.Write("Input first number: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input first number: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    if (num1 % num2 == 0)
    {
        Console.Write(num1 + "is multiple of " + num2);
    }
    else
    {
        Console.Write(num1 + "is NOT multiple of " + num2);
    }
}
IfMultiple();
*/

//Задача 4 Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
/*
void Multiplate()
{
    Console.Write("Input number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num % 7 == 0 & num % 23 == 0)
    {
    Console.Write(num + " is multiplate of 7 and 23");
}
else
{
    Console.Write(num + " is NOT multiplate of 7 and 23");
}
}
Multiplate();

//Задача 5 Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
void Sqr(int num1, int num2)
{
    if (num1 == num2 * num2)
    {
        Console.Write("Yes");
    }
    else
    {
        Console.Write("No");
    }
}
Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Sqr(num1, num2);
*/
