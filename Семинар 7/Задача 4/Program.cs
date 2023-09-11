// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 
// 5 9 2 
// 8 4 2 
// Сумма элементов главной диагонали: 1+9+2 = 12
// и сумму элементов обратной диагонали 8 + 9 + 7 = 24

void FillArray(int[,] array) 
{ 
    for (int i = 0; i < array.GetLength(0); i++) 
        for (int j = 0; j < array.GetLength(1); j++) 
            array[i, j] = new Random().Next(1, 10); 
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
 
int SumOfStraightDiagonal(int[,] array) 
{ 
    int result = 0; 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        result += array[i, i]; 
    } 
    return result; 
} 
 
int SumOfReverseDiagonal(int[,] array) 
{ 
    int result = 0; 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        result += array[array.GetLength(0) - 1 - i , i]; 
    } 
 
    return result; 
} 
 
System.Console.WriteLine("Введите количество строк:"); 
int rows = Convert.ToInt32(Console.ReadLine()); 
System.Console.WriteLine("Введите количество столбцов:"); 
int cols = Convert.ToInt32(Console.ReadLine()); 
 
int[,] array = new int[rows, cols]; 
FillArray(array); 
PrintArray(array); 
System.Console.WriteLine(SumOfStraightDiagonal(array)); 
System.Console.WriteLine(SumOfReverseDiagonal(array));