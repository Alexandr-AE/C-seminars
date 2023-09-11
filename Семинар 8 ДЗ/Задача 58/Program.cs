// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
int[,] ProductMatrices(int[,] array1, int[,] array2)
{
    int[,] array = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array1.GetLength(1); k++)
                array[i, j] += array1[i, k] * array2[k, j];
    return array;
}

int rows = Input("Введите количество строк первого массива: ");
int colsRows = Input("Введите количество столбцов первого массива / строк второго массива: ");
int cols = Input("Введите количество столбцов второго массива: ");
int min = Input("Введите минимальное значение случайных чисел: ");
int max = Input("Введите максимальное значение случайных чисел: ");
int[,] array1 = new int[rows, colsRows];
int[,] array2 = new int[colsRows, cols];
FillArray(array1, min, max);
FillArray(array2, min, max);

// int[,] array1 = { { 2, 4 }, { 3, 2 } }; ;
// int[,] array2 = { { 3, 4 }, { 3, 3 } }; ;

PrintArray(array1);
System.Console.WriteLine();
PrintArray(array2);
System.Console.WriteLine();
PrintArray(ProductMatrices(array1, array2));
