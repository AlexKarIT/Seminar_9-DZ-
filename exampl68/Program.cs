/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/


int ack(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return ack(m - 1, 1);
    else return ack(m - 1, ack(m, n - 1));

}

// ввод данных
int m = 2;
int n = 3;

/*
цикл для выяснения границ выпадения ошибки переполнения стека
for (int i = 0; i < 100; i++)
{
    int n = i;
    Console.WriteLine($"Функция Аккермана от {m} и {n} -> A({m},{n}) = {ack (m, n)}");
}
*/

Console.WriteLine();
if (m < 3 || m == 3 && n < 12 || m == 4 & n == 0) Console.WriteLine($"Функция Аккермана от {m} и {n} -> A({m},{n}) = {ack(m, n)}");
else Console.WriteLine($"Выполнение функции Аккермана от {m} и {n} -> A({m},{n}) приведет к переполнению стека");