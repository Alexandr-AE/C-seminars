// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int Input(string message)
{
    System.Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
void FillArray(int[] array, int x, int y)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(x, y + 1);
}
void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            System.Console.Write($"{array[i]}, ");
        else System.Console.Write($"{array[i]}");
    }
    System.Console.WriteLine("]");
}
void NumberOfEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    System.Console.WriteLine($"Количество четных чисел: {count}");
}

int size = Input("Введите длину массива: ");
int x = Input("Введите минимальное значение случайных чисел: ");
int y = Input("Введите максимальное значение случайных чисел: ");
int[] array = new int[size];
FillArray(array, x, y);
PrintArray(array);
NumberOfEven(array);