// 41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int[] CreateArray(int size)
{
    int[] array = new int[size];
    Console.WriteLine("Введите числа массива");
    for(int i = 0;i<size; i++)
    array[i]= Convert.ToInt32(Console.ReadLine());
    return array;
}
int CountArray(int[] array)
{
    int count = 0;
    for (int i =0;i<array.Length;i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}


Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
int count = CountArray(array);
Console.WriteLine($"Пользователь ввел {count} чисел больше 0");