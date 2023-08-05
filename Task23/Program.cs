﻿// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число : ");
int number = Convert. ToInt32(Console.ReadLine());

if (number<1)
{
    Console.WriteLine("Некорректные данные");
    return;
}
CubeTable(number);
void CubeTable(int num)
{
    for (int i=1; i<=num; i++ )
    {
        int Cube = i*i*i;   
        Console.WriteLine($"{i,3} {Cube, 7}");
    }
}