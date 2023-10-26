//Задача 66: Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using System;

class Program
{
    static void Main(string[] args)
    {
        int m = 1;
        int n = 15;
        int sum = SumNaturalElements(m, n);
        Console.WriteLine(sum);
    }

    static int SumNaturalElements(int m, int n)
    {
        if (m > n)
        {
            throw new ArgumentException("Некорректные границы промежутка"); // Проверка на некорректные границы
        }

        if (m == n)
        {
            return m; // Возвращаем единственный элемент
        }
        else
        {
            return m + SumNaturalElements(m + 1, n); // Рекурсивно вызываем функцию для следующего элемента и складываем со значением текущего элемента
        }
    }
}


//В результате выполнения кода для значения `m = 1` и `n = 15` будет выведено "120". 
//Аналогично, для значения `m = 4` и `n = 8` будет выведено "30".