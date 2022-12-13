// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] createArray(int size)
{
    double[] array = new double[size];
    Console.WriteLine("Введите числа массива");
    for (int i=0; i<array.Length; i++) array[i] = Convert.ToDouble(Console.ReadLine());
    return array;
}

void PrintArray(double[] array)
{
    Console.WriteLine("массив");
    foreach (double x in array) Console.WriteLine($"{x}");
}

double findMaxMin(double[] array)
{
    int i=0;
    double min = array[i];
    double max = array[i];
    while (i<array.Length)
    {
        if (min>array[i]) min = array[i];
        if (max<array[i]) max = array[i];
        i++;
    }
    double diff = max - min;
    return Math.Round(diff, 1);

}



Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = createArray(size);
PrintArray(array);
double DIFF = findMaxMin(array);
Console.WriteLine($"разница между максимальным и минимальным числом {DIFF}");