// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


int[] createArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(-10, 10);
    return array;
}

void PrintArray(int[] array)
{
    foreach (int x in array) Console.WriteLine($"{x}");
}

int FindSumm(int[] array)
{
    int summ = 0;
    int i = 0;
    while (i < array.Length)
    {
        if (array[i]%2 != 0) summ = summ + array[i];
        i++;
    }
    return summ;
}

Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[] array = createArray(size);
PrintArray(array);
int summN = FindSumm(array);
Console.WriteLine($"Сумма всех нечетных чисел {summN}");
