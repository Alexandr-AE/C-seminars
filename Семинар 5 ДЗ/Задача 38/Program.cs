// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
void DifferenceMaxMin(decimal[] array)
{
    int minIndex = 0;
    int maxIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[maxIndex] < array[i])
            maxIndex = i;
        else if (array[minIndex] > array[i])
            minIndex = i;
    }
    System.Console.WriteLine($"Разница между максимальным {array[maxIndex]} и минимальным {array[minIndex]} элементом массива равна {array[maxIndex] - array[minIndex]}");
}
int Input(string message)
{
    System.Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
void FillArray(decimal[] array, int min, int max)
{
    decimal num;
    for (int i = 0; i < array.Length; i++)
    {
        num = Convert.ToDecimal(new Random().NextDouble());
        array[i] = Convert.ToDecimal(new Random().Next(min, max)) + Math.Round(num, 2);
    }
}
void PrintArray(decimal[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            System.Console.Write($"{array[i]}; ");
        else System.Console.Write($"{array[i]}");
    }
    System.Console.WriteLine("]");
}
int size = Input("Введите длину массива: ");
int min = Input("Введите минимальное значение случайных чисел: ");
int max = Input("Введите максимальное значение случайных чисел: ");
decimal[] array = new decimal[size];
FillArray(array, min, max);
PrintArray(array);
DifferenceMaxMin(array);