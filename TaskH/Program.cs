// Задача HARD SORT необязательная. Считается за три обязательных Задайте двумерный массив из целых чисел. 
//Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.
//Например, задан массив:
//1 4 7 2
//5 9 10 3
//После сортировки
//1 2 3 4‹
//5 7 9 10

int[,] createArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]);
        }
        Console.WriteLine();
    }
}

void sortArray(int[,] array)
{
int x = 0;
int y = 0;
int temp = 0;
while (x < array.GetLength(0))
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] > array[x,y])
            {
                temp = array[i, j];
                array[i,j] = array[x,y];
                array[x,y] = temp;
            }
        }

    }
    y++;
    if (y == array.GetLength(1))
    {
        y = 0;
        x++;
    }
}
}

Console.WriteLine("Введите размер двухмерного массива, сначала строки потом столбцы");
int size1 = Convert.ToInt32(Console.ReadLine());
int size2 = Convert.ToInt32(Console.ReadLine());
int size = size1 + size2;
int[,] array = new int[size1, size2];

PrintArray(array);
createArray(array);
Console.WriteLine();
PrintArray(array);
sortArray(array);
Console.WriteLine();
PrintArray(array);


