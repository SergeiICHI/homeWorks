// задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void createArray(int[,] array)
{
    for(int i =0;i<array.GetLength(0);i++)
    {
        for(int j =0;j<array.GetLength(1);j++)
        {
            array[i,j] = new Random().Next(0,10);
        }
    }
}

void printArray(int[,] array)
{
    for(int i=0;i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
        {
            Console.Write($"{array[i,j]}  ");
        }
        Console.WriteLine();
    }
}

void swapArray(int[,] array)
{
    int y = 0;
    int temp;
    while (y<array.GetLength(1))
    {
    for(int i =0;i<array.GetLength(0);i++)
    {
        for(int j =0;j<array.GetLength(1);j++)
        {
            if(array[i,y] > array[i,j])
            {
                temp = array[i, j];
                array[i,j] = array[i,y];
                array[i,y] = temp;
            }
        }
    }
    y++;
    }
}



Console.WriteLine("введите кол строк и столбцов двумерного массива");
int i = Convert.ToInt32(Console.ReadLine());
int j = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[i,j];
createArray(array);
printArray(array);
swapArray(array);
Console.WriteLine();
printArray(array);