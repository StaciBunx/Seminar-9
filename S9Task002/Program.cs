// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using System;
using static System.Console;
Clear();

Write("Введите первое число: ");
int M = int.Parse(ReadLine());
Write("Введите второе число: ");
int N = int.Parse(ReadLine());
WriteLine($"Результат: {Sum(M, N)}");

int Sum(int start, int end)
{
    if (start == end) return end;
 
    return start + Sum(start+1, end);
}