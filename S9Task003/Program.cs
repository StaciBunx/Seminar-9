// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

using System;
using static System.Console;
Clear();

Write("Введите первое число: ");
int M = int.Parse(ReadLine());
Write("Введите второе число: ");
int N = int.Parse(ReadLine());
WriteLine($"Результат: {Akkerman(M, N)}");


int Akkerman(int a, int b)
{
    if (a == 0) return b + 1;
    else
    if (a != 0 && b == 0) return Akkerman(a - 1, 1);
    else
    return Akkerman(a - 1, Akkerman(a, b - 1));
    
}