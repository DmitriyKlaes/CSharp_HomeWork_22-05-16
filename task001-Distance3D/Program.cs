/*
Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}
double Distance3D(int[] array1, int[] array2)
{
    double x = array2[0] - array1[0];
    double y = array2[1] - array1[1];
    double z = array2[2] - array1[2];
    double result = Math.Sqrt((x * x) + (y * y) + (z * z));
    return result;
}
int[] arrayA = new int[3];
int[] arrayB = new int[3];
System.Console.WriteLine("Введите коордиты точки A (X : Y : Z):");
FillArray(arrayA);
System.Console.WriteLine("Введите коордиты точки B (X : Y : Z):");
FillArray(arrayB);
double result = Distance3D(arrayA, arrayB);
string stringArrayA = string.Join(":", arrayA);
string stringArrayB = string.Join(":", arrayB);
Console.WriteLine($"Расстояние между точками A [{stringArrayA}] и B [{stringArrayB}] в 3D пространстве равняется: " + Math.Round(result, 2));