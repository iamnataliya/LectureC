// Задача 1 Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
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