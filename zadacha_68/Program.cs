// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29


using System;

class Program
{
    static void Main(string[] args)
    {
        int m = 2;
        int n = 3;
        int result = AckermannFunction(m, n);
        Console.WriteLine(result);
    }

    static int AckermannFunction(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return AckermannFunction(m - 1, 1);
        }
        else
        {
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        }
    }
}


//В результате выполнения кода для значения `m = 2` и `n = 3` будет выведено "9". 
//Аналогично, для значения `m = 3` и `n = 2` будет выведено "29".