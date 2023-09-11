// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.



void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-30, 31);
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

void ExchangeValueRowToCol(int[,] array)
{
    if (array.GetLength(0) != array.GetLength(1))
    {
        System.Console.WriteLine("Это невозможно");
    }
    else
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = i; j < array.GetLength(1); j++)
            {
                (array[i, j], array[j, i]) = (array[j, i], array[i, j]);
            }
        }
    }
}

System.Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
ExchangeValueRowToCol(array);
PrintArray(array);