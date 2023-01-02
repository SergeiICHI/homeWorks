// Создайте программу, которая будет искать произведение двух матриц


void createArray(int[,] array, int[,] array2)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5);
        }
    }

    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            array2[i, j] = new Random().Next(1, 5);
        }
    }

}

void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void arrayMultiplier(int[,] array, int[,] array2)
{
    int sum = 0;
    int[,] arrayMulti = new int[array.GetLength(0), array2.GetLength(1)];
    int k = 0;
    while (k < arrayMulti.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum = sum + (array[i, j] * array2[j, k]);
            }
            arrayMulti[i, k] = sum;
            sum = 0;
        }
        k++;
    }
    
    for(int i =0;i<arrayMulti.GetLength(0);i++)
    {
        for(int j=0;j<arrayMulti.GetLength(1);j++)
        {
            Console.Write($"{arrayMulti[i,j]}  ");
        }
        Console.WriteLine();
    }
}




Console.WriteLine("введите размер первой матрицы");
int i = Convert.ToInt32(Console.ReadLine());
int j = Convert.ToInt32(Console.ReadLine());
int[,] arrayM = new int[i, j];

Console.WriteLine("введите размер второй матрицы");
int i1 = Convert.ToInt32(Console.ReadLine());
int j1 = Convert.ToInt32(Console.ReadLine());
int[,] arrayM1 = new int[i1, j1];
Console.WriteLine();

createArray(arrayM, arrayM1);
printArray(arrayM);
Console.WriteLine();
printArray(arrayM1);
Console.WriteLine();
arrayMultiplier(arrayM,arrayM1);


