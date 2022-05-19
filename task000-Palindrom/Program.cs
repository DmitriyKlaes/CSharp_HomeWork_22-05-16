/*
Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int absoluteNumber = Math.Abs(number);
int palindrome = 0;
for (int i = absoluteNumber; i > 0; i /= 10)
{
    int quot = i % 10;
    palindrome = (palindrome + quot) * 10;
}
if (palindrome / 10 == absoluteNumber)
{
    Console.WriteLine($"Число {number} - палиндром!");
}
else
{
    Console.WriteLine($"Число {number} - не является палиндромом!");
}