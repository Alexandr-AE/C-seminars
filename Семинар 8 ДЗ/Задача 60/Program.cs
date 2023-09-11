// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
int Input(string message)
{
    System.Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int RandomUnique(int[] array)
{
    int unique = new Random().Next(10, 100);
    if (array[unique - 10] == 0)
        array[unique - 10] = unique;
    else unique = RandomUnique(array);
    return unique;
}
void FillArray(int[,,] array, int[] unique)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
                array[i, j, k] = RandomUnique(unique);
}
void PrintArray(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                System.Console.Write($"{array[i, j, k],3}({i},{j},{k})    ");
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}
int rows = Input("Введите количество строк массива: ");
int cols = Input("Введите количество столбцов массива: ");
int line = Input("Введите количество рядов массива: ");
if (cols * rows * line > 90)
    System.Console.WriteLine("Не возможно заполнить данный массив неповторяющимися двухзначными числами");
else
{
    int[,,] array = new int[rows, cols, line];
    int[] unique = new int[90];
    FillArray(array, unique);
    System.Console.WriteLine();
    PrintArray(array);
}