/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/



int summ(int n, int m)
{
    if(n == m) return n;
    return n + summ(n+1,m);
}


Console.WriteLine("Введите 2 числа, чтобы узнать сумму чисел между ними");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"Сумма чисел от {n} до {m} = {summ(n,m)}");