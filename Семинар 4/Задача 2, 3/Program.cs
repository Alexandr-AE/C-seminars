// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


// int SumNumbers(int upper)
// {
// int res = 1;
// for (int i = 1; i <= upper; i++)
// res *= i;
// return res;
// }

// System.Console.WriteLine("Введите натуральное число ");
// int num = Convert.ToInt32 (Console.ReadLine());
// System.Console.WriteLine($"Произведение всех чисел от 1 до {num} равно {SumNumbers(num)}");


// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный 
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// void FillArray(int[] array)
// {
//         for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(0,2);
// }
// void PrintArray(int[] array)
// {
//     foreach (int item in array)
//         System.Console.Write($"{item} ");
//     System.Console.WriteLine();
// }
// int[] array = new int[8];
// FillArray(array);
// PrintArray(array);

void fillArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(0, 2);
}
}

void printArray(int[] array)
{
Console.Write("[ ");
for (int i = 0; i < array.Length; i++)
{
Console.Write($"{array[i]} ");
}
Console.Write("]");
}

void printDifference(int[] array)
{
int num0 = 0;
int num1 = 0;
for (int i = 0; i < array.Length; i++)
{
if (array[i] == 0) num0++;
else num1++;
}
if (num0 > num1) System.Console.WriteLine($"Количество нулей ({num0}) больше количества единиц ({num1})");
else if (num0 < num1) System.Console.WriteLine($"Количество единиц ({num1}) больше количества нулей ({num0})");
else System.Console.WriteLine("Количество нулей и единиц одинаково");
}

int[] zeroOne = new int[8];
fillArray(zeroOne);
printArray(zeroOne);
printDifference(zeroOne);