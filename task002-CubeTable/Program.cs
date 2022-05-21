/*
Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 4, 9.
5 -> 1, 8, 27, 64, 125
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

void CubeTable(int number)
{
    Console.Write($"Кубы чисел от 1 до {number}: ");
    if (number > 0)
    {
        for (int i = 1; i <= number; i++)
        {
            int result = i * i * i;
            Console.Write(result);
            if (i <= number - 1)
            {
                Console.Write(", ");
            }
        }
    }
    else
    {
        for (int i = 1; i >= number; i--)
        {
            int result = i * i * i;
            Console.Write(result);
            if (i >= number + 1)
            {
                Console.Write(", ");
            }
        }
    }
}
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
CubeTable(number);