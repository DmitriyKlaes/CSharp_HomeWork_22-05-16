/*
Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/

void Palindrome(int arg)
{
    int absoluteNumber = Math.Abs(arg);
    int result = 0;
    for (int i = absoluteNumber; i > 0; i /= 10)
    {
        int quot = i % 10;
        result = result * 10 + quot;
    }
    if (result == absoluteNumber)
    {
        Console.WriteLine($"Число {arg} - палиндром!");
    }
    else
    {
        Console.WriteLine($"Число {arg} - не является палиндромом!");
    }
}
Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Palindrome(number);

