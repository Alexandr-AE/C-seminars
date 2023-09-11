// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
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
void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int jMax = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, jMax])
                    jMax = k;
            }
            int temp = array[i, j];
            array[i, j] = array[i, jMax];
            array[i, jMax] = temp;
        }
    }
}
int rows = Input("Введите количество строк массива: ");
int cols = Input("Введите количество столбцов массива: ");
int min = Input("Введите минимальное значение случайных чисел: ");
int max = Input("Введите максимальное значение случайных чисел: ");
int[,] array = new int[rows, cols];
FillArray(array, min, max);
PrintArray(array);
SortArray(array);
System.Console.WriteLine();
PrintArray(array);