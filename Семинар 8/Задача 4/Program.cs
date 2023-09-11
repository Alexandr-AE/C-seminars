// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.


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

void PrintNewArray(int[,] array)
{
    int iMin = 0;
    int jMin = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[iMin, jMin] > array[i, j])
            {
                iMin = i;
                jMin = j;
            }
    System.Console.WriteLine($"Минимальное значение {array[iMin, jMin]}");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            if (i != iMin && j != jMin)
            {
                System.Console.Write($"{array[i, j],3}    ");
            }
        if (i != iMin)
            System.Console.WriteLine();
    }
}

int rows = Input("Введите количество строк массива: ");
int cols = Input("Введите количество столбцов массива: ");
int randomMin = Input("Введите минимальное значение случайных чисел: ");
int randomMax = Input("Введите максимальное значение случайных чисел: ");
int[,] array = new int[rows, cols];
FillArray(array, randomMin, randomMax);
PrintArray(array);
PrintNewArray(array);