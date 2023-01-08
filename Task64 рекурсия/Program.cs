/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1*/

int numbersTo1(int n)
{
    if (n==1) return n;
    Console.Write($"{n} ");
    return numbersTo1(n-1);
}

Console.WriteLine("введите число, чтобы вывести все числа до 1");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"{numbersTo1(n)} ");