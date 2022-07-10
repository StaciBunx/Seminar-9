// Задача 64: Задайте значения M и N. Напишите программу, которая выведет произведение натуральных чисел в промежутке от M до N.

// M = 1; N = 5. ->120

// M = 4; N = 6. -> 120

using System;
using static System.Console;
Clear();

Write("Введите первое число: ");
int M = int.Parse(ReadLine());
Write("Введите второе число: ");
int N = int.Parse(ReadLine());
WriteLine($"Результат: {Multiplex(M, N)}");


int Multiplex(int start, int end)
{
    if (start == end) return end;
 
    return start * Multiplex(start+1, end);
}