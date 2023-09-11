// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
int Input(string message)
{
    System.Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
void FillArray(int[,] array, int x, int y)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(x, y + 1);
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            System.Console.Write($"{array[i, j],3}    ");
        System.Console.WriteLine();
    }
}
int[] SumsInRows(int[,] array)
{
    int[] arraySum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            arraySum[i] += array[i, j];
    }
    return arraySum;
}
void MinSumRow(int[] array)
{
    int iMin = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < array[iMin])
            iMin = i;
    }
    if (iMin == 1)
        System.Console.WriteLine($"Наименьшая сумма элементов ({array[iMin]}) во {iMin + 1} строке");
    else System.Console.WriteLine($"Наименьшая сумма элементов ({array[iMin]}) в {iMin + 1} строке");
}


int rows = Input("Введите количество строк массива: ");
int cols = Input("Введите количество столбцов массива: ");
int min = Input("Введите минимальное значение случайных чисел: ");
int max = Input("Введите максимальное значение случайных чисел: ");
int[,] array = new int[rows, cols];
FillArray(array, min, max);
PrintArray(array);
MinSumRow(SumsInRows(array));