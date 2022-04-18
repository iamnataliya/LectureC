//Задача 1
/*
Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.Readline( ));
Console.WriteLine("Resulte is " + num*num);
*/
// Задача 2 Является ли первое число квадратом второго
/*
Console.WriteLine("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 == num2*num2)
    Console.WriteLine("First number is quad of second number");
else
    Console.WriteLine("First number is not quad of second number");
*/

// Задача 3.
/*
Console.Write("Input number of weekday: ");
int day = Convert.ToInt32(Console.ReadLine());
if(day > 7|| day < 1)
{
Console.WriteLine("Incorrect number of day!");
}
else
{
    if(day == 1)
    Console.WriteLine("It's Monday!");
     if(day == 2)
    Console.WriteLine("It's Tuesday!");
}
/*
//Задача 4 Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
/*
Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
int current = -1*num;
while(current <= num)
{
    Console.Write(current + " ");
//current = current +1
    current++;
}

// Задача 5 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа

Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num < 100 || num > 999)
   Console.WriteLine("Incorrect number");
   else
  {
      int a = num % 10;
      Console.WriteLine("Resulted number is " + a);
  } 
*/