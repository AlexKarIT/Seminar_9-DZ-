/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 6, 7, 8"
*/

int M = 4;
int N = 8;

string PrintNumbers(int start, int end)
{
    // Базовый случай - выход из рекурсии
    if (start == end) return start.ToString();
    // Рекурсивный случай

    return (start + ", " + PrintNumbers(start + 1, end));
}

Console.Write($"M = {M}; N = {N}. -> ");
Console.Write(PrintNumbers(M, N));