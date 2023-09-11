// **Задача HARD SORT.**

// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. 
// Отсортировать элементы по возрастанию слева направо и сверху вниз.

// Например, задан массив:
// 1 4 7 2
// 5 9 10 3

// После сортировки
// 1 2 3 4
// 5 7 9 10


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
            int minI = i;
            int minJ = j;
            for (int m = i; m < array.GetLength(0); m++)
            {
                if (m == i)
                {
                    for (int n = j; n < array.GetLength(1); n++)
                    {
                        if (array[m, n] < array[minI, minJ])
                        {
                            minI = m;
                            minJ = n;
                        }
                    }
                }
                else
                {
                    for (int n = 0; n < array.GetLength(1); n++)
                    {
                        if (array[m, n] < array[minI, minJ])
                        {
                            minI = m;
                            minJ = n;
                        }
                    }
                }
            }
            int temp = array[i, j];
            array[i, j] = array[minI, minJ];
            array[minI, minJ] = temp;
        }
    }
}
int Input(string message)
{
    System.Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
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