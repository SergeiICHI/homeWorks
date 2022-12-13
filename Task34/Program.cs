// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2

int [] createArray(int size)
{
    int [] array = new int[size];
    for(int i=0; i<array.Length; i++) array[i] = new Random().Next(100, 1000);
    return array;
}


void printArray(int[] array)
{
    foreach (int x in array)
        Console.WriteLine($"{x}");
}

int evenNumb(int[] array)
{
    int i = 0;
    int count = 0;
    while (i<array.Length)
    {
        if (array[i] % 2 == 0) count = count +1;
        i++;
        
    }
    
    return count;
}

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = createArray(size);
printArray(array);
int count = evenNumb(array);
Console.WriteLine($"количество четных чисел в массиве {count}");

