/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int M = 4;
int N = 8;

int sum = 0;

int SummNumber(int leftnumber, int rightnumber)
{
    if (leftnumber > rightnumber) return 0;

    sum += leftnumber;
    leftnumber++;
    SummNumber(leftnumber, rightnumber);
    return sum;
}

SummNumber(M, N);
Console.WriteLine($"Сумма чисел от {M} до {N} : {sum}");