// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int Input(string message)
{
    System.Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
void FillArray(int[,] array, int n)
{
    int m = 0, k = n - 1, i = 0, j = 0, temp = 1;
    array[i, j] = temp;
    while (temp < n * n)
    {
        while (j < k)
        {
            temp++;
            j++;
            array[i, j] = temp;
        }
        while (i < k)
        {
            temp++;
            i++;
            array[i, j] = temp;
        }
        while (j > m)
        {
            temp++;
            j--;
            array[i, j] = temp;
        }
        m++;
        k--;
        while (i > m)
        {
            temp++;
            i--;
            array[i, j] = temp;
        }
    }
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
int num = Input("Введите размер квадратного массива: ");
int[,] array = new int[num, num];
FillArray(array, num);
PrintArray(array);