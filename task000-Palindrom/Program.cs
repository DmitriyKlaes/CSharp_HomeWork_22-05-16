/*
Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(System.Console.ReadLine());
//int numberSave = number;
int newNumber = 0;
for (int i = number; i > 0; i = i / 10)
{
    int quot = i % 10;
    newNumber = (quot * 10) + newNumber;
    //if (i == 0)
    //{
        System.Console.WriteLine(i);
        System.Console.WriteLine(number);
        System.Console.WriteLine(newNumber);
    //}    
}