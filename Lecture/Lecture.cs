// Лекция 3 (Функции)
//Вид 1
/*
void Metod1()
{
    Console.WriteLine("Autor ...");
}
Metod1();

// Вид 2
//void Metod2(string msg)
{
   // Console.WriteLine(msg);
}
//Metod2(msg: "Message");
void Metod21(string msg, int count)
{
    int i = 0;
    {
        Console.WriteLine(msg);
        i++;
    }
}
Metod21(msg: "Natalia", count: 4);
Metod21(msg: "Nana", count: 4);

// Вид 3
int Metod3()
{
    return DateTime.Now.Year;
}
int year = Metod3();
Console.WriteLine(year);

//Вид 4 (Метод получает и возвращает) Склейка текста
 string Metod4(int count, string c)
 {
     int i = 0;
     string result = string.Empty;
     while (i<count)
     {
         result = result + c;
         i++;
     }
     return result;
 }
 string res = Metod4(10, "dhsfhsd");
 Console.WriteLine(res);

//Вид 4* (Метод получает и возвращает) замена цикла на For
string Metod4(int count, string c)
{
    int i = 0;
    string result = string.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + c;
    }
    return result;
}
string res = Metod4(10, "Z");
Console.WriteLine(res);

//Вид 5 Циклы (цикл в цикле)

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j} ");
    }
    Console.WriteLine();
}

// Вид 6 Функции програмирования замена маленькой Буквы на большую

//Дан текст. В тексте нужно все пробелы заменить черточками,
//маленькие буквы “к” заменить большими “К”, а большие “С” заменить маленькими “с”.

string text = " — Я думаю, — сказал князь, улыбаясь, — что,"
+ "ежели бы вас послали вместо нашего милого"
+ "Винценгероде, вы бы взяли приступом согласие"
+ "прусского короля. Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3] //r
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text [i]}";
}
    return result;
}
string newText = Replace(text, ' ', '/');
Console.WriteLine(newText);
*/
// Вид 7
