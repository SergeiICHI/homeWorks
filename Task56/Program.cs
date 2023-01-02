/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
sadsd
*/


void createArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 11);
        }
    }
}

void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }

}

int[] summArrays(int[,] array)
{
    int[] array2 = new int[array.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        array2[i] = sum;
        sum=0;
    }
    return array2;
}

void printArray2(int[] array)
{
    Console.WriteLine("Суммы каждой строчки");

    for(int i=0;i<array.Length;i++)
    {
        Console.WriteLine($"{array[i]} ");
    }
}

void findMinRows(int[] array)
{
    int countMin = 0;
    int min = array[0];
    for(int i=0; i<array.Length;i++)
    {
        if(min>array[i])
        {
            min = array[i];
            countMin = i;
        }
    }
    Console.WriteLine($"строчка где находится наименьшая сумма элементов {countMin +1}, сумма {min}");
}

Console.WriteLine("Введите размер вдумерного массива");
int i = Convert.ToInt32(Console.ReadLine());
int j = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array = new int[i, j];

createArray(array);
printArray(array);
int[] array2 = summArrays(array);
Console.WriteLine();
printArray2(array2);
Console.WriteLine();
findMinRows(array2);
