using System;
using static System.Console;
Clear();
Write("Введите число M: ");
int m = int.Parse(ReadLine()!);
Write("Введите число N: ");
int n = int.Parse(ReadLine()!);
WriteLine(Akerman(m, n));

int Akerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0))
    {
        return Akerman(m - 1, 1);
    }
    else {
        return Akerman(m - 1, Akerman(m, n - 1));
    }
}