﻿/*Сформируйте трёхмерный массив из неповторяющихся (HARD - случайных уникальных) двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

void createArray(int[,,] array)
{
    int[] array1 = new int[(array.GetLength(0) * array.GetLength(1) * array.GetLength(2))];
    for (int i =0; i < array1.Length; i++)
    {
        int k = 0;
        array1[i] = new Random().Next(0, 11);
        while (k < i)
        {
            if (array1[i] == array1[k])
            {
                array1[i] = new Random().Next(0, 11);
                k = 0;
            }
            else k++;
        }
    }
    int l = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i,j,k] = array1[l];
                l++;
            }
        }
    }
}

void printArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k})  ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] array = new int[2, 2, 2];
createArray(array);
printArray(array);